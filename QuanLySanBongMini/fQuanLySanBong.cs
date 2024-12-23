using QuanLySanBongMini.DAO;
using QuanLySanBongMini.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBongMini
{
    public partial class FQuanLySanBong : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public FQuanLySanBong(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;
            LoadField();

        }

        #region Method

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem1.Enabled = type == 2;

        }
        void LoadField()
        {
            List<Field> fieldList = FieldDAO.Instance.LoadFieldList();
            comboBox1.DataSource = fieldList;
            comboBox1.DisplayMember = "FieldName";
            string fielType = (comboBox1.SelectedItem as Field).FieldType;
            txbFieldType.Text = fielType;
        }
        void LoadTableListByFieldID(int id)
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList(id);

            flpTable.Controls.Clear();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trong":
                        btn.BackColor = Color.Aqua;
                        break;
                    case "Da Dat San":
                        btn.BackColor = Color.LightPink;
                        break;
                    default:
                        btn.BackColor = Color.LightGreen;
                        break;
                }

                flpTable.Controls.Add(btn);

            }
        }
        void showFieldRegister(int id)
        {
            lsvBill.Items.Clear();
            List<MenuFR> listFieldRegister = MenuFRDAO.Instance.GetListMenuByTable(id);

            foreach (MenuFR item in listFieldRegister)
            {
                ListViewItem lsvItem = new ListViewItem(item.FieldName.ToString());
                lsvItem.SubItems.Add(item.TimeName.ToString());
                lsvItem.SubItems.Add(item.DisplayName.ToString());
                lsvItem.SubItems.Add(item.DateCreate.ToString());
                lsvItem.SubItems.Add(item.FieldPrice.ToString());

                lsvBill.Items.Add(lsvItem);
            }
        }

        #endregion

        #region Events
        void btn_Click(object? sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            lsvBill.Tag = (sender as Button).Tag;
            showFieldRegister(tableID);
        }
        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void FQuanLySanBong_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quảnLýSânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Field seclected = cb.SelectedItem as Field;
            id = seclected.Id;
            string fielType = seclected.FieldType;
            txbFieldType.Text = fielType;
            LoadTableListByFieldID(id);
        }

        private void buttonDatsan_Click(object sender, EventArgs e)
        {

            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Hãy chọn khung giờ trước");
            }
            else
            {
                if (table.Status == "Da Thanh Toan")
                {
                    MessageBox.Show("Khung giờ hiện đã thanh toán, vui lòng chọn khung giờ khác");
                }
                else
                {
                    int FieldId = (comboBox1.SelectedItem as Field).Id;
                    int AccountId = (int)LoginAccount.IdAccount;
                    int FieldRegisterId = FieldRegisterDAO.Instance.GetUncheckFRbyTableID(table.Id);

                    if (FieldRegisterId == -1)
                    {

                        FieldRegisterDAO.Instance.InsertFieldRegister(AccountId, table.Id);
                        FieldRegister fieldRegister = FieldRegisterDAO.Instance.GetFieldRegister(table.Id);
                        BillDAO.Instance.InsertBill(fieldRegister.Id);
                        TableDAO.Instance.UpdateStatusDatSan(table.Id);
                        LoadTableListByFieldID(FieldId);
                    }
                    else
                    {
                        MessageBox.Show("Khung giờ hiện đã có người đặt, vui lòng chọn khung giờ khác");
                    }
                    showFieldRegister(table.Id);
                }
            }
        }

        private void buttonHuysan_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn khung giờ trước");
            }

            else
            {
                FieldRegister fieldRegister = FieldRegisterDAO.Instance.GetFieldRegister(table.Id);
                int FieldId = (comboBox1.SelectedItem as Field).Id;
                int AccountId = (int)LoginAccount.IdAccount;
                int FieldRegisterId = FieldRegisterDAO.Instance.GetUncheckFRbyTableID(table.Id);
                if (FieldRegisterId == -1)
                {
                    MessageBox.Show("Khung giờ hiện chưa có người đặt");
                }
                else
                {
                    if (AccountId == fieldRegister.IdAccount)
                    {
                        BillDAO.Instance.DeleteBill(FieldRegisterId);
                        FieldRegisterDAO.Instance.DeleteFieldRegister(FieldRegisterId);
                        TableDAO.Instance.UpdateStatusTrong(table.Id);
                        LoadTableListByFieldID(FieldId);
                        showFieldRegister(table.Id);
                    }
                    else
                    {
                        MessageBox.Show("Bạn không thể hủy đặt sân của người khác");
                    }
                }


            }
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn khung giờ trước");
            }

            else
            {
                FieldRegister fieldRegister = FieldRegisterDAO.Instance.GetFieldRegister(table.Id);
                int FieldId = (comboBox1.SelectedItem as Field).Id;
                int AccountId = (int)LoginAccount.IdAccount;
                int AccountType = (int)LoginAccount.Type;
                int FieldRegisterId = FieldRegisterDAO.Instance.GetUncheckFRbyTableID(table.Id);
                if (FieldRegisterId == -1)
                {
                    MessageBox.Show("Khung giờ hiện chưa có người đặt");
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn này? ", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        if (AccountType == 1 || AccountType == 2)
                        {
                            BillDAO.Instance.Checkout(AccountId, FieldRegisterId);
                            FieldRegisterDAO.Instance.CheckoutFR(FieldRegisterId);
                            TableDAO.Instance.UpdateStatusDaThanhToan(table.Id);
                            LoadTableListByFieldID(FieldId);
                            showFieldRegister(table.Id);
                        }
                        else
                        {
                            MessageBox.Show("Bạn không phải nhân viên");
                        }
                    }
                }
            }
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount();
            f.ShowDialog();
        }

        private void btnResetStatus_Click(object sender, EventArgs e)
        {

            int AccountType = (int)LoginAccount.Type;
            int AccountId = (int)LoginAccount.IdAccount;
            int FieldId = (comboBox1.SelectedItem as Field).Id;
            Table table = TableDAO.Instance.GetTable();

            if (table == null)
            {
                MessageBox.Show("Hãy thêm khung giờ trước");
            }

            else
            {
                if (AccountType == 1 || AccountType == 2)
                {

                    if (MessageBox.Show("Bạn có chắc cập nhật danh sách sân cho ngày mới? ", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        int currentId = table.Id; // Assuming table.Id is the starting value
                        int maxId = 100;

                        while (currentId <= maxId)
                        {
                            TableDAO.Instance.UpdateStatusTrong(currentId);
                            currentId++;
                        }
                        FieldRegisterDAO.Instance.UpdateForNewDay();
                        TableDAO.Instance.UpdateStatusTrong(table.Id);
                        LoadTableListByFieldID(FieldId);
                        showFieldRegister(table.Id);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn không phải nhân viên");
                }
            }

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }


}
