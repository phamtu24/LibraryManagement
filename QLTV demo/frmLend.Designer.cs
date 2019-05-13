namespace QLTV_demo
{
    partial class frmLend
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
            this.dtgrLend = new System.Windows.Forms.DataGridView();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateA = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.ComboBox();
            this.txtCode = new System.Windows.Forms.ComboBox();
            this.lblReader = new System.Windows.Forms.Label();
            this.txtReader = new System.Windows.Forms.ComboBox();
            this.txtReaderC = new System.Windows.Forms.ComboBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.dateB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbD = new System.Windows.Forms.ComboBox();
            this.btnAddCode = new System.Windows.Forms.Button();
            this.dateC = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrLend)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrLend
            // 
            this.dtgrLend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrLend.Location = new System.Drawing.Point(404, 12);
            this.dtgrLend.Name = "dtgrLend";
            this.dtgrLend.Size = new System.Drawing.Size(770, 246);
            this.dtgrLend.TabIndex = 0;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(16, 15);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(51, 13);
            this.lblCode.TabIndex = 85;
            this.lblCode.Text = "Mã sách:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(207, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(191, 23);
            this.btnAdd.TabIndex = 83;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(208, 206);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(190, 23);
            this.btnDel.TabIndex = 82;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(11, 177);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(190, 23);
            this.btnNew.TabIndex = 81;
            this.btnNew.Text = "Tạo mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(208, 235);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 23);
            this.btnExit.TabIndex = 84;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 79;
            this.lblName.Text = "Tên sách:";
            // 
            // btnReload
            // 
            this.btnReload.Enabled = false;
            this.btnReload.Location = new System.Drawing.Point(11, 235);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(190, 23);
            this.btnReload.TabIndex = 100;
            this.btnReload.Text = "Tải lại bảng";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(11, 206);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(190, 23);
            this.btnEdit.TabIndex = 99;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(16, 67);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 13);
            this.lblDate.TabIndex = 101;
            this.lblDate.Text = "Ngày mượn:";
            // 
            // dateA
            // 
            this.dateA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateA.Location = new System.Drawing.Point(91, 64);
            this.dateA.Name = "dateA";
            this.dateA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateA.Size = new System.Drawing.Size(98, 20);
            this.dateA.TabIndex = 102;
            this.dateA.ValueChanged += new System.EventHandler(this.dateA_ValueChanged);
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtName.FormattingEnabled = true;
            this.txtName.Location = new System.Drawing.Point(91, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(307, 21);
            this.txtName.TabIndex = 104;
            this.txtName.SelectedIndexChanged += new System.EventHandler(this.txtName_SelectedIndexChanged);
            // 
            // txtCode
            // 
            this.txtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCode.FormattingEnabled = true;
            this.txtCode.Location = new System.Drawing.Point(91, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(121, 21);
            this.txtCode.TabIndex = 105;
            // 
            // lblReader
            // 
            this.lblReader.AutoSize = true;
            this.lblReader.Location = new System.Drawing.Point(16, 127);
            this.lblReader.Name = "lblReader";
            this.lblReader.Size = new System.Drawing.Size(69, 13);
            this.lblReader.TabIndex = 87;
            this.lblReader.Text = "Tên Độc giả:";
            // 
            // txtReader
            // 
            this.txtReader.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtReader.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtReader.FormattingEnabled = true;
            this.txtReader.Location = new System.Drawing.Point(91, 124);
            this.txtReader.Name = "txtReader";
            this.txtReader.Size = new System.Drawing.Size(174, 21);
            this.txtReader.TabIndex = 103;
            this.txtReader.SelectedIndexChanged += new System.EventHandler(this.txtReader_SelectedIndexChanged);
            // 
            // txtReaderC
            // 
            this.txtReaderC.FormattingEnabled = true;
            this.txtReaderC.Location = new System.Drawing.Point(270, 124);
            this.txtReaderC.Name = "txtReaderC";
            this.txtReaderC.Size = new System.Drawing.Size(88, 21);
            this.txtReaderC.TabIndex = 106;
            this.txtReaderC.SelectedIndexChanged += new System.EventHandler(this.txtReaderC_SelectedIndexChanged);
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(16, 154);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(57, 13);
            this.lblBirth.TabIndex = 107;
            this.lblBirth.Text = "Ngày sinh:";
            // 
            // dateB
            // 
            this.dateB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateB.Location = new System.Drawing.Point(91, 151);
            this.dateB.Name = "dateB";
            this.dateB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateB.Size = new System.Drawing.Size(98, 20);
            this.dateB.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "----------Thông tin Độc giả: ----------------------------------------------------" +
    "-----------------------------------";
            // 
            // cbD
            // 
            this.cbD.FormattingEnabled = true;
            this.cbD.Location = new System.Drawing.Point(299, 151);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(97, 21);
            this.cbD.TabIndex = 114;
            this.cbD.Visible = false;
            // 
            // btnAddCode
            // 
            this.btnAddCode.Location = new System.Drawing.Point(364, 124);
            this.btnAddCode.Name = "btnAddCode";
            this.btnAddCode.Size = new System.Drawing.Size(32, 21);
            this.btnAddCode.TabIndex = 115;
            this.btnAddCode.Text = "+";
            this.btnAddCode.UseVisualStyleBackColor = true;
            this.btnAddCode.Click += new System.EventHandler(this.btnAddCode_Click);
            // 
            // dateC
            // 
            this.dateC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateC.Location = new System.Drawing.Point(298, 64);
            this.dateC.Name = "dateC";
            this.dateC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateC.Size = new System.Drawing.Size(98, 20);
            this.dateC.TabIndex = 117;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 116;
            this.label2.Text = "Ngày trả:";
            // 
            // frmLend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 266);
            this.Controls.Add(this.dateC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddCode);
            this.Controls.Add(this.cbD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateB);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.txtReaderC);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtReader);
            this.Controls.Add(this.dateA);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblReader);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dtgrLend);
            this.Name = "frmLend";
            this.Text = "frmLend";
            this.Load += new System.EventHandler(this.frmLend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrLend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrLend;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateA;
        private System.Windows.Forms.ComboBox txtName;
        private System.Windows.Forms.ComboBox txtCode;
        private System.Windows.Forms.Label lblReader;
        private System.Windows.Forms.ComboBox txtReader;
        private System.Windows.Forms.ComboBox txtReaderC;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.DateTimePicker dateB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbD;
        private System.Windows.Forms.Button btnAddCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateC;
    }
}