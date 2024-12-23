using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms;
using QuanLySanBongMini.DTO;
using System.Data;

namespace QuanLySanBongMini.DAO
{
    public class FieldRegisterDAO
    {
        private static FieldRegisterDAO instance;
        public static FieldRegisterDAO Instance
        {
            get { if (instance == null) instance = new FieldRegisterDAO(); return instance; }
            private set { FieldRegisterDAO.instance = value; }
        }
        private FieldRegisterDAO() { }

        public int GetUncheckFRbyTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuerry("SELECT *FROM dbo.FieldRegister WHERE idTime = " + id + " AND FieldRegisterStatus = 0");
            
            if (data.Rows.Count > 0)
            {
                FieldRegister FR = new FieldRegister(data.Rows[0]);
                return FR.Id;
            }
            return -1;
        }

        public List<FieldRegister> GetFieldRegisterByTableID(int id)
        {
            List<FieldRegister> listFieldRegister = new List<FieldRegister>();

            DataTable data = DataProvider.Instance.ExcuteQuerry("SELECT *FROM dbo.FieldRegister WHERE idTime = " + id + " AND FieldRegisterStatus = 0");
            foreach (DataRow item in data.Rows)
            {
                FieldRegister info = new FieldRegister(item);
                listFieldRegister.Add(info);
            }

            return listFieldRegister;
        }

        public void InsertFieldRegister(int idAccount, int idTime)
        {
            DataProvider.Instance.ExcuteNonQuerry("USP_InsertFieldResigter @idAccount , @idTime ", new object[] { idAccount, idTime });
        }
        public FieldRegister GetFieldRegister(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuerry("SELECT * FROM dbo.FieldRegister WHERE idTime = " + id + "AND FieldRegisterStatus = 0");

            foreach (DataRow item in data.Rows)
            {
                return new FieldRegister(item);
            }
            return null;
        }
        public void CheckoutFR(int id)
        {
            string query = "UPDATE dbo.FieldRegister SET FieldRegisterStatus = 1 WHERE id = " + id;
            DataProvider.Instance.ExcuteNonQuerry(query);
        }
        public void DeleteFieldRegister(int id)
        {
            DataProvider.Instance.ExcuteNonQuerry("DELETE FROM dbo.FieldRegister WHERE id = '" + id + "'");
        }
        public void UpdateForNewDay()
        {
            string query = "UPDATE dbo.FieldRegister SET FieldRegisterStatus = 1";
            DataProvider.Instance.ExcuteNonQuerry(query);
        }

        public void DeleteFieldRegisterByFieldId(int id)
        {
            DataProvider.Instance.ExcuteNonQuerry("DELETE FROM FieldRegister WHERE idTime IN (SELECT id FROM Time WHERE idField =  '" + id + "' )");
        }
        public void DeleteFieldRegisterByTimeId(int id)
        {
            DataProvider.Instance.ExcuteNonQuerry("DELETE FROM FieldRegister WHERE idTime =  '" + id + "'");
        }
        public void DeleteFRByIdAccount(int id)
        {
            DataProvider.Instance.ExcuteNonQuerry("DELETE FROM FieldRegister WHERE idAccount = '" + id + "'");
        }
    }
}
