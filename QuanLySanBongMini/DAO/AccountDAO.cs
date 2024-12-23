using QuanLySanBongMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
    
        public static AccountDAO Instance 
        {
        get { if (instance == null) instance = new AccountDAO(); return instance; }
        private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";
            DataTable Result = DataProvider.Instance.ExcuteQuerry(query, new object[] {userName, passWord});

            return Result.Rows.Count > 0;
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExcuteQuerry("SELECT * FROM dbo.Account WHERE UserName = '" +  userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public int GetIdAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExcuteQuerry("SELECT * FROM dbo.Account WHERE UserName = " + userName);

            if(data.Rows.Count > 0)
            {
                Account AI = new Account(data.Rows[0]);
                return AI.IdAccount;
            }
            return -1;
        }

        public List<Account> GetAccountList()
        {
            List<Account> accountList = new List<Account>();
            string query = "SELECT * FROM dbo.Account";
            DataTable data = DataProvider.Instance.ExcuteQuerry(query);
            foreach (DataRow item in data.Rows)
            {
                Account table = new Account(item);
                accountList.Add(table);
            }
            return accountList;
        }

        public bool InsertAccount(string userName, int accountType, string displayName)
        {
            string query = string.Format("INSERT dbo.Account ( UserName, Type, DisplayName)VALUES (N'{0}', {1}, N'{2}')", userName, accountType, displayName);
            int Result = DataProvider.Instance.ExcuteNonQuerry(query);
            return Result > 0;
        }
        public bool UpdateAccount(string userName, int accountType, string displayName, int accountId)
        {
            string query = string.Format("Update dbo.Account SET UserName = N'{0}', Type = {1}, DisplayName = N'{2}' WHERE id = {3}", userName, accountType, displayName, accountId);
            int Result = DataProvider.Instance.ExcuteNonQuerry(query);
            return Result > 0;
        }
        public bool DeleteAccount(int id)
        {
            BillDAO.Instance.DeleteBillByIdAccount(id);
            FieldRegisterDAO.Instance.DeleteFRByIdAccount(id);
            string query = string.Format("DELETE Account WHERE id = {0}", id);
            int result = DataProvider.Instance.ExcuteNonQuerry(query);
            return result > 0;
        }
    }
}
    