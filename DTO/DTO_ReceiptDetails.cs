using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ReceiptDetails
    {
        private int ReceiptID, PhoneID, Quantity, Price;

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


        public DTO_ReceiptDetails(int ReceiptID, int PhoneID, int Quantity, int Price)
        {
            this.ReceiptID = ReceiptID;
            this.PhoneID = PhoneID;
            this.Quantity = Quantity;
            this.Price = Price;
        }

        public DTO_ReceiptDetails(int ReceiptID)
        {
            this.ReceiptID = ReceiptID;
        }
    }
}
