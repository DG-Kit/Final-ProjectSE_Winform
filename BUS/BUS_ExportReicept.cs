using System;
using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ExportReceipt
    {
        DAL_ExportReceipt receipt;
        public BUS_ExportReceipt(int accountantID)
        {
            receipt = new DAL_ExportReceipt(accountantID);
        }

        public BUS_ExportReceipt(int receiptID, int totalPrice, string dateCreated, int accountantID)
        {
            receipt = new DAL_ExportReceipt(receiptID, totalPrice, dateCreated, accountantID);
        }

        public void addQuery()
        {
            receipt.addQuery();
        }

        public int getReceiptID()
        {
            DataTable table = receipt.getReceiptIDDesc();
            if (table.Rows.Count > 0)
            {
                int id = (int)(table.Rows[0][0]) + 1;
                return id;
            }
            return 1;

        }

        public DataTable getReceipt()
        {
            return receipt.getReceipt();
        }
    }
}
