using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace QLTV_demo
{
    class ClassTV
    {
        public static OleDbConnection oledbCon;
        public static DataTable dttb;
        public static OleDbCommand oledbCmd;
        public static OleDbDataAdapter oledbAdap;

        public static void ConOpen()
        {
            string s;
            s = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + Application.StartupPath + @"\dtbss.mdb";
            oledbCon = new OleDbConnection(s);
            oledbCon.Open();
        }
        public static bool Login(string id, string pass)
        {
            ConOpen();
            string s1;
            s1 = "Select COUNT(*) From DANGNHAP where MANV = @ID and MATKHAU =@PW";
            OleDbCommand cmd = new OleDbCommand(s1, oledbCon);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@PW", pass);
            bool test = Convert.ToBoolean(cmd.ExecuteScalar());
            return test;
        }
        public static void ConClose()
        {
            oledbCon.Close();
            oledbCon.Dispose();
            oledbCon = null;
        }
        public static DataTable GetDataTable(string SQlcode)
        {
            ConOpen();
            DataTable dttb = new DataTable();
            oledbCmd = new OleDbCommand(SQlcode, oledbCon);
            oledbAdap = new OleDbDataAdapter(oledbCmd);
            oledbAdap.Fill(dttb);
            ConClose();
            return dttb;
        }
        public static void AddData_Book(string Code, string Name, string Year, string AuthC, string GenreC, string PubC, string Auth, string Genre, string Pub)
        {

            ConOpen();
            try
            {
                DataTable dttb = new DataTable();
                OleDbDataAdapter oledbAdap = new OleDbDataAdapter
                    ("select * from SACH", oledbCon);
                oledbAdap.Fill(dttb);
                DataRow dong = dttb.NewRow();
                dong["MASACH"] = Code;
                dong["TENSACH"] = Name;
                dong["NAMXB"] = Year;

                dttb.Rows.Add(dong);
                OleDbCommand oledbCmd = new OleDbCommand();
                oledbCmd.Connection = oledbCon;
                oledbCmd.CommandType = CommandType.Text;
                oledbCmd.CommandText = "Insert into SACH (MASACH, TENSACH, NAMXB) values(@MASACH, @TENSACH, @NAMXB)";
                oledbCmd.Parameters.AddWithValue("@MASACH", Code);
                oledbCmd.Parameters.AddWithValue("@TENSACH", Name);
                oledbCmd.Parameters.AddWithValue("@NAMXB", Year);
                oledbAdap.InsertCommand = oledbCmd;
                oledbAdap.Update(dttb);
                oledbCmd.Dispose();
                oledbCmd = null;
            }
            catch (OleDbException)
            {
                MessageBox.Show("Trùng Mã sách", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DataTable dttb1 = new DataTable();
                OleDbDataAdapter oledbAdap1 = new OleDbDataAdapter
                    ("select * from TACGIA", oledbCon);
                oledbAdap1.Fill(dttb1);
                DataRow dong1 = dttb1.NewRow();
                dong1["MATACGIA"] = AuthC;
                dong1["TENTACGIA"] = Auth;
                dttb1.Rows.Add(dong1);
                OleDbCommand oledbCmd1 = new OleDbCommand();
                oledbCmd1.Connection = oledbCon;
                oledbCmd1.CommandType = CommandType.Text;
                oledbCmd1.CommandText = "Insert into TACGIA (MATACGIA, TENTACGIA) values(@MATACGIA, @TENTACGIA)";
                oledbCmd1.Parameters.AddWithValue("@MATACGIA", AuthC);
                oledbCmd1.Parameters.AddWithValue("@TENTACGIA", Auth);
                oledbAdap1.InsertCommand = oledbCmd1;
                oledbAdap1.Update(dttb1);
                oledbCmd1.Dispose();
                oledbCmd1 = null;
            }
            catch (OleDbException) { };

            try
            {
                DataTable dttb2 = new DataTable();
                OleDbDataAdapter oledbAdap2 = new OleDbDataAdapter
                    ("select * from THELOAI", oledbCon);
                oledbAdap2.Fill(dttb2);
                DataRow dong2 = dttb2.NewRow();
                dong2["MATHELOAI"] = GenreC;
                dong2["TENTHELOAI"] = Genre;
                dttb2.Rows.Add(dong2);
                OleDbCommand oledbCmd2 = new OleDbCommand();
                oledbCmd2.Connection = oledbCon;
                oledbCmd2.CommandType = CommandType.Text;
                oledbCmd2.CommandText = "Insert into THELOAI(MATHELOAI, TENTHELOAI) values(@MATHELOAI, @TENTHELOAI)";
                oledbCmd2.Parameters.AddWithValue("@MATHELOAI", GenreC);
                oledbCmd2.Parameters.AddWithValue("@TENTHELOAI", Genre);
                oledbAdap2.InsertCommand = oledbCmd2;
                oledbAdap2.Update(dttb2);
                oledbCmd2.Dispose();
                oledbCmd2 = null;
            }
            catch (OleDbException) { };

            try
            {
                DataTable dttb3 = new DataTable();
                OleDbDataAdapter oledbAdap3 = new OleDbDataAdapter
                    ("select * from NXB", oledbCon);
                oledbAdap3.Fill(dttb3);
                DataRow dong3 = dttb3.NewRow();
                dong3["MANXB"] = PubC;
                dong3["TENNXB"] = Pub;
                dttb3.Rows.Add(dong3);
                OleDbCommand oledbCmd3 = new OleDbCommand();
                oledbCmd3.Connection = oledbCon;
                oledbCmd3.CommandType = CommandType.Text;
                oledbCmd3.CommandText = "Insert into NXB (MANXB, TENNXB) values(@MANXB, @TENNXB)";
                oledbCmd3.Parameters.AddWithValue("@MANXB", PubC);
                oledbCmd3.Parameters.AddWithValue("@TENNXB", Pub);
                oledbAdap3.InsertCommand = oledbCmd3;
                oledbAdap3.Update(dttb3);
                oledbCmd3.Dispose();
                oledbCmd3 = null;
            }
            catch (OleDbException) { };


            DataTable dttb4 = new DataTable();
            OleDbDataAdapter oledbAdap4 = new OleDbDataAdapter
                ("select * from QLMA", oledbCon);
            oledbAdap4.Fill(dttb4);
            DataRow dong4 = dttb4.NewRow();
            dong4["MATACGIA"] = AuthC;
            dong4["MASACH"] = Code;
            dong4["MATHELOAI"] = GenreC;
            dong4["MANXB"] = PubC;
            dttb4.Rows.Add(dong4);
            OleDbCommand oledbCmd4 = new OleDbCommand();
            oledbCmd4.Connection = oledbCon;
            oledbCmd4.CommandType = CommandType.Text;
            oledbCmd4.CommandText = "Insert into QLMA (MASACH, MATACGIA, MATHELOAI, MANXB) values(@MASACH, @MATACGIA, @MATHELOAI, @MANXB)";
            oledbCmd4.Parameters.AddWithValue("@MASACH", Code);
            oledbCmd4.Parameters.AddWithValue("@MATACGIA", AuthC);
            oledbCmd4.Parameters.AddWithValue("@MATHELOAI", GenreC);
            oledbCmd4.Parameters.AddWithValue("@MANXB", PubC);
            oledbAdap4.InsertCommand = oledbCmd4;
            oledbAdap4.Update(dttb4);
            oledbCmd4.Dispose();
            oledbCmd4 = null;

            ConClose();
            MessageBox.Show("Thêm bản ghi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmBookMan.success = true;

        }
        public static void DeleteData_Book(string Code)
        {
            ConOpen();

            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from SACH", oledbCon);
            DataTable dttb = new DataTable();
            objAdapter.Fill(dttb);
            new OleDbCommandBuilder(objAdapter);
            DataRow[] objRow = dttb.Select("MASACH = '" + Code + "'");
            objRow[0].Delete();
            objAdapter.Update(dttb);
            objAdapter.Dispose();
            objAdapter = null;
            dttb.Dispose();
            dttb = null;

            OleDbDataAdapter objAdapter1 = new OleDbDataAdapter("select * from QLMA", oledbCon);
            DataTable dttb1 = new DataTable();
            objAdapter1.Fill(dttb1);
            new OleDbCommandBuilder(objAdapter1);
            DataRow[] objRow1 = dttb1.Select("MASACH = '" + Code + "'");
            objRow1[0].Delete();
            objAdapter1.Update(dttb1);
            objAdapter1.Dispose();
            objAdapter1 = null;
            dttb1.Dispose();
            dttb1 = null;

            ConClose();
        }
        public static void EditData_Book(string Code, string Name, string Auth, string Genre, string Pub, string AuthC, string GenreC, string PubC, string Year)
        {
            ConOpen();

            OleDbCommand oledbCmd = new OleDbCommand();
            oledbCmd.Connection = oledbCon;
            oledbCmd.CommandType = CommandType.Text;
            oledbCmd.CommandText = "Update SACH Set TENSACH=@TENSACH, NAMXB=@NAMXB "
                                   + "Where MASACH=@MASACH";
            oledbCmd.Parameters.AddWithValue("@TENSACH", Name);
            oledbCmd.Parameters.AddWithValue("@NAMXB", Year);
            oledbCmd.Parameters.Add("@MASACH", OleDbType.VarChar).Value = Code;
            oledbCmd.ExecuteNonQuery();
            oledbCmd.Dispose();
            oledbCmd = null;

            OleDbCommand oledbCmd1 = new OleDbCommand();
            oledbCmd1.Connection = oledbCon;
            oledbCmd1.CommandType = CommandType.Text;
            oledbCmd1.CommandText = "Update TACGIA Set TENTACGIA=@TENTACGIA "
                                   + "Where MATACGIA=@MAMATACGIA";
            oledbCmd1.Parameters.AddWithValue("@TENTACGIA", Auth);
            oledbCmd1.Parameters.Add("@MATACGIA", OleDbType.VarChar).Value = AuthC;
            oledbCmd1.ExecuteNonQuery();
            oledbCmd1.Dispose();
            oledbCmd1 = null;

            OleDbCommand oledbCmd2 = new OleDbCommand();
            oledbCmd2.Connection = oledbCon;
            oledbCmd2.CommandType = CommandType.Text;
            oledbCmd2.CommandText = "Update THELOAI Set TENTHELOAI=@TENTHELOAI "
                                   + "Where MATHELOAI=@MATHELOAI";
            oledbCmd2.Parameters.AddWithValue("@TENTHELOAI", Genre);
            oledbCmd2.Parameters.Add("@MATHELOAI", OleDbType.VarChar).Value = GenreC;
            oledbCmd2.ExecuteNonQuery();
            oledbCmd2.Dispose();
            oledbCmd2 = null;

            OleDbCommand oledbCmd3 = new OleDbCommand();
            oledbCmd3.Connection = oledbCon;
            oledbCmd3.CommandType = CommandType.Text;
            oledbCmd3.CommandText = "Update NXB Set TENNXB=@TENNXB "
                                   + "Where MANXB=@MANXB";
            oledbCmd3.Parameters.AddWithValue("@TENNXB", Pub);
            oledbCmd3.Parameters.Add("@MANXB", OleDbType.VarChar).Value = PubC;
            oledbCmd3.ExecuteNonQuery();
            oledbCmd3.Dispose();
            oledbCmd3 = null;

            OleDbCommand oledbCmd4 = new OleDbCommand();
            oledbCmd4.Connection = oledbCon;
            oledbCmd4.CommandType = CommandType.Text;
            oledbCmd4.CommandText = "Update QLMA Set MATACGIA=@MATACGIA, MANXB=@MANXB, MATHELOAI=@MATHELOAI "
                                   + "Where MASACH=@MASACH";
            oledbCmd4.Parameters.AddWithValue("@MATACGIA", AuthC);
            oledbCmd4.Parameters.AddWithValue("@MANXB", PubC);
            oledbCmd4.Parameters.AddWithValue("@MATHELOAI", GenreC);
            oledbCmd4.Parameters.Add("@MASACH", OleDbType.VarChar).Value = Code;
            oledbCmd4.ExecuteNonQuery();
            oledbCmd4.Dispose();
            oledbCmd4 = null;

            try
            {
                DataTable dttb5 = new DataTable();
                OleDbDataAdapter oledbAdap5 = new OleDbDataAdapter
                    ("select * from TACGIA", oledbCon);
                oledbAdap5.Fill(dttb5);
                DataRow dong5 = dttb5.NewRow();
                dong5["MATACGIA"] = AuthC;
                dong5["TENTACGIA"] = Auth;
                dttb5.Rows.Add(dong5);
                OleDbCommand oledbCmd5 = new OleDbCommand();
                oledbCmd5.Connection = oledbCon;
                oledbCmd5.CommandType = CommandType.Text;
                oledbCmd5.CommandText = "Insert into TACGIA (MATACGIA, TENTACGIA) values(@MATACGIA, @TENTACGIA)";
                oledbCmd5.Parameters.AddWithValue("@MATACGIA", AuthC);
                oledbCmd5.Parameters.AddWithValue("@TENTACGIA", Auth);
                oledbAdap5.InsertCommand = oledbCmd5;
                oledbAdap5.Update(dttb5);
                oledbCmd5.Dispose();
                oledbCmd5 = null;
            }
            catch (OleDbException) { };

            try
            {
                DataTable dttb6 = new DataTable();
                OleDbDataAdapter oledbAdap6 = new OleDbDataAdapter
                    ("select * from THELOAI", oledbCon);
                oledbAdap6.Fill(dttb6);
                DataRow dong6 = dttb6.NewRow();
                dong6["MATHELOAI"] = GenreC;
                dong6["TENTHELOAI"] = Genre;
                dttb6.Rows.Add(dong6);
                OleDbCommand oledbCmd6 = new OleDbCommand();
                oledbCmd6.Connection = oledbCon;
                oledbCmd6.CommandType = CommandType.Text;
                oledbCmd6.CommandText = "Insert into THELOAI(MATHELOAI, TENTHELOAI) values(@MATHELOAI, @TENTHELOAI)";
                oledbCmd6.Parameters.AddWithValue("@MATHELOAI", GenreC);
                oledbCmd6.Parameters.AddWithValue("@TENTHELOAI", Genre);
                oledbAdap6.InsertCommand = oledbCmd6;
                oledbAdap6.Update(dttb6);
                oledbCmd6.Dispose();
                oledbCmd6 = null;
            }
            catch (OleDbException) { };

            try
            {
                DataTable dttb7 = new DataTable();
                OleDbDataAdapter oledbAdap7 = new OleDbDataAdapter
                    ("select * from NXB", oledbCon);
                oledbAdap7.Fill(dttb7);
                DataRow dong7 = dttb7.NewRow();
                dong7["MANXB"] = PubC;
                dong7["TENNXB"] = Pub;
                dttb7.Rows.Add(dong7);
                OleDbCommand oledbCmd7 = new OleDbCommand();
                oledbCmd7.Connection = oledbCon;
                oledbCmd7.CommandType = CommandType.Text;
                oledbCmd7.CommandText = "Insert into NXB (MANXB, TENNXB) values(@MANXB, @TENNXB)";
                oledbCmd7.Parameters.AddWithValue("@MANXB", PubC);
                oledbCmd7.Parameters.AddWithValue("@TENNXB", Pub);
                oledbAdap7.InsertCommand = oledbCmd7;
                oledbAdap7.Update(dttb7);
                oledbCmd7.Dispose();
                oledbCmd7 = null;
            }
            catch (OleDbException) { };

            MessageBox.Show("Xong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ConClose();
        }
        public static void DeleteData_Lend(string Code)
        {
            ConOpen();

            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from QLSACH", oledbCon);
            DataTable dttb = new DataTable();
            objAdapter.Fill(dttb);
            new OleDbCommandBuilder(objAdapter);
            DataRow[] objRow = dttb.Select("MASACH = '" + Code + "'");
            objRow[0].Delete();
            objAdapter.Update(dttb);
            objAdapter.Dispose();
            objAdapter = null;
            dttb.Dispose();
            dttb = null;

            OleDbCommand oledbCmd = new OleDbCommand();
            oledbCmd.Connection = oledbCon;
            oledbCmd.CommandType = CommandType.Text;
            oledbCmd.CommandText = "Update SACH set DAMUON=@DAMUON Where MASACH=@MASACH";
            oledbCmd.Parameters.AddWithValue("@DAMUON", false);
            oledbCmd.Parameters.Add("@MASACH", OleDbType.VarChar).Value = Code;
            oledbCmd.ExecuteNonQuery();
            oledbCmd.Dispose();
            oledbCmd = null;

            ConClose();
        }
        public static void EditData_Lend(string Code, string ReaderC, string Reader, DateTime dateA, DateTime dateB, DateTime dateC)
        {
            ConOpen();

            try
            {

                DataTable dttb3 = new DataTable();
                OleDbDataAdapter oledbAdap3 = new OleDbDataAdapter("select * from DOCGIA", oledbCon);
                oledbAdap3.Fill(dttb3);
                DataRow dong3 = dttb3.NewRow();
                dong3["MADOCGIA"] = ReaderC;
                dong3["TEN"] = Reader;
                dong3["NGAYSINH"] = dateB;
                dttb3.Rows.Add(dong3);
                OleDbCommand oledbCmd3 = new OleDbCommand();
                oledbCmd3.Connection = oledbCon;
                oledbCmd3.CommandType = CommandType.Text;
                oledbCmd3.CommandText = "Insert into DOCGIA (MADOCGIA, TEN, NGAYSINH) values(@MADOCGIA, @TENDOCGIA, @NGAYSINH)";
                oledbCmd3.Parameters.AddWithValue("@MADOCGIA", ReaderC);
                oledbCmd3.Parameters.AddWithValue("@TENDOCGIA", Reader);
                oledbCmd3.Parameters.AddWithValue("@NGAYSINH", dateB);
                oledbAdap3.InsertCommand = oledbCmd3;
                oledbAdap3.Update(dttb3);
                oledbCmd3.Dispose();
                oledbCmd3 = null;

            }
            catch (OleDbException) { }

            OleDbCommand oledbCmd = new OleDbCommand();
            oledbCmd.Connection = oledbCon;
            oledbCmd.CommandType = CommandType.Text;
            oledbCmd.CommandText = "Update QLSACH set NGAYMUON=@NGAYMUON, NGAYTRA=@NGAYTRA, MADOCGIA=@MADOCGIA Where MASACH=@MASACH";
            oledbCmd.Parameters.AddWithValue("@NGAYMUON", dateA);
            oledbCmd.Parameters.AddWithValue("@NGAYTRA", dateC);
            oledbCmd.Parameters.AddWithValue("@MADOCGIA", ReaderC);
            oledbCmd.Parameters.Add("@MASACH", OleDbType.VarChar).Value = Code;
            oledbCmd.ExecuteNonQuery();
            oledbCmd.Dispose();
            oledbCmd = null;


            OleDbCommand oledbCmd2 = new OleDbCommand();
            oledbCmd2.Connection = oledbCon;
            oledbCmd2.CommandType = CommandType.Text;
            oledbCmd2.CommandText = "Update DOCGIA set NGAYSINH=@NGAYSINH, TEN=@TENDOCGIA Where MADOCGIA=@MADOCGIA";
            oledbCmd2.Parameters.AddWithValue("@NGAYSINH", dateB);
            oledbCmd2.Parameters.AddWithValue("@TENDOCGIA", Reader);
            oledbCmd2.Parameters.Add("@MADOCGIA", OleDbType.VarChar).Value = ReaderC;
            oledbCmd2.ExecuteNonQuery();
            oledbCmd2.Dispose();
            oledbCmd2 = null;
            MessageBox.Show("Xong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ConClose();
        }
        public static void AddData_Lend(string Code, DateTime dateA, string Reader, string ReaderC, DateTime dateB, DateTime dateC)
        {
            ConOpen();
            try
            {

                DataTable dttb2 = new DataTable();
                OleDbDataAdapter oledbAdap2 = new OleDbDataAdapter("select * from DOCGIA", oledbCon);
                oledbAdap2.Fill(dttb2);
                DataRow dong2 = dttb2.NewRow();
                dong2["MADOCGIA"] = ReaderC;
                dong2["TEN"] = Reader;
                dong2["NGAYSINH"] = dateB;
                dttb2.Rows.Add(dong2);
                OleDbCommand oledbCmd2 = new OleDbCommand();
                oledbCmd2.Connection = oledbCon;
                oledbCmd2.CommandType = CommandType.Text;
                oledbCmd2.CommandText = "Insert into DOCGIA (MADOCGIA, TEN, NGAYSINH) values(@MADOCGIA, @TENDOCGIA, @NGAYSINH)";
                oledbCmd2.Parameters.AddWithValue("@MADOCGIA", ReaderC);
                oledbCmd2.Parameters.AddWithValue("@TENDOCGIA", Reader);
                oledbCmd2.Parameters.AddWithValue("@NGAYSINH", dateB);
                oledbAdap2.InsertCommand = oledbCmd2;
                oledbAdap2.Update(dttb2);
                oledbCmd2.Dispose();
                oledbCmd2 = null;

            }
            catch (OleDbException) { }

            DataTable dttb = new DataTable();
            OleDbDataAdapter oledbAdap = new OleDbDataAdapter("select * from QLSACH", oledbCon);
            oledbAdap.Fill(dttb);
            DataRow dong = dttb.NewRow();
            dong["MASACH"] = Code;
            dong["MADOCGIA"] = ReaderC;
            dong["NGAYMUON"] = dateA;
            dong["NGAYTRA"] = dateC;
            dttb.Rows.Add(dong);
            OleDbCommand oledbCmd = new OleDbCommand();
            oledbCmd.Connection = oledbCon;
            oledbCmd.CommandType = CommandType.Text;
            oledbCmd.CommandText = "Insert into QLSACH (MASACH, MADOCGIA, NGAYMUON, NGAYTRA) values(@MASACH, @MADOCGIA, @NGAYMUON, @NGAYTRA)";
            oledbCmd.Parameters.AddWithValue("@MASACH", Code);
            oledbCmd.Parameters.AddWithValue("@MADOCGIA", ReaderC);
            oledbCmd.Parameters.AddWithValue("@NGAYMUON", dateA);
            oledbCmd.Parameters.AddWithValue("@NGAYTRA", dateC);
            oledbAdap.InsertCommand = oledbCmd;
            oledbAdap.Update(dttb);
            oledbCmd.Dispose();
            oledbCmd = null;

            OleDbCommand oledbCmd3 = new OleDbCommand();
            oledbCmd3.Connection = oledbCon;
            oledbCmd3.CommandType = CommandType.Text;
            oledbCmd3.CommandText = "Update SACH set DAMUON=@DAMUON Where MASACH=@MASACH";
            oledbCmd3.Parameters.AddWithValue("@DAMUON", true);
            oledbCmd3.Parameters.Add("@MASACH", OleDbType.VarChar).Value = Code;
            oledbCmd3.ExecuteNonQuery();
            oledbCmd3.Dispose();
            oledbCmd3 = null;

            ConClose();
            MessageBox.Show("Thêm bản ghi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmLend.success2 = true;
        }
    }
}
    


