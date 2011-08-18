using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;
using System.Xml;
using System.Threading;

namespace stockMgr
{
    public class StockMgr
    {
        private StockCollection _indexCollection;

        public StockMgr()
        {
            _indexCollection = new StockCollection();
        }

        /// <summary>
        /// Get simple quote of a single stock
        /// </summary>
        /// <param name="stock">Stock for quote</param>
        public void GetQuote(StockData stock)
        {
            try
            {
                if (stock.code.Substring(stock.code.Length - 3) == ".HK")  //Is HK stock
                {
                    GetQuoteFromM18(stock);
                    //GetQuoteFromAA(stock);
                }
                else if (stock.code[0] == '^' && _indexCollection.Find(stock.code.Substring(1)) >= 0)    //is index
                {
                    _indexCollection[stock.code.Substring(1)].CopyTo(stock);
                }
                else
                {
                    //Get data from Yahoo!
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://download.finance.yahoo.com/d/quotes.csv?s=" + stock.code + "&f=snl1cgh");
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Stream webStream = response.GetResponseStream();
                    StreamReader sr = new StreamReader(webStream);
                    string hstring = sr.ReadToEnd();
                    sr.Close();
                    webStream.Close();
                    response.Close();
                    Regex regexObj = new Regex(@"(""([^""]*|""{2})*""(,|$))|""[^""]*""(,|$)|[^,]+(,|$)|(,)");
                    MatchCollection matchResults = regexObj.Matches(hstring);
                    stock.name = matchResults[1].Value.Trim(new char[] { '"', ',' });
                    stock.close = float.Parse(matchResults[2].Value.Trim(new char[] { '"', ',' }));
                    string[] strChange = matchResults[3].Value.Trim(new char[] { '"', ',' }).Split(new String[] { " - " }, StringSplitOptions.None);
                    if (strChange[0] != "N/A")
                    {
                        stock.change = float.Parse(strChange[0].Trim('\"'));
                        stock.ROC = float.Parse(strChange[1].Trim(new char[] { '\"', '%' }));
                    }
                    float.TryParse(matchResults[4].Value.Trim(new char[] { '"', ',' }), out stock.low);
                    float.TryParse(matchResults[5].Value.Trim(new char[] { '"', ',' }), out stock.high);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Get simple quote of list of stocks
        /// </summary>
        /// <param name="stocks">List of stocks</param>
        public void GetQuote(StockData[] stocks)
        {
            if (stocks.Length == 0)
                return;

            try
            {
                System.Text.StringBuilder codes = new System.Text.StringBuilder(stocks.Length);
                codes.Append(stocks[0].code);
                for (int i = 1; i < stocks.Length; i++)
                    codes.Append('+' + stocks[i].code);
                
                //Get data from Yahoo!
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://download.finance.yahoo.com/d/quotes.csv?s=" + codes.ToString() + "&f=snl1cgh");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream webStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(webStream);
                string hstring = sr.ReadToEnd();
                sr.Close();
                webStream.Close();
                response.Close();
                string[] allData = hstring.Split(new string [] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);
                Regex regexObj = new Regex(@"(""([^""]*|""{2})*""(,|$))|""[^""]*""(,|$)|[^,]+(,|$)|(,)");
                for (int i = 0, j = 0; i < stocks.Length && j < allData.Length; i++, j++)
                {
                    MatchCollection matchResults = regexObj.Matches(allData[j]);
                    while (i < stocks.Length && stocks[i].code.Trim() != matchResults[0].Value.Trim(new char[] { '"', ',' }))
                        i++;
                    stocks[i].name = matchResults[1].Value.Trim(new char[] { '"', ',' });
                    stocks[i].close = float.Parse(matchResults[2].Value.Trim(new char[] { '"', ',' }));
                    string[] strChange = matchResults[3].Value.Trim(new char[] { '"', ',' }).Split(new String[] { " - " }, StringSplitOptions.None);
                    if (strChange[0] != "N/A")
                    {
                        stocks[i].change = float.Parse(strChange[0].Trim('\"'));
                        stocks[i].ROC = float.Parse(strChange[1].Trim(new char[] { '\"', '%' }));
                    }
                    float.TryParse(matchResults[4].Value.Trim(new char[] { '"', ',' }), out stocks[i].low);
                    float.TryParse(matchResults[5].Value.Trim(new char[] { '"', ',' }), out stocks[i].high);
                }

                ManualResetEvent[] doneEvents = new ManualResetEvent[stocks.Length];
                List<Exception> exs = new List<Exception>();
                Mutex exsMutex = new Mutex();
                for (int i = 0; i < stocks.Length; i++)
                {
                    doneEvents[i] = new ManualResetEvent(true);
                    if (stocks[i].code.Substring(stocks[i].code.Length - 3) == ".HK")  //Is HK stock
                    {
                        ManualResetEvent curEvent = doneEvents[i];
                        StockData curStock = stocks[i];
                        doneEvents[i].Reset();
                        new Thread(delegate()
                            {
                                try
                                {
                                    //GetQuoteFromAA(curStock);
                                    GetQuoteFromM18(curStock);
                                }
                                catch (Exception ex)
                                {
                                    exsMutex.WaitOne();
                                    exs.Add(ex);
                                    exsMutex.ReleaseMutex();
                                }
                                curEvent.Set();
                            }).Start();
                    }
                    else if (stocks[i].code[0] == '^' && _indexCollection.Find(stocks[i].code.Substring(1)) >= 0)    //is index
                    {
                        stocks[i] = _indexCollection[stocks[i].code.Substring(1)].Clone();
                    }
                }
                WaitHandle.WaitAll(doneEvents);
                if (exs.Count > 0)
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    foreach (Exception ex in exs)
                        sb.Append(ex.Message + "\n");
                    throw new Exception(sb.ToString());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public double GetVolatility(string code, int numOfDays)
        {
            double[] prices;
            DateTime dayFrom = DateTime.Today.AddDays(-numOfDays);
            string url = "http://ichart.yahoo.com/table.csv?s=" + code + "&d=" + (DateTime.Today.Month - 1).ToString() + "&e=" + DateTime.Today.Day.ToString() + "&f=" +
                DateTime.Today.Year + "&g=d&a=" + (dayFrom.Month - 1).ToString() + "&b=" + dayFrom.Day.ToString() + "&c=" + dayFrom.Year.ToString() + "&ignore=.csv";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream webStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(webStream);
                string hstring = sr.ReadToEnd();
                sr.Close();
                webStream.Close();
                response.Close();
                string[] allData = hstring.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                Regex regexObj = new Regex(@"(""([^""]*|""{2})*""(,|$))|""[^""]*""(,|$)|[^,]+(,|$)|(,)");
                prices = new double[allData.Length - 1];
                for (int i = 0; i < prices.Length; i++)
                {
                    MatchCollection matchResults = regexObj.Matches(allData[i+1]);
                    prices[i] = double.Parse(matchResults[6].Value.Trim(new char[] { '"', ',' }));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Him.Finance.Stock.Utility.CalVolatility(prices);
        }

        public void RefreshHKIndice()
        {
            XmlDocument xmlIndex = new XmlDocument();
            try
            {
                xmlIndex.Load("http://www.hsi.com.hk/HSI-Net/ql//HSI-Net/HSI-Net?cmd=simpleindex");
                XmlNode allIndex = xmlIndex.GetElementsByTagName("allindex")[0];
                for (int i = 0; i < allIndex.ChildNodes.Count; i++)
                {
                    string code = ((XmlElement)allIndex.ChildNodes[i]).GetAttribute("code").Trim();
                    int pos = _indexCollection.Find(code);
                    StockData curIndex;
                    if (pos < 0)      //New code
                    {
                        curIndex = new StockData();
                        curIndex.code = code;
                        _indexCollection.Add(curIndex);
                    }
                    else
                    {
                        curIndex = _indexCollection[pos];
                    }
                    curIndex.close = float.Parse(((XmlElement)allIndex.ChildNodes[i]).GetAttribute("current"));
                    curIndex.change = float.Parse(((XmlElement)allIndex.ChildNodes[i]).GetAttribute("change"));
                    curIndex.ROC = float.Parse(((XmlElement)allIndex.ChildNodes[i]).GetAttribute("percent"));
                    curIndex.low = float.Parse(((XmlElement)allIndex.ChildNodes[i]).GetAttribute("low"));
                    curIndex.high = float.Parse(((XmlElement)allIndex.ChildNodes[i]).GetAttribute("high"));
                    curIndex.name = ((XmlElement)allIndex.ChildNodes[i]).GetElementsByTagName("cname")[0].InnerText;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public StockCollection Indice
        {
            get { return _indexCollection; }
        }

        /// <summary>
        /// Get real-time price from aastock
        /// </summary>
        /// <param name="stock"></param>
        private void GetQuoteFromAA(StockData stock)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.aastocks.com/tc/ltp/rtquote.aspx?symbol=" + stock.code.Substring(0, stock.code.Length - 3));
                request.UserAgent = "-";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream resStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(resStream);
                string htmlData = sr.ReadToEnd();
                resStream.Close();
                response.Close();

                int startIndex, endIndex;
                bool isNotDown;
                startIndex = htmlData.IndexOf("<title>") + 7;
                endIndex = htmlData.IndexOf("</title>");
                string name = htmlData.Substring(startIndex, endIndex - startIndex).Trim(new char[] { '\r', '\n', '\t' });
                stock.name = name.Split('-')[0].Trim();
                int stockDataIndex = htmlData.IndexOf("現價\r");
                if (stockDataIndex == -1)
                    return;
                startIndex = htmlData.IndexOf("<span", stockDataIndex);
                if (htmlData.Substring(startIndex + 13, 8) == "pos bold" || htmlData.Substring(startIndex + 13, 8) == "unc bold")
                    isNotDown = true;
                else if (htmlData.Substring(startIndex + 13, 8) == "neg bold")
                    isNotDown = false;
                else
                    return;
                startIndex += 23;
                endIndex = htmlData.IndexOf("</span>", startIndex) - 1;
                stock.close = float.Parse(htmlData.Substring(startIndex, endIndex - startIndex + 1));
                startIndex = htmlData.IndexOf("<span", endIndex) + 23;
                endIndex = htmlData.IndexOf("</span>", startIndex) - 1;
                float.TryParse(htmlData.Substring(startIndex, endIndex - startIndex + 1), out stock.change);
                startIndex = htmlData.IndexOf("<span", endIndex) + 23;
                endIndex = htmlData.IndexOf("</span>", startIndex) - 2;
                float.TryParse(htmlData.Substring(startIndex, endIndex - startIndex + 1), out stock.ROC);
                if (!isNotDown)
                {
                    stock.change = -stock.change;
                    stock.ROC = -stock.ROC;
                }
                startIndex = htmlData.IndexOf("今日波幅", endIndex) + 154;
                endIndex = htmlData.IndexOf("</div>", startIndex) - 1;
                string[] highlow = htmlData.Substring(startIndex, endIndex - startIndex + 1).Split('-');
                if (highlow.Length == 2)
                {
                    stock.low = float.Parse(highlow[0]);
                    stock.high = float.Parse(highlow[1]);
                }
                else
                {
                    stock.low = float.NaN;
                    stock.high = float.NaN;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GetQuoteFromM18(StockData stock)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://money18.on.cc/js/daily/quote/" + stock.code.Substring(0, stock.code.Length - 3) + "_d.js?t=1294639633954");
                request.Referer = "http://money18.on.cc/info/liveinfo_quote.html";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream resStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(resStream, System.Text.Encoding.GetEncoding("big5"));
                string htmlData = sr.ReadToEnd();
                resStream.Close();
                response.Close();
                int startIndex = htmlData.IndexOf("nameChi:", 15) + 8;
                int endIndex = htmlData.IndexOf(',', startIndex) - 1;
                stock.name = htmlData.Substring(startIndex, endIndex - startIndex).Trim(new char[] { ' ', '"' });
                startIndex = htmlData.IndexOf("preCPrice:", 15) + 10;
                endIndex = htmlData.IndexOf(',', startIndex) - 1;
                float prevClose = float.NaN;
                float.TryParse(htmlData.Substring(startIndex, endIndex - startIndex).Trim(new char[] { ' ', '"' }), out prevClose);
                ExtentedStockData eStock = stock as ExtentedStockData;
                if (eStock != null)
                {
                    startIndex = htmlData.IndexOf("mthHigh:", 15) + 8;
                    endIndex = htmlData.IndexOf(',', startIndex) - 1;
                    float.TryParse(htmlData.Substring(startIndex, endIndex - startIndex).Trim(new char[] { ' ', '"' }), out eStock.mthHigh);
                    startIndex = htmlData.IndexOf("mthLow:", 15) + 7;
                    endIndex = htmlData.IndexOf(',', startIndex) - 1;
                    float.TryParse(htmlData.Substring(startIndex, endIndex - startIndex).Trim(new char[] { ' ', '"' }), out eStock.mthLow);
                    startIndex = htmlData.IndexOf("wk52High:", 15) + 9;
                    endIndex = htmlData.IndexOf(',', startIndex) - 1;
                    float.TryParse(htmlData.Substring(startIndex, endIndex - startIndex).Trim(new char[] { ' ', '"' }), out eStock.wk52High);
                    startIndex = htmlData.IndexOf("wk52Low:", 15) + 8;
                    endIndex = htmlData.IndexOf(',', startIndex) - 1;
                    float.TryParse(htmlData.Substring(startIndex, endIndex - startIndex).Trim(new char[] { ' ', '"' }), out eStock.wk52Low);
                    startIndex = htmlData.IndexOf("ma10:", 15) + 5;
                    endIndex = htmlData.IndexOf(',', startIndex) - 1;
                    float.TryParse(htmlData.Substring(startIndex, endIndex - startIndex).Trim(new char[] { ' ', '"' }), out eStock.ma10);
                    startIndex = htmlData.IndexOf("ma20:", 15) + 5;
                    endIndex = htmlData.IndexOf(',', startIndex) - 1;
                    float.TryParse(htmlData.Substring(startIndex, endIndex - startIndex).Trim(new char[] { ' ', '"' }), out eStock.ma20);
                    startIndex = htmlData.IndexOf("ma50:", 15) + 5;
                    endIndex = htmlData.IndexOf(',', startIndex) - 1;
                    float.TryParse(htmlData.Substring(startIndex, endIndex - startIndex).Trim(new char[] { ' ', '"' }), out eStock.ma50);
                    startIndex = htmlData.IndexOf("rsi10:", 15) + 6;
                    endIndex = htmlData.IndexOf(',', startIndex) - 1;
                    float.TryParse(htmlData.Substring(startIndex, endIndex - startIndex).Trim(new char[] { ' ', '"' }), out eStock.rsi10);
                    startIndex = htmlData.IndexOf("rsi14:", 15) + 6;
                    endIndex = htmlData.IndexOf(',', startIndex) - 1;
                    float.TryParse(htmlData.Substring(startIndex, endIndex - startIndex).Trim(new char[] { ' ', '"' }), out eStock.rsi14);
                    startIndex = htmlData.IndexOf("rsi20:", 15) + 6;
                    endIndex = htmlData.IndexOf(',', startIndex) - 1;
                    float.TryParse(htmlData.Substring(startIndex, endIndex - startIndex).Trim(new char[] { ' ', '"' }), out eStock.rsi20);
                }

                request = (HttpWebRequest)WebRequest.Create("http://money18.on.cc/js/real/quote/" + stock.code.Substring(0, stock.code.Length - 3) + "_r.js?t=1294639633954");
                request.Referer = "http://money18.on.cc/info/liveinfo_quote.html";
                response = (HttpWebResponse)request.GetResponse();
                resStream = response.GetResponseStream();
                sr = new StreamReader(resStream);
                htmlData = sr.ReadToEnd();
                resStream.Close();
                response.Close();
                startIndex = htmlData.IndexOf("np:", 15) + 3;
                endIndex = htmlData.IndexOf(',', startIndex) - 1;
                float.TryParse(htmlData.Substring(startIndex, endIndex - startIndex).Trim(new char[] { ' ', '\'' }), out stock.close);
                if (!float.IsNaN(prevClose))
                {
                    stock.change = stock.close - prevClose;
                    stock.ROC = stock.change / prevClose * 100;
                }
                startIndex = htmlData.IndexOf("dyh:", 15) + 4;
                endIndex = htmlData.IndexOf(',', startIndex) - 1;
                float.TryParse(htmlData.Substring(startIndex, endIndex - startIndex).Trim(new char[] { ' ', '\'' }), out stock.high);
                startIndex = htmlData.IndexOf("dyl:", 15) + 4;
                endIndex = htmlData.IndexOf('\n', startIndex) - 1;
                float.TryParse(htmlData.Substring(startIndex, endIndex - startIndex).Trim(new char[] { ' ', '\'' }), out stock.low);
                startIndex = htmlData.IndexOf("vol:", 15) + 4;
                endIndex = htmlData.IndexOf(',', startIndex) - 1;
                uint.TryParse(htmlData.Substring(startIndex, endIndex - startIndex).Trim(new char[] { ' ', '\'' }), out stock.volume);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
