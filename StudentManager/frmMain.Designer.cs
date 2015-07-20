namespace WindowsFormsApplication3
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("饿死如果他反而给他发", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("而提高", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("担任过", 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("额的个人", 3);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生管理AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.修改学生EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miEnquryStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.密码修改PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddStudent = new System.Windows.Forms.ToolStripButton();
            this.tsbAlterStudent = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAlterPWD = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvStudents = new System.Windows.Forms.ListView();
            this.ilLarge = new System.Windows.Forms.ImageList(this.components);
            this.ilSmall = new System.Windows.Forms.ImageList(this.components);
            this.tbXH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCSRQ = new System.Windows.Forms.DateTimePicker();
            this.cbNJ = new System.Windows.Forms.ComboBox();
            this.rbNan = new System.Windows.Forms.RadioButton();
            this.rbNv = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMZ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDZ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生管理AToolStripMenuItem,
            this.系统管理SToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生管理AToolStripMenuItem
            // 
            this.学生管理AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddStudent,
            this.修改学生EToolStripMenuItem,
            this.miEnquryStudent,
            this.miExit});
            this.学生管理AToolStripMenuItem.Name = "学生管理AToolStripMenuItem";
            this.学生管理AToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.学生管理AToolStripMenuItem.Text = "学生管理(&A)";
            // 
            // miAddStudent
            // 
            this.miAddStudent.Name = "miAddStudent";
            this.miAddStudent.Size = new System.Drawing.Size(136, 22);
            this.miAddStudent.Tag = "1";
            this.miAddStudent.Text = "添加学生(&A)";
            this.miAddStudent.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 修改学生EToolStripMenuItem
            // 
            this.修改学生EToolStripMenuItem.Name = "修改学生EToolStripMenuItem";
            this.修改学生EToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.修改学生EToolStripMenuItem.Tag = "2";
            this.修改学生EToolStripMenuItem.Text = "修改学生(&E)";
            this.修改学生EToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // miEnquryStudent
            // 
            this.miEnquryStudent.Name = "miEnquryStudent";
            this.miEnquryStudent.Size = new System.Drawing.Size(136, 22);
            this.miEnquryStudent.Tag = "4";
            this.miEnquryStudent.Text = "查询学生";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(136, 22);
            this.miExit.Tag = "9";
            this.miExit.Text = "退出(&X)";
            this.miExit.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 系统管理SToolStripMenuItem
            // 
            this.系统管理SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.密码修改PToolStripMenuItem});
            this.系统管理SToolStripMenuItem.Name = "系统管理SToolStripMenuItem";
            this.系统管理SToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.系统管理SToolStripMenuItem.Text = "系统管理(&S)";
            // 
            // 密码修改PToolStripMenuItem
            // 
            this.密码修改PToolStripMenuItem.Name = "密码修改PToolStripMenuItem";
            this.密码修改PToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.密码修改PToolStripMenuItem.Tag = "3";
            this.密码修改PToolStripMenuItem.Text = "密码修改(&P)";
            this.密码修改PToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddStudent,
            this.tsbAlterStudent,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.tsbAlterPWD,
            this.toolStripSeparator2,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(556, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip_ItemClicked);
            // 
            // tsbAddStudent
            // 
            this.tsbAddStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddStudent.Image")));
            this.tsbAddStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddStudent.Name = "tsbAddStudent";
            this.tsbAddStudent.Size = new System.Drawing.Size(23, 22);
            this.tsbAddStudent.Tag = "1";
            this.tsbAddStudent.ToolTipText = "添加学生信息";
            // 
            // tsbAlterStudent
            // 
            this.tsbAlterStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAlterStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlterStudent.Image")));
            this.tsbAlterStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlterStudent.Name = "tsbAlterStudent";
            this.tsbAlterStudent.Size = new System.Drawing.Size(23, 22);
            this.tsbAlterStudent.Tag = "2";
            this.tsbAlterStudent.Text = "toolStripButton1";
            this.tsbAlterStudent.ToolTipText = "修改学生信息";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Tag = "4";
            this.toolStripButton1.ToolTipText = "查询学生";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAlterPWD
            // 
            this.tsbAlterPWD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAlterPWD.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlterPWD.Image")));
            this.tsbAlterPWD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlterPWD.Name = "tsbAlterPWD";
            this.tsbAlterPWD.Size = new System.Drawing.Size(23, 22);
            this.tsbAlterPWD.Tag = "3";
            this.tsbAlterPWD.Text = "toolStripButton1";
            this.tsbAlterPWD.ToolTipText = "修改用户密码";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExit
            // 
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(23, 22);
            this.tsbExit.Tag = "9";
            this.tsbExit.Text = "toolStripButton1";
            this.tsbExit.ToolTipText = "退出";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(556, 405);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(5, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvStudents);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtpCSRQ);
            this.splitContainer1.Panel2.Controls.Add(this.cbNJ);
            this.splitContainer1.Panel2.Controls.Add(this.rbNan);
            this.splitContainer1.Panel2.Controls.Add(this.rbNv);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.tbEmail);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.tbMZ);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.tbDZ);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.tbDH);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.tbXH);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(546, 395);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.TabIndex = 0;
            // 
            // lvStudents
            // 
            this.lvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvStudents.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lvStudents.LargeImageList = this.ilLarge;
            this.lvStudents.Location = new System.Drawing.Point(0, 0);
            this.lvStudents.MultiSelect = false;
            this.lvStudents.Name = "lvStudents";
            this.lvStudents.Size = new System.Drawing.Size(182, 395);
            this.lvStudents.TabIndex = 4;
            this.lvStudents.UseCompatibleStateImageBehavior = false;
            this.lvStudents.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvStudents_ItemSelectionChanged);
            this.lvStudents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvStudents_KeyDown);
            // 
            // ilLarge
            // 
            this.ilLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilLarge.ImageStream")));
            this.ilLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.ilLarge.Images.SetKeyName(0, "zs");
            this.ilLarge.Images.SetKeyName(1, "ls");
            this.ilLarge.Images.SetKeyName(2, "angel.png");
            this.ilLarge.Images.SetKeyName(3, "AnonymousUser.png");
            this.ilLarge.Images.SetKeyName(4, "AppMenuClose.png");
            this.ilLarge.Images.SetKeyName(5, "AppMenuMemoStyle.PNG");
            this.ilLarge.Images.SetKeyName(6, "AppMenuMove.png");
            this.ilLarge.Images.SetKeyName(7, "AppMenuNewMailMessage.png");
            this.ilLarge.Images.SetKeyName(8, "AppMenuPrint.png");
            this.ilLarge.Images.SetKeyName(9, "AppMenuQuickPrint.PNG");
            this.ilLarge.Images.SetKeyName(10, "AppMenuSave.png");
            this.ilLarge.Images.SetKeyName(11, "AppMenuSaveAs.png");
            this.ilLarge.Images.SetKeyName(12, "ChangeStyles.png");
            this.ilLarge.Images.SetKeyName(13, "ChartLarge.png");
            this.ilLarge.Images.SetKeyName(14, "ClipArtLarge.png");
            this.ilLarge.Images.SetKeyName(15, "ClipboardPaste.png");
            // 
            // ilSmall
            // 
            this.ilSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilSmall.ImageSize = new System.Drawing.Size(16, 16);
            this.ilSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tbXH
            // 
            this.tbXH.Location = new System.Drawing.Point(95, 31);
            this.tbXH.Name = "tbXH";
            this.tbXH.ReadOnly = true;
            this.tbXH.Size = new System.Drawing.Size(199, 21);
            this.tbXH.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "学号";
            // 
            // dtpCSRQ
            // 
            this.dtpCSRQ.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCSRQ.Location = new System.Drawing.Point(95, 277);
            this.dtpCSRQ.Name = "dtpCSRQ";
            this.dtpCSRQ.Size = new System.Drawing.Size(200, 21);
            this.dtpCSRQ.TabIndex = 31;
            // 
            // cbNJ
            // 
            this.cbNJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNJ.Enabled = false;
            this.cbNJ.FormattingEnabled = true;
            this.cbNJ.Items.AddRange(new object[] {
            "一年级",
            "二年级",
            "三年级",
            "四年级"});
            this.cbNJ.Location = new System.Drawing.Point(95, 152);
            this.cbNJ.Name = "cbNJ";
            this.cbNJ.Size = new System.Drawing.Size(199, 20);
            this.cbNJ.TabIndex = 30;
            // 
            // rbNan
            // 
            this.rbNan.AutoSize = true;
            this.rbNan.Location = new System.Drawing.Point(178, 115);
            this.rbNan.Name = "rbNan";
            this.rbNan.Size = new System.Drawing.Size(35, 16);
            this.rbNan.TabIndex = 29;
            this.rbNan.TabStop = true;
            this.rbNan.Text = "男";
            this.rbNan.UseVisualStyleBackColor = true;
            // 
            // rbNv
            // 
            this.rbNv.AutoSize = true;
            this.rbNv.Checked = true;
            this.rbNv.Location = new System.Drawing.Point(95, 115);
            this.rbNv.Name = "rbNv";
            this.rbNv.Size = new System.Drawing.Size(35, 16);
            this.rbNv.TabIndex = 28;
            this.rbNv.TabStop = true;
            this.rbNv.Text = "女";
            this.rbNv.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "地址";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "出生日期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(95, 319);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(199, 21);
            this.tbEmail.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "电话";
            // 
            // tbMZ
            // 
            this.tbMZ.Location = new System.Drawing.Point(95, 73);
            this.tbMZ.Name = "tbMZ";
            this.tbMZ.ReadOnly = true;
            this.tbMZ.Size = new System.Drawing.Size(199, 21);
            this.tbMZ.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "姓名";
            // 
            // tbDZ
            // 
            this.tbDZ.Location = new System.Drawing.Point(95, 235);
            this.tbDZ.Name = "tbDZ";
            this.tbDZ.ReadOnly = true;
            this.tbDZ.Size = new System.Drawing.Size(199, 21);
            this.tbDZ.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "年级";
            // 
            // tbDH
            // 
            this.tbDH.Location = new System.Drawing.Point(95, 193);
            this.tbDH.Name = "tbDH";
            this.tbDH.ReadOnly = true;
            this.tbDH.Size = new System.Drawing.Size(199, 21);
            this.tbDH.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "性别";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 454);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生管理AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAddStudent;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddStudent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripMenuItem 修改学生EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 密码修改PToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvStudents;
        private System.Windows.Forms.ImageList ilLarge;
        private System.Windows.Forms.ImageList ilSmall;
        private System.Windows.Forms.ToolStripButton tsbAlterStudent;
        private System.Windows.Forms.ToolStripButton tsbAlterPWD;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem miEnquryStudent;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DateTimePicker dtpCSRQ;
        private System.Windows.Forms.ComboBox cbNJ;
        private System.Windows.Forms.RadioButton rbNan;
        private System.Windows.Forms.RadioButton rbNv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMZ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbXH;
        private System.Windows.Forms.Label label1;
    }
}

