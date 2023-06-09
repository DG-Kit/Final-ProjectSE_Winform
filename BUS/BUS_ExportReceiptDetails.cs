﻿using System;
using DAL;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ExportReceiptDetails
    {
        DAL_ExportReceiptDetails receiptDetails;
        public BUS_ExportReceiptDetails(int receiptID)
        {
            receiptDetails = new DAL_ExportReceiptDetails(receiptID);
        }
        public BUS_ExportReceiptDetails(int resellerID, int receiptID, int phoneID, int quantity, int price)
        {
            receiptDetails = new DAL_ExportReceiptDetails(resellerID, receiptID, phoneID, quantity, price);
        }


        public void addQuery()
        {
            receiptDetails.addQuery();
        }

        public DataTable selectExportReceiptDetails()
        {
            return receiptDetails.selectExportReceiptDetails();
        }
    }
}
