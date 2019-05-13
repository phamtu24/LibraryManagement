using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QLTV_demo
{
    
    public partial class frmBookMan : Form
    {
        public static bool success=false;
        public frmBookMan()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string SQL =
"Select SACH.MASACH, SACH.TENSACH, TACGIA.TENTACGIA, THELOAI.TENTHELOAI, NXB.TENNXB, SACH.NAMXB, SACH.DAMUON, " +
"QLMA.MATACGIA, QLMA.MATHELOAI, QLMA.MANXB from " +
"(((SACH INNER JOIN QLMA ON SACH.MASACH = QLMA.MASACH) INNER JOIN TACGIA ON QLMA.MATACGIA = TACGIA.MATACGIA) " + 
"INNER JOIN THELOAI ON QLMA.MATHELOAI = THELOAI.MATHELOAI) INNER JOIN NXB ON QLMA.MANXB = NXB.MANXB";
            dtgrBook.DataSource = ClassTV.GetDataTable(SQL);          
            dtgrBook.Sort(dtgrBook.Columns["MASACH"], ListSortDirection.Ascending);
            dtgrBook.Columns[0].HeaderText = "MÃ SÁCH";
            dtgrBook.Columns[1].HeaderText = "TÊN SÁCH";
            dtgrBook.Columns[2].HeaderText = "TÁC GIẢ";
            dtgrBook.Columns[3].HeaderText = "THỂ LOẠI";
            dtgrBook.Columns[4].HeaderText = "NHÀ XB";
            dtgrBook.Columns[5].HeaderText = "NĂM XB";
            dtgrBook.Columns[6].HeaderText = "ĐÃ MƯỢN";
            dtgrBook.Columns[6].ReadOnly = true;
            dtgrBook.Columns[7].HeaderText = "MÃ TÁC GIẢ";
            dtgrBook.Columns[8].HeaderText = "MÃ THỂ LOẠI";
            dtgrBook.Columns[9].HeaderText = "MÃ NXB";

            txtAuth.ValueMember = "TENTACGIA";
            txtAuth.DisplayMember = "TENTACGIA";
            txtAuth.DataSource = ClassTV.GetDataTable("select * from TACGIA");
            txtAuthC.ValueMember = "MATACGIA";
            txtAuthC.DisplayMember = "MATACGIA";
            txtAuthC.DataSource = ClassTV.GetDataTable("select * from TACGIA");

            txtGenre.ValueMember = "TENTHELOAI";
            txtGenre.DisplayMember = "TENTHELOAI";
            txtGenre.DataSource = ClassTV.GetDataTable("select * from THELOAI");
            txtGenreC.ValueMember = "MATHELOAI";
            txtGenreC.DisplayMember = "MATHELOAI";
            txtGenreC.DataSource = ClassTV.GetDataTable("select * from THELOAI");

            txtPub.ValueMember = "TENNXB";
            txtPub.DisplayMember = "TENNXB";
            txtPub.DataSource = ClassTV.GetDataTable("select * from NXB");
            txtPubC.ValueMember = "MANXB";
            txtPubC.DisplayMember = "MANXB";
            txtPubC.DataSource = ClassTV.GetDataTable("select * from NXB");

            ShowData();
        }
        private void ShowData()
        {
            txtCode.DataBindings.Clear();
            txtCode.DataBindings.Add("Text", dtgrBook.DataSource, "MASACH");
            txtCode.Enabled = false;
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", dtgrBook.DataSource, "TENSACH");
            txtAuth.DataBindings.Clear();
            txtAuth.DataBindings.Add("Text", dtgrBook.DataSource, "TENTACGIA");
            txtGenre.DataBindings.Clear();
            txtGenre.DataBindings.Add("Text", dtgrBook.DataSource, "TENTHELOAI");
            txtPub.DataBindings.Clear();
            txtPub.DataBindings.Add("Text", dtgrBook.DataSource, "TENNXB");
            txtYear.DataBindings.Clear();
            txtYear.DataBindings.Add("Text", dtgrBook.DataSource, "NAMXB");
            chkSta.DataBindings.Clear();
            chkSta.DataBindings.Add("Checked", dtgrBook.DataSource, "DAMUON");
            txtAuthC.DataBindings.Clear();
            txtAuthC.DataBindings.Add("Text", dtgrBook.DataSource, "MATACGIA");
            txtAuthC.Enabled = false;
            txtGenreC.DataBindings.Clear();
            txtGenreC.DataBindings.Add("Text", dtgrBook.DataSource, "MATHELOAI");
            txtGenreC.Enabled = false;
            txtPubC.DataBindings.Clear();
            txtPubC.DataBindings.Add("Text", dtgrBook.DataSource, "MANXB");
            txtPubC.Enabled = false;
            btnDel.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;        
            dtgrBook.Enabled = true;
            int num = dtgrBook.RowCount - 1;
            txtNum.Text = num.ToString();
        }
        private void frmBookMan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Thoát về menu chính?", "Thông báo",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes) this.Close();
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
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtAuth.Text = "";
            txtCode.Text = "";
            txtCode.Enabled = true;
            txtGenre.Text = "";
            txtPub.Text = "";
            txtName.Text = "";
            txtYear.Text = "";
            txtAuthC.Text = "";
            txtAuthC.Enabled = true;
            txtGenreC.Text = "";
            txtGenreC.Enabled = true;
            txtPubC.Text = "";
            txtPubC.Enabled = true;           
            chkSta.Checked = false;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
            dtgrBook.Enabled = false;
            btnReload.Enabled = true;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {                        
            string Code = txtCode.Text;
            DialogResult ans = MessageBox.Show("Xoá bản ghi với Mã sách: " + Code + "?", "Thông báo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                ClassTV.DeleteData_Book(txtCode.Text);
                MessageBox.Show("Xoá bản ghi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string Code = txtCode.Text;
            string Name = txtName.Text;
            string Auth = txtAuth.Text;
            string Genre = txtGenre.Text;
            string Pub = txtPub.Text;
            string Year = txtYear.Text;
            bool Sta = chkSta.Checked;
            string PubC = txtPubC.Text;
            string GenreC = txtGenreC.Text;
            string AuthC = txtAuthC.Text;

            ClassTV.EditData_Book(Code, Name, Auth, Genre, Pub, AuthC, GenreC, PubC, Year);

            LoadData();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {            
            bool a = false, b = false, c = false, d = false;
            string Code = txtCode.Text;
            if (Code == "") a = false;
            string Name = txtName.Text;
            string Auth = txtAuth.Text;
            string Genre = txtGenre.Text;
            string Pub = txtPub.Text;
            string Year = txtYear.Text;
            string PubC = txtPubC.Text;
            if (PubC == "") b = true;
            string GenreC = txtGenreC.Text;
            if (GenreC == "") c = true;
            string AuthC = txtAuthC.Text;
            if (AuthC == "") d = true;
            if (a || c || b || d)
            {
                MessageBox.Show("Các trường Mã không được bỏ trống!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;                    
            }
            else
            {
                DialogResult ans = MessageBox.Show("Thông tin về bản ghi mới:\n" + "Tên sách: " + Name + "\nMã Sách: " + Code +
                "\nTác giả: " + Auth + "\nMã tác giả: " + AuthC + "\nThể loại: " + Genre + "\nMã tác giả: " + GenreC +
                "\nNhà xuất bản: " + Pub + "\nMã Nhà xuất bản: " + PubC + "\nNăm xuất bản: " + Year +
                "\n\nThêm bản ghi này?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes) ClassTV.AddData_Book(Code, Name, Year, AuthC, GenreC, PubC, Auth, Genre, Pub);
                if (success == true) LoadData();
                success = false;
            }        
        }

        private void btnAddAuth_Click(object sender, EventArgs e)
        {
            txtAuth.Text = "";
            txtAuthC.Text = "";
            txtAuthC.Enabled = true;
           
            dtgrBook.Enabled = false;
            btnReload.Enabled = true;
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            txtGenre.Text = "";
            txtGenreC.Text = "";
            txtGenreC.Enabled = true;
           
            dtgrBook.Enabled = false;
            btnReload.Enabled = true;
        }

        private void btnAddPub_Click(object sender, EventArgs e)
        {
            txtPub.Text = "";
            txtPubC.Text = "";
            txtPubC.Enabled = true;
            
            dtgrBook.Enabled = false;
            btnReload.Enabled = true;
        }
        private void txtAuth_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtAuthC.SelectedIndex = txtAuth.SelectedIndex;
            }
            catch (ArgumentOutOfRangeException) { };
        }

        private void txtAuthC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtAuth.SelectedIndex = txtAuthC.SelectedIndex;
            }
            catch (ArgumentOutOfRangeException) { };
        }
        private void txtGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtGenreC.SelectedIndex = txtGenre.SelectedIndex;
            }
            catch (ArgumentOutOfRangeException) { };
        }

        private void txtGenreC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtGenre.SelectedIndex = txtGenreC.SelectedIndex;
            }
            catch (ArgumentOutOfRangeException) { };
        }
        private void txtPub_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtPubC.SelectedIndex = txtPub.SelectedIndex;
            }
            catch (ArgumentOutOfRangeException) { };
        }

        private void txtPubC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtPub.SelectedIndex = txtPubC.SelectedIndex;
            }
            catch (ArgumentOutOfRangeException) { };
        }

        private void btnAddCode_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtCode.Text = "";
            txtCode.Enabled = true;
            btnEdit.Enabled = false;
            dtgrBook.Enabled = false;
            btnReload.Enabled = true;
            btnDel.Enabled = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();          
        }
    }
}
