using QuanLySanBongMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWidth = 120;
        public static int TableHeight = 100;

        private TableDAO() { }

        public List<Table> LoadTableList(int id)
        {
            List<Table> tableList = new List<Table>();
            string query = "SELECT * FROM dbo.Time WHERE idField = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuerry(query);
            foreach (DataRow row in data.Rows)
            {
                Table table = new Table(row);
                tableList.Add(table);
            }
            return tableList;
        }
        public List<Table> GetTableList()
        {
            List<Table> tableList = new List<Table>();
            string query = "SELECT * FROM dbo.Time";
            DataTable data = DataProvider.Instance.ExcuteQuerry(query);
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }   
        public Table GetTable()
        {
            DataTable data = DataProvider.Instance.ExcuteQuerry("SELECT * FROM dbo.Time");

            foreach (DataRow item in data.Rows)
            {
                return new Table(item);
            }
            return null;
        }
        public void UpdateStatusDatSan(int id)
        {
            string query = "UPDATE dbo.Time SET TimeStatus = N'Da Dat San' WHERE id = '" + id + "'";
            DataProvider.Instance.ExcuteNonQuerry(query);
        }
        public void UpdateStatusTrong(int id)
        {
            string query = "UPDATE dbo.Time SET TimeStatus = N'Trong' WHERE id = '" + id + "'";
            DataProvider.Instance.ExcuteNonQuerry(query);
        }
        public void UpdateStatusDaThanhToan(int id)
        {
            string query = "UPDATE dbo.Time SET TimeStatus = N'Da Thanh Toan' WHERE id = '" + id + "'";
            DataProvider.Instance.ExcuteNonQuerry(query);
        }
        
        public void DeleteTimeByFieldId(int id)
        {
            DataProvider.Instance.ExcuteNonQuerry("DELETE FROM Time WHERE idField = '" + id + "'");
        }
        public bool InsertTime(string timeName, int idField, string timeStatus)
        {
            string query = string.Format("INSERT dbo.Time ( TimeName, idField, TimeStatus)VALUES (N'{0}', {1}, N'{2}')", timeName, idField, timeStatus);
            int Result = DataProvider.Instance.ExcuteNonQuerry(query);
            return Result > 0;
        }
        public bool UpdateTime(string timeName, int idField, string timeStatus, int idTime)
        {
            string query = string.Format("Update dbo.Time SET TimeName = N'{0}', idField = {1}, TimeStatus = N'{2}' WHERE id = {3}", timeName, idField, timeStatus, idTime);
            int Result = DataProvider.Instance.ExcuteNonQuerry(query);
            return Result > 0;
        }
        public bool DeleteTime(int id)
        {
            BillDAO.Instance.DeleteBillByIdTime(id);
            FieldRegisterDAO.Instance.DeleteFieldRegisterByTimeId(id);
            string query = string.Format("DELETE Time WHERE id = {0}", id);
            int result = DataProvider.Instance.ExcuteNonQuerry(query);
            return result > 0;
        }
    }
}
