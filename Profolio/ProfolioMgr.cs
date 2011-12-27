using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Him.Collections.Generic;

namespace Profolio
{
    public class ProfolioMgr
    {
        OleDbConnection dbConn;

        public ProfolioMgr()
        {
            string connectStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\\Profolio.mdb";
            dbConn = new OleDbConnection(connectStr);
            dbConn.Open();
        }

        public bool AddTransaction(Transaction tran)
        {
            OleDbCommand cmd = dbConn.CreateCommand();
            if (tran.GetType() == typeof(Transaction))
            {
                cmd.CommandText = "INSERT INTO Investment(code, tran_date, amount, payment, description) VALUES ('" +
                    tran.code + "','" + tran.date.ToString() + "'," + tran.amount + "," + tran.payment + ",'" +
                    tran.description + "')";
            }
            else if (tran.GetType() == typeof(FutureTransaction))
            {
                FutureTransaction ftran = (FutureTransaction)tran;
                cmd.CommandText = "INSERT INTO Future(code, contract_code, tran_date, amount, payment, description) VALUES ('" +
                    ftran.code + "','" + ftran.contractCode + "','" + ftran.date.ToString() + "'," + ftran.amount + "," +
                    ftran.payment + ",'" + ftran.description + "')";
            }
            else
                throw new NotImplementedException("Unknow transaction");
            cmd.ExecuteNonQuery();
            return true;
        }

        public LinkedList<Transaction> GetAggregatedTransaction(Type tranType, string code, DateTime from, DateTime to)
        {
            OleDbCommand cmd = dbConn.CreateCommand();
            LinkedList<Transaction> result = new LinkedList<Transaction>();
            string filterStr = _MakeFilterString(code, from, to);
            if (!string.IsNullOrEmpty(filterStr))
                filterStr = " WHERE " + filterStr;
            if (tranType == typeof(Transaction))
            {
                cmd.CommandText = "SELECT code, SUM(amount), SUM(payment) FROM Investment" + filterStr + " GROUP BY code" +
                    " ORDER BY code";
            }
            else if (tranType == typeof(FutureTransaction))
            {
                cmd.CommandText = "SELECT code, SUM(amount), SUM(payment), contract_code FROM Future" + filterStr + " GROUP BY code, contract_code" +
                    " ORDER BY code, contract_code";
            }
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Transaction curTran;
                if (tranType == typeof(Transaction))
                    curTran = new Transaction();
                else
                {
                    curTran = new FutureTransaction();
                    ((FutureTransaction)curTran).contractCode = (string)reader["contract_code"];
                }
                curTran.code = (string)reader["code"];
                curTran.date = to;
                curTran.amount = (double)reader[1];
                curTran.payment = (double)reader[2];
                curTran.description = "綜合交易";
                result.AddLast(curTran);
            }
            return result;
        }

        public void GetHistorialPrice(IDictionary<Pair<string,string>, double> asset, DateTime date)
        {
            if (asset.Count == 0) return;

            string assetFilter = "";
            foreach (Pair<string, string> key in asset.Keys)
            {
                if (!string.IsNullOrEmpty(assetFilter)) assetFilter += " OR ";
                assetFilter += "(code='" + key.First + "' AND contract_code='" + key.Second + "')";
            }
            OleDbCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT code, contract_code, price FROM historical_price AS hp " +
                              "WHERE (" + assetFilter + ") AND settle_date=(" +
                              "  SELECT MAX(settle_date) FROM historical_price AS hp2 " +
                              "  WHERE hp.code=hp2.code AND hp.contract_code=hp2.contract_code AND settle_date<=#" + date.ToString() + "#)";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                asset[new Pair<string,string>((string)reader["code"], (string)reader["contract_code"])] = double.Parse(reader["price"].ToString());
        }

        public LinkedList<Transaction> GetTransaction(Type tranType, string code, DateTime from, DateTime to)
        {
            OleDbCommand cmd = dbConn.CreateCommand();
            LinkedList<Transaction> result = new LinkedList<Transaction>();
            string filterStr = _MakeFilterString(code, from, to);
            if (!string.IsNullOrEmpty(filterStr))
                filterStr = " WHERE " + filterStr;
            if (tranType == typeof(Transaction))
            {
                cmd.CommandText = "SELECT code, tran_date, amount, payment, description FROM Investment" + filterStr + 
                    " ORDER BY tran_date";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Transaction curTran = new Transaction();
                    curTran.code = (string)reader["code"];
                    curTran.date = DateTime.Parse(reader["tran_date"].ToString());
                    curTran.amount = (double)reader["amount"];
                    curTran.payment = (double)reader["payment"];
                    curTran.description = (string)reader["description"];
                    result.AddLast(curTran);
                }
            }
            else if (tranType == typeof(FutureTransaction))
            {
                cmd.CommandText = "SELECT code, contract_code, tran_date, amount, payment, description FROM Future" + 
                    filterStr + " ORDER BY tran_date";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    FutureTransaction curTran = new FutureTransaction();
                    curTran.code = (string)reader["code"];
                    curTran.contractCode = (string)reader["contract_code"];
                    curTran.date = DateTime.Parse(reader["tran_date"].ToString());
                    curTran.amount = (double)reader["amount"];
                    curTran.payment = (double)reader["payment"];
                    curTran.description = (string)reader["description"];
                    result.AddLast(curTran);
                }
            }
            else
                throw new NotImplementedException("Unknow transaction");
            return result;
        }

        public OleDbConnection DatabaseConnection
        {
            get { return dbConn; }
        }

        private string _MakeFilterString(string code, DateTime from, DateTime to)
        {
            string filterStr = "";
            if (!string.IsNullOrEmpty(code))
                filterStr += "code='" + code + "'";
            if (from != DateTime.MinValue || to != DateTime.MaxValue)
            {
                if (!string.IsNullOrEmpty(filterStr)) filterStr += " AND ";
                filterStr += "tran_date BETWEEN #" + from.ToString() + "# AND #" + to.ToString() + "#";
            }
            return filterStr;
        }
    }
}
