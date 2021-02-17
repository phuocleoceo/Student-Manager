using QuanLySinhVien.Data;
using System;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Login : Form
    {
        /**/
        AccountRepository repository = new AccountRepository();
        /**/
        public Login()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string Nick = txtNick.Text;
            string Pass = txtPass.Text;
            if (repository.CheckLogin(Nick, Pass))
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Closed += (s, args) => this.Close();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu\nVui lòng thử lại !", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPASS_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            btnSHOWPASS.Hide();
            btnHIDEPASS.Show();
        }

        private void btnHIDEPASS_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            btnHIDEPASS.Hide();
            btnSHOWPASS.Show();
        }
    }
}
