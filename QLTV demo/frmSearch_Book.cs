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
    public partial class frmSearch_Book : Form
    {
        public static DataTable dttb = null;
        public frmSearch_Book()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Ngưng tìm kiếm?", "Thông báo",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes) this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClassTV.ConOpen();
            dtgrBook.DataSource = null;
            string chsk = "";
            if (txtStat.Text == "Đã mượn") { chsk = "-1"; }
            else if (txtStat.Text == "Chưa mượn") { chsk = "0"; }
            string timkiem =
"Select SACH.MASACH, SACH.TENSACH, TACGIA.TENTACGIA, THELOAI.TENTHELOAI, NXB.TENNXB, SACH.NAMXB, SACH.DAMUON, " +
"QLMA.MATACGIA, QLMA.MATHELOAI, QLMA.MANXB from " +
"(((SACH INNER JOIN QLMA ON SACH.MASACH = QLMA.MASACH) INNER JOIN TACGIA ON QLMA.MATACGIA = TACGIA.MATACGIA) " +
"INNER JOIN THELOAI ON QLMA.MATHELOAI = THELOAI.MATHELOAI) INNER JOIN NXB ON QLMA.MANXB = NXB.MANXB" +
" where SACH.MASACH like '%" + txtCode.Text + "%' and TENSACH like '%"
+ txtName.Text + "%' and TENTACGIA like '%" + txtAuth.Text + "%' and TENTHELOAI like '%" + txtGenre.Text + "%' and TENNXB like '%"
+ txtPub.Text + "%' and NAMXB like '%" + txtYear.Text + "%' and DAMUON like '%" + chsk + "%'";
            dtgrBook.DataSource = ClassTV.GetDataTable(timkiem);
            dttb = ClassTV.GetDataTable(timkiem);
            dtgrBook.Sort(dtgrBook.Columns["MASACH"], ListSortDirection.Ascending);
            dtgrBook.Columns[0].HeaderText = "MÃ SÁCH";
            dtgrBook.Columns[1].HeaderText = "TÊN SÁCH";
            dtgrBook.Columns[2].HeaderText = "TÁC GIẢ";
            dtgrBook.Columns[3].HeaderText = "THỂ LOẠI";
            dtgrBook.Columns[4].HeaderText = "NHÀ XB";
            dtgrBook.Columns[5].HeaderText = "NĂM XB";
            dtgrBook.Columns[6].HeaderText = "ĐÃ MƯỢN";
            dtgrBook.Columns[7].HeaderText = "MÃ TÁC GIẢ";
            dtgrBook.Columns[8].HeaderText = "MÃ THỂ LOẠI";
            dtgrBook.Columns[9].HeaderText = "MÃ NXB";
            dtgrBook.ReadOnly = true;
            int num = dtgrBook.RowCount;
            if (num == 1) MessageBox.Show("Không tìm thấy bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRpt_Click(object sender, EventArgs e)
        {
            if (frmSearch_Book.dttb == null)
            {
                MessageBox.Show("Không có thông tin tìm kiếm!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                frmRpt_Book f = new frmRpt_Book();
                this.Enabled = false;
                f.Show();
                f.FormClosed += frmRpt_Book_FormClosed;
            }
        }
        private void frmRpt_Book_FormClosed(object sender, EventArgs e)
        {
            this.Enabled = true;
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
        }
    }
}
