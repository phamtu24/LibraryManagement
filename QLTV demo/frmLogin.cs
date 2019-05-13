using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV_demo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Thoát đăng nhập?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtID.Text == "" && txtPass.Text == "")
            {
                MessageBox.Show("Nhập Mã đăng nhập và Mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
            }
            else if (txtID.Text == "")
            {
                MessageBox.Show("Nhập Mã đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Nhập Mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPass.Focus();
            }
            else
            {
                bool test = ClassTV.Login(txtID.Text, txtPass.Text);
                if (test == true)
                {
                    MessageBox.Show("Đăng nhập thành công!","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain.login = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mã đăng nhập hoặc Mật khẩu không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtID.Focus();
                }
            }          
        }
    }
}
