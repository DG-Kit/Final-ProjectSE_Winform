using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_WarehouseProducts
    {
        DTO_WarehouseProducts warehouseProducts;
        public DAL_WarehouseProducts(int warehouseID, int phoneID, int quantity)
        {
            warehouseProducts = new DTO_WarehouseProducts(warehouseID, phoneID, quantity);
        }

        public void addQuery()
        {
            string query = "insert into WarehouseProducts values (" + warehouseProducts._WarehouseID + "," + warehouseProducts._PhoneID + "," + warehouseProducts._Quantity + ")";
            Debug.WriteLine(query);
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "update WarehouseProducts set Quantity = " + warehouseProducts._Quantity + " where WarehouseId = " + warehouseProducts._WarehouseID + " and PhoneId = " + warehouseProducts._PhoneID;
            Debug.WriteLine(query);
            Connection.actionQuery(query);
        }

        public DataTable selectQuantity()
        {
            string query = "select Quantity from WarehouseProducts where WarehouseId = " + warehouseProducts._WarehouseID + " and PhoneId = " + warehouseProducts._PhoneID;
            Debug.WriteLine(query);
            return Connection.selectQuery(query);
        }

        public void updateQuantity()
        {
            string query = "update WarehouseProducts set Quantity = Quantity - " + warehouseProducts._Quantity + " where WarehouseId = " + warehouseProducts._WarehouseID + " and PhoneId = " + warehouseProducts._PhoneID;
            Debug.WriteLine(query);
            Connection.actionQuery(query);
        }
    }
}
