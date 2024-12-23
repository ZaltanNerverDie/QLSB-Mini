using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DTO
{
    public class Field
    {
        public Field(int id, string Fieldname, string FieldType, int FieldStatus, float FieldPrice = 0)
        {
            this.Id = id;
            this.FieldName = fieldName;
            this.FieldType = fieldType;
            this.FieldStatus = fieldStatus;
            this.FieldPrice = fieldPrice;
        }

        public Field(DataRow row)
        {
            this.Id = (int)row["id"];
            this.FieldName = row["FieldName"].ToString();
            this.FieldType = row["FieldType"].ToString();
            this.FieldStatus = (int)row["FieldStatus"];
            this.FieldPrice = (float)Convert.ToDouble(row["FieldPrice"].ToString());
        }
        private string status;

        private float fieldPrice;

        public float FieldPrice
        {
            get { return fieldPrice; }
            set { fieldPrice = value; }
        }

        private int fieldStatus;

        public int FieldStatus
        {
            get { return fieldStatus; }
            set { fieldStatus = value; }
        }
        private string fieldType;

        public string FieldType
        {
            get { return fieldType; }
            set { fieldType = value; }
        }
        private string fieldName;

        public string FieldName
        {
            get { return fieldName; }
            set { fieldName = value; }
        }

        private int id;

        public int Id
        {
             get { return id; }
             set { id = value; } 
        }
    }
}

