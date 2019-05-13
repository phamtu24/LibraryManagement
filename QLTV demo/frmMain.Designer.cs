namespace QLTV_demo
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnHome = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLend = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHome,
            this.btnList,
            this.btnSearch,
            this.btnLend,
            this.btnHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnHome
            // 
            this.btnHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.btnLogin,
            this.toolStripMenuItem2,
            this.btnLogout,
            this.toolStripMenuItem12,
            this.btnExit});
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Image = global::QLTV_demo.Properties.Resources.WelligentHome;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(68, 20);
            this.btnHome.Text = "Home";
            this.btnHome.DropDownClosed += new System.EventHandler(this.btnHome_DropDownClosed);
            this.btnHome.DropDownOpened += new System.EventHandler(this.btnHome_DropDownOpened);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 6);
            // 
            // btnLogin
            // 
            this.btnLogin.Image = global::QLTV_demo.Properties.Resources.login;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 22);
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(129, 6);
            // 
            // btnLogout
            // 
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(132, 22);
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(129, 6);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::QLTV_demo.Properties.Resources._126_512;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 22);
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnList
            // 
            this.btnList.Enabled = false;
            this.btnList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnList.Image = global::QLTV_demo.Properties.Resources.apply;
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(118, 20);
            this.btnList.Text = "Danh mục Sách";
            this.btnList.DropDownClosed += new System.EventHandler(this.btnList_DropDownClosed);
            this.btnList.DropDownOpened += new System.EventHandler(this.btnList_DropDownOpened);
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Image = global::QLTV_demo.Properties.Resources._512px_Closed_Book_Icon;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 20);
            this.btnSearch.Text = "Tìm kiếm Sách";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLend
            // 
            this.btnLend.Enabled = false;
            this.btnLend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLend.Image = global::QLTV_demo.Properties.Resources.borrow_icon;
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(135, 20);
            this.btnLend.Text = "Quản lí mượn sách";
            this.btnLend.Click += new System.EventHandler(this.btnLend_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHelp.Image = global::QLTV_demo.Properties.Resources.help;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(79, 20);
            this.btnHelp.Text = "Trợ giúp";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 636);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện";
            this.Shown += new System.EventHandler(this.btnLogin_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnHome;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnList;
        private System.Windows.Forms.ToolStripMenuItem btnSearch;
        private System.Windows.Forms.ToolStripMenuItem btnHelp;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem btnLend;
    }
}

