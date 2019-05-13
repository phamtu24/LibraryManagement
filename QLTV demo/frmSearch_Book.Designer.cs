namespace QLTV_demo
{
    partial class frmSearch_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch_Book));
            this.dtgrBook = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtPub = new System.Windows.Forms.TextBox();
            this.lblPub = new System.Windows.Forms.Label();
            this.txtStat = new System.Windows.Forms.ComboBox();
            this.lblStat = new System.Windows.Forms.Label();
            this.lblAuth = new System.Windows.Forms.Label();
            this.txtAuth = new System.Windows.Forms.TextBox();
            this.btnRpt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrBook
            // 
            this.dtgrBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrBook.Location = new System.Drawing.Point(337, 11);
            this.dtgrBook.Name = "dtgrBook";
            this.dtgrBook.Size = new System.Drawing.Size(760, 179);
            this.dtgrBook.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(94, 168);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(256, 168);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(12, 15);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(51, 13);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "Mã sách:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(94, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(71, 20);
            this.txtCode.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(94, 90);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(237, 20);
            this.txtGenre.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Tên sách:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(12, 93);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(48, 13);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "Thể loại:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 145);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(76, 13);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "Năm xuất bản:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(94, 142);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(71, 20);
            this.txtYear.TabIndex = 11;
            // 
            // txtPub
            // 
            this.txtPub.Location = new System.Drawing.Point(94, 116);
            this.txtPub.Name = "txtPub";
            this.txtPub.Size = new System.Drawing.Size(237, 20);
            this.txtPub.TabIndex = 10;
            // 
            // lblPub
            // 
            this.lblPub.AutoSize = true;
            this.lblPub.Location = new System.Drawing.Point(12, 119);
            this.lblPub.Name = "lblPub";
            this.lblPub.Size = new System.Drawing.Size(74, 13);
            this.lblPub.TabIndex = 9;
            this.lblPub.Text = "Nhà xuất bản:";
            // 
            // txtStat
            // 
            this.txtStat.FormattingEnabled = true;
            this.txtStat.Items.AddRange(new object[] {
            "",
            "Đã mượn",
            "Chưa mượn"});
            this.txtStat.Location = new System.Drawing.Point(235, 11);
            this.txtStat.Name = "txtStat";
            this.txtStat.Size = new System.Drawing.Size(96, 21);
            this.txtStat.TabIndex = 14;
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Location = new System.Drawing.Point(171, 14);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(58, 13);
            this.lblStat.TabIndex = 15;
            this.lblStat.Text = "Trạng thái:";
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Location = new System.Drawing.Point(12, 67);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(46, 13);
            this.lblAuth.TabIndex = 17;
            this.lblAuth.Text = "Tác giả:";
            // 
            // txtAuth
            // 
            this.txtAuth.Location = new System.Drawing.Point(94, 64);
            this.txtAuth.Name = "txtAuth";
            this.txtAuth.Size = new System.Drawing.Size(237, 20);
            this.txtAuth.TabIndex = 16;
            // 
            // btnRpt
            // 
            this.btnRpt.Location = new System.Drawing.Point(175, 168);
            this.btnRpt.Name = "btnRpt";
            this.btnRpt.Size = new System.Drawing.Size(75, 23);
            this.btnRpt.TabIndex = 18;
            this.btnRpt.Text = "Báo Cáo";
            this.btnRpt.UseVisualStyleBackColor = true;
            this.btnRpt.Click += new System.EventHandler(this.btnRpt_Click);
            // 
            // frmSearch_Book
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 202);
            this.Controls.Add(this.btnRpt);
            this.Controls.Add(this.lblAuth);
            this.Controls.Add(this.txtAuth);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.txtStat);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtPub);
            this.Controls.Add(this.lblPub);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtgrBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSearch_Book";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm Sách";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrBook;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPub;
        private System.Windows.Forms.Label lblPub;
        private System.Windows.Forms.ComboBox txtStat;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.TextBox txtAuth;
        private System.Windows.Forms.Button btnRpt;
    }
}