using QuanLySanBongMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DAO
{
    public class MenuFRDAO
    {
        private static MenuFRDAO instance;
        public static MenuFRDAO Instance
        {
            get { if (instance == null) instance = new MenuFRDAO(); return instance; }
            private set { MenuFRDAO.instance = value; }
        }

        

        private MenuFRDAO() { }

        public List<MenuFR> GetListMenuByTable(int id)
        {
            List<MenuFR> listmenu = new List<MenuFR>();
            string query = "SELECT fn.FieldName, ft.TimeName, fa.DisplayName, fd.dateCreate, fn.FieldPrice FROM dbo.FieldRegister AS fd, dbo.Account AS fa, dbo.Field AS fn, dbo.Time AS ft\r\nWHERE fd.FieldRegisterStatus = 0 AND fd.idAccount = fa.id AND fd.idTime = ft.id AND ft.idField = fn.id AND fd.idTime = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuerry(query);
            foreach (DataRow item in data.Rows)
            {
                MenuFR menuFR = new MenuFR(item);
                listmenu.Add(menuFR);
            }
            return listmenu;
        }
    }
}
