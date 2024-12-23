using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DTO
{
    public class FieldRegister
    {
        public FieldRegister(int id, int idAccount, int idTime, DateTime dateCreate, int fieldRegisterStatus)
        {
            this.Id = id;
            this.IdAccount = idAccount;
            this.IdTime = idTime;
            this.DateCreate = dateCreate;
            this.fieldRegisterStatus = fieldRegisterStatus;
        }
       

        public FieldRegister(DataRow row)
        {
            this.Id = (int)row["id"];
            this.IdAccount = (int)row["idAccount"];
            this.IdTime = (int)row["idTime"];
            this.DateCreate = (DateTime)row["dateCreate"];
            this.FieldRegisterStatus = (int)row["FieldRegisterStatus"];
        }

        private int fieldRegisterStatus;

        public int FieldRegisterStatus
        {
            get { return fieldRegisterStatus; }
            set { fieldRegisterStatus = value; }
        }

        private DateTime dateCreate;
        public DateTime DateCreate
        {
            get { return dateCreate; }
            set { dateCreate = value; }
        }
        private int idTime;

        public int IdTime
        {
            get { return idTime; }
            set { idTime = value; }
        }
        private int idAccount;

        public int IdAccount
        {
            get { return idAccount; }
            set { idAccount = value; }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
