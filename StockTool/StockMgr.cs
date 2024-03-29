﻿using System;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;
using System.Xml;

namespace StockTool
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
        public void GetQuote(ref StockData stock)
        {
            try
            {
                if (stock.code.Substring(stock.code.Length - 3) == ".HK")  //Is HK stock
                {
                    //Get real-time price from aastock
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.aastocks.com/tc/ltp/rtquote.aspx?symbol=" + stock.code.Substring(0, stock.code.Length - 3));
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
                else if (stock.code[0] == '^' && _indexCollection.Find(stock.code.Substring(1)) >= 0)    //is index
                {
                    stock = _indexCollection[stock.code.Substring(1)].Clone();
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
                for (int i = 0; i < stocks.Length; i++)
                {
                    MatchCollection matchResults = regexObj.Matches(allData[i]);
                    stocks[i].name = matchResults[1].Value.Trim(new char[] { '"',',' });
                    stocks[i].close = float.Parse(matchResults[2].Value.Trim(new char[] { '"',',' }));
                    string[] strChange = matchResults[3].Value.Trim(new char[] { '"',',' }).Split(new String[] { " - " }, StringSplitOptions.None);
                    if (strChange[0] != "N/A")
                    {
                        stocks[i].change = float.Parse(strChange[0].Trim('\"'));
                        stocks[i].ROC = float.Parse(strChange[1].Trim(new char[] { '\"', '%' }));
                    }
                    float.TryParse(matchResults[4].Value.Trim(new char[] { '"', ',' }), out stocks[i].low);
                    float.TryParse(matchResults[5].Value.Trim(new char[] { '"', ',' }), out stocks[i].high);
                }

                for (int i = 0; i < stocks.Length; i++)
                {
                    if (stocks[i].code.Substring(stocks[i].code.Length - 3) == ".HK")  //Is HK stock
                    {
                        //Get real-time price from aastock
                        /*request = (HttpWebRequest)WebRequest.Create("http://www.aastocks.com/chi/DataService/getlivestock.asp?stock_id=" + stocks[i].code.Substring(0, stocks[i].code.Length - 3));
                        request.CookieContainer = new CookieContainer();
                        Cookie aastockSection = new Cookie("ASPSESSIONIDACQQRRDB", "JOCDHMPAOFKEBELPPDGPLNAE");
                        aastockSection.Domain = "www.aastocks.com";
                        request.CookieContainer.Add(aastockSection);*/

                        request = (HttpWebRequest)WebRequest.Create("http://www.aastocks.com/tc/ltp/rtquote.aspx?symbol=" + stocks[i].code.Substring(0, stocks[i].code.Length - 3));
                        response = (HttpWebResponse)request.GetResponse();
                        Stream resStream = response.GetResponseStream();
                        sr = new StreamReader(resStream);
                        string htmlData = sr.ReadToEnd();
                        resStream.Close();
                        response.Close();

                        int startIndex, endIndex;
                        bool isNotDown;
                        startIndex = htmlData.IndexOf("<title>") + 7;
                        endIndex = htmlData.IndexOf("</title>");
                        string name = htmlData.Substring(startIndex, endIndex - startIndex).Trim(new char[] { '\r', '\n', '\t' });
                        stocks[i].name = name.Split('-')[0].Trim();
                        int stockDataIndex = htmlData.IndexOf("現價\r");
                        if (stockDataIndex == -1)
                            continue;
                        startIndex = htmlData.IndexOf("<span", stockDataIndex);
                        if (htmlData.Substring(startIndex + 13, 8) == "pos bold" || htmlData.Substring(startIndex + 13, 8) == "unc bold")
                            isNotDown = true;
                        else if (htmlData.Substring(startIndex + 13, 8) == "neg bold")
                            isNotDown = false;
                        else
                            continue;
                        startIndex += 23;
                        endIndex = htmlData.IndexOf("</span>", startIndex) - 1;
                        stocks[i].close = float.Parse(htmlData.Substring(startIndex, endIndex - startIndex + 1));
                        startIndex = htmlData.IndexOf("<span", endIndex) + 23;
                        endIndex = htmlData.IndexOf("</span>", startIndex) - 1;
                        float.TryParse(htmlData.Substring(startIndex, endIndex - startIndex + 1), out stocks[i].change);
                        startIndex = htmlData.IndexOf("<span", endIndex) + 23;
                        endIndex = htmlData.IndexOf("</span>", startIndex) - 2;
                        float.TryParse(htmlData.Substring(startIndex, endIndex - startIndex + 1), out stocks[i].ROC);
                        if (!isNotDown)
                        {
                            stocks[i].change = -stocks[i].change;
                            stocks[i].ROC = -stocks[i].ROC;
                        }
                        startIndex = htmlData.IndexOf("今日波幅", endIndex) + 154;
                        endIndex = htmlData.IndexOf("</div>", startIndex) - 1;
                        string[] highlow = htmlData.Substring(startIndex, endIndex - startIndex + 1).Split('-');
                        if (highlow.Length == 2)
                        {
                            stocks[i].low = float.Parse(highlow[0]);
                            stocks[i].high = float.Parse(highlow[1]);
                        }
                        else
                        {
                            stocks[i].low = float.NaN;
                            stocks[i].high = float.NaN;
                        }
                    }
                    else if (stocks[i].code[0] == '^' && _indexCollection.Find(stocks[i].code.Substring(1)) >= 0)    //is index
                    {
                        stocks[i] = _indexCollection[stocks[i].code.Substring(1)].Clone();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
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
    }
}
