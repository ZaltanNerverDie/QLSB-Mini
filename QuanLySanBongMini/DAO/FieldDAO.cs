using QuanLySanBongMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DAO
{
    public class FieldDAO
    {
        private static FieldDAO instance;

        public static FieldDAO Instance
        {
            get { if (instance == null) instance = new FieldDAO(); return instance; }
            private set { FieldDAO.instance = value; }
        }

        private FieldDAO() { }

        public List<Field> LoadFieldList()
        {
            List<Field> fieldList = new List<Field>();
            string query = "SELECT * FROM Field";
            DataTable data = DataProvider.Instance.ExcuteQuerry(query);
            foreach (DataRow item in data.Rows)
            {
                Field field = new Field(item);
                fieldList.Add(field);
            }
            return fieldList;
        }
        public Field GetField()
        {
            DataTable data = DataProvider.Instance.ExcuteQuerry("SELECT * FROM dbo.Field WHERE idFieldRegister =");

            foreach (DataRow item in data.Rows)
            {
                return new Field(item);
            }
            return null;
        }
        public bool InsertField(string fieldName, float price, int fieldStatus, string fieldType)
        {
            string query = string.Format("INSERT dbo.Field ( FieldName, FieldPrice, FieldStatus, FieldType)VALUES (N'{0}', {1}, {2}, N'{3}')", fieldName, price, fieldStatus, fieldType);
            int Result = DataProvider.Instance.ExcuteNonQuerry(query);
            return Result > 0;
        }
        public bool UpdateField(string fieldName, float price, int fieldStatus, string fieldType, int fieldId)
        {
            string query = string.Format("Update dbo.Field SET FieldName = N'{0}', FieldPrice = {1}, FieldStatus = {2}, FieldType = N'{3}' WHERE id = {4}", fieldName, price, fieldStatus, fieldType, fieldId);
            int Result = DataProvider.Instance.ExcuteNonQuerry(query);
            return Result > 0;
        }
        public bool DeleteField(int id)
        {
            BillDAO.Instance.DeleteBillByIdField(id);
            FieldRegisterDAO.Instance.DeleteFieldRegisterByFieldId(id);
            TableDAO.Instance.DeleteTimeByFieldId(id);
            string query = string.Format("DELETE Field WHERE id = {0}", id);
            int result = DataProvider.Instance.ExcuteNonQuerry(query);
            return result > 0;
        }

    }
}
