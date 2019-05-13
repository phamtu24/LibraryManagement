namespace QLTV_demo
{
    partial class frmBookMan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookMan));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPub = new System.Windows.Forms.Label();
            this.lblAuth = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dtgrBook = new System.Windows.Forms.DataGridView();
            this.lblSta = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnAddAuth = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnAddPub = new System.Windows.Forms.Button();
            this.txtAuth = new System.Windows.Forms.ComboBox();
            this.txtAuthC = new System.Windows.Forms.ComboBox();
            this.txtGenre = new System.Windows.Forms.ComboBox();
            this.txtGenreC = new System.Windows.Forms.ComboBox();
            this.txtPub = new System.Windows.Forms.ComboBox();
            this.txtPubC = new System.Windows.Forms.ComboBox();
            this.btnAddCode = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.chkSta = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(203, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(191, 23);
            this.btnAdd.TabIndex = 73;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(7, 258);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(190, 23);
            this.btnSearch.TabIndex = 72;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(204, 229);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(190, 23);
            this.btnDel.TabIndex = 71;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnEdit.Location = new System.Drawing.Point(7, 229);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(190, 23);
            this.btnEdit.TabIndex = 70;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(7, 200);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(190, 23);
            this.btnNew.TabIndex = 69;
            this.btnNew.Text = "Tạo mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(204, 258);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 23);
            this.btnExit.TabIndex = 74;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(12, 94);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(48, 13);
            this.lblGenre.TabIndex = 67;
            this.lblGenre.Text = "Thể loại:";
            // 
            // lblPub
            // 
            this.lblPub.AutoSize = true;
            this.lblPub.Location = new System.Drawing.Point(12, 121);
            this.lblPub.Name = "lblPub";
            this.lblPub.Size = new System.Drawing.Size(74, 13);
            this.lblPub.TabIndex = 65;
            this.lblPub.Text = "Nhà xuất bản:";
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Location = new System.Drawing.Point(12, 67);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(46, 13);
            this.lblAuth.TabIndex = 63;
            this.lblAuth.Text = "Tác giả:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 20);
            this.txtName.TabIndex = 62;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 61;
            this.lblName.Text = "Tên sách:";
            // 
            // dtgrBook
            // 
            this.dtgrBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrBook.Location = new System.Drawing.Point(400, 12);
            this.dtgrBook.Name = "dtgrBook";
            this.dtgrBook.Size = new System.Drawing.Size(760, 269);
            this.dtgrBook.TabIndex = 57;
            // 
            // lblSta
            // 
            this.lblSta.AutoSize = true;
            this.lblSta.Location = new System.Drawing.Point(203, 148);
            this.lblSta.Name = "lblSta";
            this.lblSta.Size = new System.Drawing.Size(58, 13);
            this.lblSta.TabIndex = 75;
            this.lblSta.Text = "Trạng thái:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(12, 15);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(51, 13);
            this.lblCode.TabIndex = 77;
            this.lblCode.Text = "Mã sách:";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(108, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(248, 20);
            this.txtCode.TabIndex = 78;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(108, 145);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(89, 20);
            this.txtYear.TabIndex = 79;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 148);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(76, 13);
            this.lblYear.TabIndex = 81;
            this.lblYear.Text = "Năm xuất bản:";
            // 
            // btnAddAuth
            // 
            this.btnAddAuth.Location = new System.Drawing.Point(362, 64);
            this.btnAddAuth.Name = "btnAddAuth";
            this.btnAddAuth.Size = new System.Drawing.Size(32, 21);
            this.btnAddAuth.TabIndex = 87;
            this.btnAddAuth.Text = "+";
            this.btnAddAuth.UseVisualStyleBackColor = true;
            this.btnAddAuth.Click += new System.EventHandler(this.btnAddAuth_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(362, 91);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(32, 21);
            this.btnAddGenre.TabIndex = 88;
            this.btnAddGenre.Text = "+";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // btnAddPub
            // 
            this.btnAddPub.Location = new System.Drawing.Point(362, 118);
            this.btnAddPub.Name = "btnAddPub";
            this.btnAddPub.Size = new System.Drawing.Size(32, 21);
            this.btnAddPub.TabIndex = 89;
            this.btnAddPub.Text = "+";
            this.btnAddPub.UseVisualStyleBackColor = true;
            this.btnAddPub.Click += new System.EventHandler(this.btnAddPub_Click);
            // 
            // txtAuth
            // 
            this.txtAuth.FormattingEnabled = true;
            this.txtAuth.Location = new System.Drawing.Point(108, 64);
            this.txtAuth.Name = "txtAuth";
            this.txtAuth.Size = new System.Drawing.Size(179, 21);
            this.txtAuth.TabIndex = 90;
            this.txtAuth.SelectedIndexChanged += new System.EventHandler(this.txtAuth_SelectedIndexChanged);
            // 
            // txtAuthC
            // 
            this.txtAuthC.Enabled = false;
            this.txtAuthC.FormattingEnabled = true;
            this.txtAuthC.Location = new System.Drawing.Point(293, 64);
            this.txtAuthC.Name = "txtAuthC";
            this.txtAuthC.Size = new System.Drawing.Size(63, 21);
            this.txtAuthC.TabIndex = 92;
            this.txtAuthC.SelectedIndexChanged += new System.EventHandler(this.txtAuthC_SelectedIndexChanged);
            // 
            // txtGenre
            // 
            this.txtGenre.FormattingEnabled = true;
            this.txtGenre.Location = new System.Drawing.Point(108, 91);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(179, 21);
            this.txtGenre.TabIndex = 93;
            this.txtGenre.SelectedIndexChanged += new System.EventHandler(this.txtGenre_SelectedIndexChanged);
            // 
            // txtGenreC
            // 
            this.txtGenreC.Enabled = false;
            this.txtGenreC.FormattingEnabled = true;
            this.txtGenreC.Location = new System.Drawing.Point(293, 91);
            this.txtGenreC.Name = "txtGenreC";
            this.txtGenreC.Size = new System.Drawing.Size(63, 21);
            this.txtGenreC.TabIndex = 94;
            this.txtGenreC.SelectedIndexChanged += new System.EventHandler(this.txtGenreC_SelectedIndexChanged);
            // 
            // txtPub
            // 
            this.txtPub.FormattingEnabled = true;
            this.txtPub.Location = new System.Drawing.Point(108, 118);
            this.txtPub.Name = "txtPub";
            this.txtPub.Size = new System.Drawing.Size(179, 21);
            this.txtPub.TabIndex = 95;
            this.txtPub.SelectedIndexChanged += new System.EventHandler(this.txtPub_SelectedIndexChanged);
            // 
            // txtPubC
            // 
            this.txtPubC.Enabled = false;
            this.txtPubC.FormattingEnabled = true;
            this.txtPubC.Location = new System.Drawing.Point(293, 118);
            this.txtPubC.Name = "txtPubC";
            this.txtPubC.Size = new System.Drawing.Size(63, 21);
            this.txtPubC.TabIndex = 96;
            this.txtPubC.SelectedIndexChanged += new System.EventHandler(this.txtPubC_SelectedIndexChanged);
            // 
            // btnAddCode
            // 
            this.btnAddCode.Location = new System.Drawing.Point(362, 11);
            this.btnAddCode.Name = "btnAddCode";
            this.btnAddCode.Size = new System.Drawing.Size(32, 21);
            this.btnAddCode.TabIndex = 97;
            this.btnAddCode.Text = "+";
            this.btnAddCode.UseVisualStyleBackColor = true;
            this.btnAddCode.Click += new System.EventHandler(this.btnAddCode_Click);
            // 
            // btnReload
            // 
            this.btnReload.Enabled = false;
            this.btnReload.Location = new System.Drawing.Point(204, 171);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(190, 23);
            this.btnReload.TabIndex = 98;
            this.btnReload.Text = "Tải lại bảng";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Tổng số bản ghi:";
            // 
            // txtNum
            // 
            this.txtNum.Enabled = false;
            this.txtNum.Location = new System.Drawing.Point(108, 173);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(89, 20);
            this.txtNum.TabIndex = 99;
            // 
            // chkSta
            // 
            this.chkSta.AutoCheck = false;
            this.chkSta.AutoSize = true;
            this.chkSta.Location = new System.Drawing.Point(287, 147);
            this.chkSta.Name = "chkSta";
            this.chkSta.Size = new System.Drawing.Size(69, 17);
            this.chkSta.TabIndex = 76;
            this.chkSta.Text = "Đã mượn";
            this.chkSta.UseVisualStyleBackColor = true;
            // 
            // frmBookMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1169, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnAddCode);
            this.Controls.Add(this.txtPubC);
            this.Controls.Add(this.txtPub);
            this.Controls.Add(this.txtGenreC);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtAuthC);
            this.Controls.Add(this.txtAuth);
            this.Controls.Add(this.btnAddPub);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.btnAddAuth);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.chkSta);
            this.Controls.Add(this.lblSta);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblPub);
            this.Controls.Add(this.lblAuth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dtgrBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBookMan";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục Sách";
            this.Load += new System.EventHandler(this.frmBookMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPub;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dtgrBook;
        private System.Windows.Forms.Label lblSta;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnAddAuth;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnAddPub;
        private System.Windows.Forms.ComboBox txtAuth;
        private System.Windows.Forms.ComboBox txtAuthC;
        private System.Windows.Forms.ComboBox txtGenre;
        private System.Windows.Forms.ComboBox txtGenreC;
        private System.Windows.Forms.ComboBox txtPub;
        private System.Windows.Forms.ComboBox txtPubC;
        private System.Windows.Forms.Button btnAddCode;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.CheckBox chkSta;
    }
}