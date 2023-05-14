using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace DAL
{
    public class DAL_ExportReceiptDetails
    {
        DTO_ExportReceiptDetails receiptDetails;
        public DAL_ExportReceiptDetails(int resellerID, int receiptID, int phoneID, int quantity, int price)
        {
            receiptDetails = new DTO_ExportReceiptDetails(resellerID, receiptID, phoneID, quantity, price);
        }

        public DAL_ExportReceiptDetails(int receiptID)
        {
            receiptDetails = new DTO_ExportReceiptDetails(receiptID);
        }
        public void addQuery()
        {
            string querry = "insert into ExportReceiptDetails values (" + receiptDetails._ResellerID + "," + receiptDetails._PhoneID + "," + receiptDetails._ReceiptID + "," + receiptDetails._Quantity + "," + receiptDetails._Price + ")";
            Debug.WriteLine(querry);
            Connection.actionQuery(querry);
        }

        public DataTable selectExportReceiptDetails()
        {
            string str = "select * from ExportReceiptDetails where ExportReceiptId = " + receiptDetails._ReceiptID;
            return Connection.selectQuery(str);
        }
    }
}
