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
    public partial class frmMain : Form
    {
        public static bool login;
        public frmMain()
        {
            InitializeComponent();
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Thoát chương trình?", "Thông báo", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes) this.Close();
        }

        private void btnHome_DropDownOpened(object sender, EventArgs e)
        {
            btnHome.ForeColor = DefaultForeColor;
        }
        private void btnHome_DropDownClosed(object sender, EventArgs e)
        {
            btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        }
        private void btnList_DropDownOpened(object sender, EventArgs e)
        {
            btnList.ForeColor = DefaultForeColor;
        }
        private void btnList_DropDownClosed(object sender, EventArgs e)
        {
            btnList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();            
            f.Show();

            this.Enabled = false;

            f.FormClosed += frmLogin_FormClosed;
        }
        private void frmLogin_FormClosed(object sender, EventArgs e)
        {
            if (login == true)
            {
                btnSearch.Enabled = true;
                btnList.Enabled = true;
                
                btnLend.Enabled = true;
            }
            this.Enabled = true;
            
        }

        private void btnList_book_Click(object sender, EventArgs e)
        {
            frmBookMan f = new frmBookMan();
            this.Enabled = false;
            f.Show();
            f.FormClosed += frmBookMan_FormClosed;
        }
        private void frmBookMan_FormClosed(object sender, EventArgs e)
        {           
            this.Enabled = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            btnList.Enabled = false;
          
            btnLend.Enabled = false;
        }

        private void btnRpt_Book_Click(object sender, EventArgs e)
        {
            frmRpt_Book f = new frmRpt_Book();
            this.Enabled = false;
            f.Show();
            f.FormClosed += frmRpt_Book_FormClosed;
        }
        private void frmRpt_Book_FormClosed(object sender, EventArgs e)
        {
            this.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch_Book f = new frmSearch_Book();
            this.Enabled = false;
            f.Show();
            f.FormClosed += frmSearch_FormClosed;
        }
        private void frmSearch_FormClosed(object sender, EventArgs e)
        {
            this.Enabled = true;
        }
        private void btnLend_Click(object sender, EventArgs e)
        {
            frmLend f = new frmLend();
            this.Enabled = false;
            f.Show();
            f.FormClosed += frmLend_FormClosed;
        }
        private void frmLend_FormClosed(object sender, EventArgs e)
        {
            this.Enabled = true;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng nhập trước khi sử dụng chương trình", "Trợ giúp", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            frmBookMan f = new frmBookMan();
            this.Enabled = false;
            f.Show();
            f.FormClosed += frmBookMan_FormClosed;
        }

        private void btnRpt_Click(object sender, EventArgs e)
        {
            frmRpt_Book f = new frmRpt_Book();
            this.Enabled = false;
            f.Show();
            f.FormClosed += frmRpt_Book_FormClosed;
        }
    }
}
