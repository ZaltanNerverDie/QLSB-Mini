using QuanLySanBongMini.DAO;
using QuanLySanBongMini.DTO;

namespace QuanLySanBongMini
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = textBox1.Text;
            string Password = textBox2.Text;
            if (Login(UserName, Password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(UserName);
                FQuanLySanBong f = new FQuanLySanBong(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }
        bool Login(string UserName, string password)
        {
            return AccountDAO.Instance.Login(UserName, password);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }
    }
}