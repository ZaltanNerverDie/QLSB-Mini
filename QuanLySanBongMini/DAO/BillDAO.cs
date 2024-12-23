using QuanLySanBongMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }

        public Bill GetBill(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuerry("SELECT * FROM dbo.Bill WHERE idFieldRegister = " + id + "");

            foreach (DataRow item in data.Rows)
            {
                return new Bill(item);
            }
            return null;
        }
        public void InsertBill(int idFieldRegister)
        {
            DataProvider.Instance.ExcuteNonQuerry("USP_InsertBill @idFieldRegister ", new object[] {idFieldRegister});
        }
        
        public void DeleteBill(int id)
        {
            DataProvider.Instance.ExcuteNonQuerry("DELETE FROM dbo.Bill WHERE idFieldRegister = '" + id + "'");
        }


        public void Checkout(int idStaff, int idFieldRegister)
        {
            try
            {
                string query = "UPDATE dbo.Bill SET BillStatus = 1, idAccount = " + idStaff + " WHERE idFieldRegister = " + idFieldRegister;
                DataProvider.Instance.ExcuteNonQuerry(query);
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it or throw a custom exception)
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public DataTable GetBillListByDate (DateTime checkIn, DateTime checkOut)
        {
           return DataProvider.Instance.ExcuteQuerry("EXEC USP_GetListBillByDate @checkIn , @checkOut", new object[] {checkIn, checkOut});
        }

        public void DeleteBillByIdField(int id)
        {
            DataProvider.Instance.ExcuteNonQuerry("DELETE FROM Bill WHERE idFieldRegister IN (SELECT id FROM FieldRegister WHERE idTime IN (SELECT id FROM Time WHERE idField = '" + id + "' ))");
        }
        public void DeleteBillByIdTime(int id)
        {
            DataProvider.Instance.ExcuteNonQuerry("DELETE FROM Bill WHERE idFieldRegister IN (SELECT id FROM FieldRegister WHERE idTime = '" + id + "' )");
        }
        public void DeleteBillByIdAccount(int id)
        {
            DataProvider.Instance.ExcuteNonQuerry("DELETE FROM Bill WHERE idAccount = '" + id + "'");
        }

    }
}
