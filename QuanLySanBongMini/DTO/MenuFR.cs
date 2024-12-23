using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DTO
{
    public class MenuFR
    {
        public MenuFR(string fieldName, string timeName, string displayName, DateTime dateCreate, float fieldPrice = 0)
        {
            this.FieldName = fieldName;
            this.TimeName = timeName;
            this.displayName = displayName;
            this.DateCreate = dateCreate;
            this.FieldPrice = fieldPrice;
        }
        public MenuFR(DataRow row)
        {
            this.FieldName = row["fieldName"].ToString();
            this.TimeName = row["TimeName"].ToString();
            this.displayName = row["DisplayName"].ToString();
            this.DateCreate = (DateTime)row["dateCreate"];
            this.FieldPrice = (float)Convert.ToDouble(row["FieldPrice"].ToString());
        }

        private DateTime dateCreate;
        public DateTime DateCreate
        {
            get { return dateCreate; }
            set { dateCreate = value; }
        }

        private float fieldPrice;

        public float FieldPrice
        {
            get { return fieldPrice; }
            set { fieldPrice = value; }
        }

        private string displayName;

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }
        private string timeName;

        public string TimeName
        {
            get { return timeName; }
            set { timeName = value; }
        }
        private string fieldName;

        public string FieldName
        {
            get { return fieldName; }
            set { fieldName = value; }
        }
    }
}

