using System;
using DTO;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ExportReceipt
    {
        DTO_ExportReceipt receipt;

        public DAL_ExportReceipt(int receiptID, int totalPrice, string dateCreated, int accountantID)
        {
            receipt = new DTO_ExportReceipt(receiptID, totalPrice, dateCreated, accountantID);
        }

        public DAL_ExportReceipt(int accountantID)
        {
            receipt = new DTO_ExportReceipt(accountantID);
        }
        public void addQuery()
        {
            DateTime now = DateTime.Now;
            string dateTime = now.ToString("yyyy-MM-ddTHH:mm:ss.fffffff");
            string dateTime2 = "CAST(N'" + dateTime + "' AS DateTime2)";
            string querry = "insert into ExportReceipt values (" + receipt._TotalPrice + "," + dateTime2 + "," + receipt._AccountantID + ")";
            Debug.WriteLine(querry);
            Connection.actionQuery(querry);
        }

        public DataTable getReceiptIDDesc()
        {
            string str = "select top 1 ExportReceiptId from ExportReceipt order by ExportReceiptId desc";
            return Connection.selectQuery(str);
        }

        public DataTable getReceipt()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID;
            Debug.WriteLine(str);
            return Connection.selectQuery(str);
        }

        public DataTable sortDateAsc()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " ORDER BY DateCreated ASC";
            return Connection.selectQuery(str);
        }

        public DataTable sortDateDesc()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " ORDER BY DateCreated DESC";
            return Connection.selectQuery(str);
        }

        public DataTable sortPriceAsc()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " ORDER BY TotalPrice ASC";
            return Connection.selectQuery(str);
        }
        public DataTable sortPriceDesc()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " ORDER BY TotalPrice DESC";
            return Connection.selectQuery(str);
        }

        public DataTable sortDateAscLessThan10()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " and TotalPrice < 10000000 ORDER BY DateCreated ASC";
            return Connection.selectQuery(str);
        }

        public DataTable sortDateDescLessThan10()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " and TotalPrice < 10000000 ORDER BY DateCreated DESC";
            return Connection.selectQuery(str);
        }

        public DataTable sortPriceAscLessThan10()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " and TotalPrice < 10000000 ORDER BY TotalPrice ASC";
            return Connection.selectQuery(str);
        }
        public DataTable sortPriceDescLessThan10()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " and TotalPrice < 10000000 ORDER BY TotalPrice DESC";
            return Connection.selectQuery(str);
        }

        public DataTable sortDateAscLessThan100()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " and TotalPrice < 100000000 ORDER BY DateCreated ASC";
            return Connection.selectQuery(str);
        }

        public DataTable sortDateDescLessThan100()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " and TotalPrice < 100000000 ORDER BY DateCreated DESC";
            return Connection.selectQuery(str);
        }

        public DataTable sortPriceAscLessThan100()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " and TotalPrice < 100000000 ORDER BY TotalPrice ASC";
            return Connection.selectQuery(str);
        }
        public DataTable sortPriceDescLessThan100()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " and TotalPrice < 100000000 ORDER BY TotalPrice DESC";
            return Connection.selectQuery(str); 
        }

        public DataTable sortDateAscGreaterThan100()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " and TotalPrice > 100000000 ORDER BY DateCreated ASC";
            return Connection.selectQuery(str);
        }

        public DataTable sortDateDescGreaterThan100()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " and TotalPrice > 100000000 ORDER BY DateCreated DESC";
            return Connection.selectQuery(str);
        }

        public DataTable sortPriceAscGreaterThan100()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " and TotalPrice > 100000000 ORDER BY TotalPrice ASC";
            return Connection.selectQuery(str);
        }
        public DataTable sortPriceDescGreaterThan100()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " and TotalPrice > 100000000 ORDER BY TotalPrice DESC";
            return Connection.selectQuery(str);
        }

        public DataTable sortLessThan10()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " and TotalPrice < 10000000";
            return Connection.selectQuery(str);
        }

        public DataTable sortLessThan100()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " and TotalPrice < 100000000";
            return Connection.selectQuery(str);
        }

        public DataTable sortGreaterThan100()
        {
            string str = "select * from ExportReceipt where AccountantId = " + receipt._AccountantID + " and TotalPrice > 100000000";
            return Connection.selectQuery(str);
        }
    }
}
