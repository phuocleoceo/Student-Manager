using MaterialSkin;
using MaterialSkin.Controls;
using QuanLySinhVien.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Login : MaterialForm
    {
        private readonly AccountRepository repository;
        public Login()
        {
            InitializeComponent();
            SetupMaterialSkin();
            txtPass.UseSystemPasswordChar = true;
            repository = new AccountRepository();
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

        private void SetupMaterialSkin()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ROBOTO_REGULAR_11 = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular);
            materialSkinManager.ROBOTO_MEDIUM_12 = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular);
            materialSkinManager.ROBOTO_MEDIUM_11 = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular);
            //materialSkinManager.ROBOTO_MEDIUM_10 = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular);
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700,
                                                Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
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
