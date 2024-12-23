using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DTO
{
    public class Table
    {
        public Table(int id, string name, int idField, string status)
        {
            this.Id = id;
            this.IdField = idField;
            this.Name = name;
            this.Status = status;
        }

        public Table(DataRow row)
        {
            this.Id = (int)row["id"];
            this.IdField = (int)row["idField"];
            this.Name = row["TimeName"].ToString();
            this.Status = row["TimeStatus"].ToString();  
        }
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int idField;

        public int IdField
        {
            get { return idField; }
            set { idField = value; }
        }
        private int id;

        public int Id 
        { 
            get { return id; } 
            set { id = value; }
        }
    }
}
