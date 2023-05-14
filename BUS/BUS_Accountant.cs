using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Accountant
    {
        DAL_Accountant acc;

        public BUS_Accountant(int accID, string accName, string accEmail, string accPassword, int wareID)
        {
            acc = new DAL_Accountant(accID, accName, accEmail, accPassword, wareID);
        }

        public DataTable selectEmail()
        {
            return acc.selectEmail();
        }

        public DataTable selectPassword()
        {
            return acc.selectPassword();
        }

        public DataTable selectID()
        {
            return acc.selectID();
        }

        public DataTable selectName()
        {
            return acc.selectName();
        }

        public DataTable selectWarehouse()
        {
            return acc.selectWarehouse();
        }

        public DataTable selectProfit()
        {
            return acc.selectProfit();
        }
    }
}
