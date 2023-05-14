using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ResellerImportReceiptDetails
    {
        private int ResellerReceiptDetailsID;

        public int _ResellerReceiptDetailsID
        {
            get
            {
                return ResellerReceiptDetailsID;
            }
            set
            {
                ResellerReceiptDetailsID = value;
            }
        }



        public DTO_ResellerImportReceiptDetails(int ResellerReceiptDetailsID)
        {
            this.ResellerReceiptDetailsID = ResellerReceiptDetailsID;
        }
    }
}
