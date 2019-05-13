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
    public partial class frmLend : Form
    {
        public static bool success2 = false;
        public frmLend()
        {
            InitializeComponent();
            dateA.Format = DateTimePickerFormat.Custom;
            dateA.CustomFormat = "dd/MM/yyyy";
            dateB.Format = DateTimePickerFormat.Custom;
            dateB.CustomFormat = "dd/MM/yyyy";
            dateC.Format = DateTimePickerFormat.Custom;
            dateC.CustomFormat = "dd/MM/yyyy";
            dateC.Enabled = false;     
        }
        private void LoadData()
        {
            string sql = "select SACH.MASACH, SACH.TENSACH, QLSACH.NGAYMUON, QLSACH.NGAYTRA, " +
                "DOCGIA.TEN, DOCGIA.NGAYSINH, QLSACH.MADOCGIA " +
                "FROM (SACH INNER JOIN QLSACH ON SACH.MASACH=QLSACH.MASACH) INNER JOIN DOCGIA ON QLSACH.MADOCGIA=DOCGIA.MADOCGIA";    
            dtgrLend.DataSource= ClassTV.GetDataTable(sql);
            dtgrLend.Sort(dtgrLend.Columns["NGAYMUON"], ListSortDirection.Ascending);
            dtgrLend.Columns[0].HeaderText = "MÃ SÁCH";
            dtgrLend.Columns[1].HeaderText = "TÊN SÁCH";
            dtgrLend.Columns[2].HeaderText = "NGÀY MƯỢN";
            dtgrLend.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgrLend.Columns[3].HeaderText = "NGÀY TRẢ";
            dtgrLend.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgrLend.Columns[4].HeaderText = "NGƯỜI MƯỢN";
            dtgrLend.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgrLend.Columns[5].HeaderText = "NGÀY SINH";
            dtgrLend.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgrLend.Columns[6].HeaderText = "MÃ ĐỘC GIẢ";

            txtName.ValueMember = "TENSACH";
            txtName.DisplayMember = "TENSACH";
            txtName.DataSource = ClassTV.GetDataTable("select * from SACH where DAMUON=false");

            txtCode.ValueMember = "MASACH";
            txtCode.DisplayMember = "MASACH";
            txtCode.DataSource = ClassTV.GetDataTable("select * from SACH  where DAMUON=false");

            txtReader.ValueMember = "TEN";
            txtReader.DisplayMember = "TEN";
            txtReader.DataSource = ClassTV.GetDataTable("select * from DOCGIA");

            txtReaderC.ValueMember = "MADOCGIA";
            txtReaderC.DisplayMember = "MADOCGIA";
            txtReaderC.DataSource = ClassTV.GetDataTable("select * from DOCGIA");

            cbD.ValueMember = "NGAYSINH";
            cbD.DisplayMember = "NGAYSINH";
            cbD.DataSource = ClassTV.GetDataTable("select * from DOCGIA");

            txtReaderC.Enabled = false;
            ShowData();

        }
        private void ShowData()
        {
            txtCode.DataBindings.Clear();
            txtCode.DataBindings.Add("Text", dtgrLend.DataSource, "MASACH");
            txtCode.Enabled = false;
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", dtgrLend.DataSource, "TENSACH");
            txtName.Enabled = false;
            txtReaderC.DataBindings.Clear();
            txtReaderC.DataBindings.Add("Text", dtgrLend.DataSource, "MADOCGIA");
            txtReaderC.Enabled = false;
            txtReader.DataBindings.Clear();
            txtReader.DataBindings.Add("Text", dtgrLend.DataSource, "TEN");
            dateA.DataBindings.Clear();
            dateA.DataBindings.Add("Value", dtgrLend.DataSource, "NGAYMUON");
            dateC.DataBindings.Clear();
            dateC.DataBindings.Add("Value", dtgrLend.DataSource, "NGAYTRA");
            dateB.DataBindings.Clear();
            dateB.DataBindings.Add("Value", dtgrLend.DataSource, "NGAYSINH");
            btnReload.Enabled = false;
            btnAdd.Enabled = false;
            btnDel.Enabled = true;
            btnEdit.Enabled = true;
            dtgrLend.Focus();
        }

        private void frmLend_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string Code = txtCode.Text;
            DialogResult ans = MessageBox.Show("Xoá bản ghi mượn sách: " + txtName.Text + "?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                ClassTV.DeleteData_Lend(Code);
                MessageBox.Show("Xoá bản ghi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Thoát về menu chính?", "Thông báo",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes) this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtName.Text = "";
            txtReader.Text = "";
            txtReaderC.Text = "";
            btnReload.Enabled = true;
            txtReaderC.Enabled = true;
            txtName.Enabled = true;
            btnAdd.Enabled = true;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
        }
        private void txtName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtCode.SelectedIndex = txtName.SelectedIndex;
            }
            catch (ArgumentOutOfRangeException) { };
        }

        private void txtReader_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtReaderC.SelectedIndex = txtReader.SelectedIndex;
                cbD.SelectedIndex = txtReader.SelectedIndex;
                dateB.Value = Convert.ToDateTime(cbD.Text);
            }
            catch (ArgumentOutOfRangeException) { };
        }

        private void txtReaderC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtReader.SelectedIndex = txtReaderC.SelectedIndex;
            }
            catch (ArgumentOutOfRangeException) { };
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string Code = txtCode.Text;
            string ReaderC = txtReaderC.Text;
            string Reader = txtReader.Text;
            DateTime dataA = dateA.Value;
            DateTime dataB = dateB.Value;
            DateTime dataC = dateC.Value;
            if (ReaderC == "")
            {
                MessageBox.Show("Trường Mã không được bỏ trống!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                ClassTV.EditData_Lend(Code, ReaderC, Reader, dataA, dataB, dataC);
                LoadData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool a = false, b = false;
            string Name = txtName.Text;
            string Code = txtCode.Text;
            string ReaderC = txtReaderC.Text;
            string Reader = txtReader.Text;
            DateTime dataA = dateA.Value;
            DateTime dataB = dateB.Value;
            DateTime dataC = dateC.Value;
            if (Code == "") b = true;            
            if (ReaderC == "") a = true;
            if (a || b)
            {
                MessageBox.Show("Các trường Mã không được bỏ trống!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult ans = MessageBox.Show("Thông tin về bản ghi mới:\n" + "Tên sách: " + Name + "\nMã Sách: " + Code +
                "\nNgày mượn: " + dateA.Text+ "\nNgày mượn: " + dateC.Text + "\nNgười mượn: " + Reader + "\nMã Độc giả: " + ReaderC + "\nNgày sinh: " + dateB.Text +
                "\n\nThêm bản ghi này?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes) ClassTV.AddData_Lend(Code, dataA, Reader, ReaderC, dataB, dataC);
                if (success2 == true) LoadData();
                success2 = false;
            }
        }

        private void btnAddCode_Click(object sender, EventArgs e)
        {
            txtReader.Text = "";
            txtReaderC.Text = "";
            txtReaderC.Enabled = true;
        }

        private void dateA_ValueChanged(object sender, EventArgs e)
        {
            DateTime s = dateA.Value;
            DateTime ss = s.AddDays(30);
            dateC.Value = ss;
        }
    }
}
