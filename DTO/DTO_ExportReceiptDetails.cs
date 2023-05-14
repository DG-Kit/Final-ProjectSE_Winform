using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ExportReceiptDetails
    {
        private int ReceiptID, PhoneID, Quantity, Price, ResellerID;
        public int _ReceiptID
        {
            get
            {
                return ReceiptID;
            }
            set
            {
                ReceiptID = value;
            }
        }

        public int _PhoneID
        {
            get
            {
                return PhoneID;
            }
            set
            {
                PhoneID = value;
            }
        }

        public int _Quantity
        {
            get
            {
                return Quantity;
            }
            set
            {
                Quantity = value;
            }
        }

        public int _Price
        {
            get
            {
                return Price;
            }
            set
            {
                Price = value;
            }
        }

        public int _ResellerID
        {
            get
            {
                return ResellerID;
            }
            set
            {
                ResellerID = value;
            }
        }


        public DTO_ExportReceiptDetails(int ResellerID, int ReceiptID, int PhoneID, int Quantity, int Price)
        {
            this.ResellerID = ResellerID;
            this.ReceiptID = ReceiptID;
            this.PhoneID = PhoneID;
            this.Quantity = Quantity;
            this.Price = Price;
        }

        public DTO_ExportReceiptDetails(int receiptID)
        {
            this.ReceiptID = receiptID;
        }
    }
}
