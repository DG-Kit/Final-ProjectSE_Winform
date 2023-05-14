using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Accountant
    {
        private int AccountantID, WarehouseID;
        private string AccountantName, AccountantEmail, AccountantPassword;

        public int _AccountantID
        {
            get { return AccountantID; }
            set { AccountantID = value; }
        }
        public int _WarehouseID
        {
            get { return WarehouseID; }
            set { WarehouseID = value; }
        }
        public string _AccountantName
        {
            get { return AccountantName; }
            set { AccountantName = value; }
        }
        public string _AccountantEmail
        {
            get { return AccountantEmail; }
            set { AccountantEmail = value; }
        }
        public string _AccountantPassword
        {
            get { return AccountantPassword; }
            set { AccountantPassword = value; }
        }
        public DTO_Accountant(int AccountantID, string AccountantName, string AccountantEmail, string AccountantPassword, int WarehouseID)
        {
            this.AccountantID = AccountantID;
            this.AccountantName = AccountantName;
            this.AccountantEmail = AccountantEmail;
            this.AccountantPassword = AccountantPassword;
            this.WarehouseID = WarehouseID;
        }
    }
}
