using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DTO
{
    public class Bill
    {
        public Bill(int id, int idFieldRegister, int BillStatus, DateTime BillDate, int? idAccount = null)
        {
            this.Id = id;
            this.IdFieldRegister = idFieldRegister;
            this.BillStatus = BillStatus;
            this.BillDate = BillDate;
            this.idAccount = idAccount;
        }

        public Bill(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.IdFieldRegister = (int)row["idFieldRegister"];
            this.BillStatus = (int)row["BillStatus"];
            this.BillDate = (DateTime)row["BillDate"];
            this.idAccount = (int)row["idAccount"];
        }
        private string status;

        private DateTime billDate;

        public DateTime BillDate
        {
            get { return billDate; }
            set { billDate = value; }
        }

        private int billStatus;

        public int BillStatus
        {
            get { return billStatus; }
            set { billStatus = value; }
        }
        private int? idAccount;

        public int? IdAccount
        {
            get { return idAccount; }
            set { idAccount = value; }
        }
        private int idFieldRegister;

        public int IdFieldRegister
        {
            get { return idFieldRegister; }
            set { idFieldRegister = value; }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
