using Microsoft.VisualBasic.FileIO;
using QuanLySanBongMini.DAO;
using QuanLySanBongMini.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBongMini
{
    public partial class fAdmin : Form
    {
        BindingSource fieldlist = new BindingSource();
        BindingSource timelist = new BindingSource();
        BindingSource accountlist = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();

            Load();
        }
        #region methods
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string displayName = textBoxDisplayName.Text;
            int accountId = int.Parse(txbIdAccount.Text);
            int accountType = (int)nmAccountType.Value;

            if (AccountDAO.Instance.InsertAccount(userName, accountType, displayName))
            {
                MessageBox.Show("Thêm tài khoản thành công");
                LoadAccountList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm sân");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        void Load()
        {
            dtgvField.DataSource = fieldlist;
            dtgvTime.DataSource = timelist;
            dataAccount.DataSource = accountlist;

            LoadAccountList();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListField();
            LoadListTime();
            AddTimeBinding();
            LoadFieldIdToCombobox(cbField);
            AddFieldBinding();
            AddAccountBinding();
        }
        void LoadAccountList()
        {
            accountlist.DataSource = AccountDAO.Instance.GetAccountList();
        }

        void AddAccountBinding()
        {
            txbIdAccount.DataBindings.Add(new Binding("Text", dataAccount.DataSource, "IdAccount", true, DataSourceUpdateMode.Never));
            textBoxUserName.DataBindings.Add(new Binding("Text", dataAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            textBoxDisplayName.DataBindings.Add(new Binding("Text", dataAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmAccountType.DataBindings.Add(new Binding("Value", dataAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        void AddTimeBinding()
        {
            txbIDtime.DataBindings.Add(new Binding("Text", dtgvTime.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txbTimeName.DataBindings.Add(new Binding("Text", dtgvTime.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbTimeStatus.DataBindings.Add(new Binding("Text", dtgvTime.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }

        void LoadFieldIdToCombobox(ComboBox cb)
        {
            cb.DataSource = FieldDAO.Instance.LoadFieldList();
            cb.DisplayMember = "FieldName";
        }
        void AddFieldBinding()
        {
            txbFieldName.DataBindings.Add(new Binding("Text", dtgvField.DataSource, "FieldName", true, DataSourceUpdateMode.Never));
            txbFieldID.DataBindings.Add(new Binding("Text", dtgvField.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbFieldType.DataBindings.Add(new Binding("Text", dtgvField.DataSource, "FieldType", true, DataSourceUpdateMode.Never));
            txtBoxFieldStatus.DataBindings.Add(new Binding("Text", dtgvField.DataSource, "FieldStatus", true, DataSourceUpdateMode.Never));
            nmFieldPrice.DataBindings.Add(new Binding("Value", dtgvField.DataSource, "FieldPrice", true, DataSourceUpdateMode.Never));
        }
        void LoadListBillByDate(DateTime checkin, DateTime checkout)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkin, checkout);
        }

        void LoadListField()
        {
            fieldlist.DataSource = FieldDAO.Instance.LoadFieldList();
        }
        void LoadListTime()
        {
            timelist.DataSource = TableDAO.Instance.GetTableList();
        }
        #endregion
        #region events


        private void dtgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonViewBill_Click_1(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private void tcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabField_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadListField();
        }
        #endregion

        private void dtgvTime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadListTime();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fieldName = txbFieldName.Text;
            string fieldType = txbFieldType.Text;
            float price = (float)nmFieldPrice.Value;
            int fieldStatus = int.Parse(txtBoxFieldStatus.Text);

            if (FieldDAO.Instance.InsertField(fieldName, price, fieldStatus, fieldType))
            {
                MessageBox.Show("Thêm sân thành công");
                LoadListField();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm sân");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fieldName = txbFieldName.Text;
            string fieldType = txbFieldType.Text;
            float price = (float)nmFieldPrice.Value;
            int fieldStatus = int.Parse(txtBoxFieldStatus.Text);
            int fieldId = int.Parse(txbFieldID.Text);

            if (FieldDAO.Instance.UpdateField(fieldName, price, fieldStatus, fieldType, fieldId))
            {
                MessageBox.Show("Sửa thông tin sân thành công");
                LoadListField();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thông tin sân");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fieldId = int.Parse(txbFieldID.Text);

            if (FieldDAO.Instance.DeleteField(fieldId))
            {
                MessageBox.Show("Xóa thông tin sân thành công");
                LoadListField();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thông tin sân");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string timeName = txbTimeName.Text;
            int fieldId = (cbField.SelectedItem as Field).Id;
            string timeStatus = txbTimeStatus.Text;

            if (TableDAO.Instance.InsertTime(timeName, fieldId, timeStatus))
            {
                MessageBox.Show("Thêm khung giờ thành công");
                LoadListTime();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm khung giờ");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string timeName = txbTimeName.Text;
            int fieldId = (cbField.SelectedItem as Field).Id;
            string timeStatus = txbTimeStatus.Text;
            int timeId = int.Parse(txbIDtime.Text);

            if (TableDAO.Instance.UpdateTime(timeName, fieldId, timeStatus, timeId))
            {
                MessageBox.Show("Sửa thông tin  khung giờ thành công");
                LoadListTime();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thông tín khung giờ");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int timeId = int.Parse(txbIDtime.Text);

            if (TableDAO.Instance.DeleteTime(timeId))
            {
                MessageBox.Show("Xóa thông tin khung giờ thành công");
                LoadListTime();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thông tin khung giờ");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonInfoAccount_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int accountId = int.Parse(txbIdAccount.Text);
            if (AccountDAO.Instance.DeleteAccount(accountId))
            {
                MessageBox.Show("Xóa thông tin tài khoản thành công");
                LoadAccountList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thông tin tài khoản");
            }
        }

        private void buttonAdjustAccount_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string displayName = textBoxDisplayName.Text;
            int accountId = int.Parse(txbIdAccount.Text);
            int accountType = (int)nmAccountType.Value;

            if (AccountDAO.Instance.UpdateAccount(userName, accountType, displayName, accountId))
            {
                MessageBox.Show("Sửa thông tin tài khoản thành công");
                LoadAccountList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thông tin tài khoản");
            }
        }

        private void dtgvBill_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
