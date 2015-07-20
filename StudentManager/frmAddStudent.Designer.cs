namespace WindowsFormsApplication3
{
    partial class frmAddStudent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbXH = new System.Windows.Forms.TextBox();
            this.tbMM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQRMM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDZ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMZ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rbNv = new System.Windows.Forms.RadioButton();
            this.rbNan = new System.Windows.Forms.RadioButton();
            this.cbNJ = new System.Windows.Forms.ComboBox();
            this.dtpCSRQ = new System.Windows.Forms.DateTimePicker();
            this.tbnOK = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbQRMM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbMM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbXH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户注册信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpCSRQ);
            this.groupBox2.Controls.Add(this.cbNJ);
            this.groupBox2.Controls.Add(this.rbNan);
            this.groupBox2.Controls.Add(this.rbNv);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbMZ);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbDZ);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbDH);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户的基本信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // tbXH
            // 
            this.tbXH.Location = new System.Drawing.Point(73, 20);
            this.tbXH.Name = "tbXH";
            this.tbXH.Size = new System.Drawing.Size(199, 21);
            this.tbXH.TabIndex = 1;
            // 
            // tbMM
            // 
            this.tbMM.Location = new System.Drawing.Point(73, 57);
            this.tbMM.Name = "tbMM";
            this.tbMM.Size = new System.Drawing.Size(199, 21);
            this.tbMM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // tbQRMM
            // 
            this.tbQRMM.Location = new System.Drawing.Point(73, 91);
            this.tbQRMM.Name = "tbQRMM";
            this.tbQRMM.Size = new System.Drawing.Size(199, 21);
            this.tbQRMM.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认密码";
            // 
            // tbDH
            // 
            this.tbDH.Location = new System.Drawing.Point(73, 101);
            this.tbDH.Name = "tbDH";
            this.tbDH.Size = new System.Drawing.Size(199, 21);
            this.tbDH.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "性别";
            // 
            // tbDZ
            // 
            this.tbDZ.Location = new System.Drawing.Point(73, 130);
            this.tbDZ.Name = "tbDZ";
            this.tbDZ.Size = new System.Drawing.Size(199, 21);
            this.tbDZ.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "年级";
            // 
            // tbMZ
            // 
            this.tbMZ.Location = new System.Drawing.Point(73, 20);
            this.tbMZ.Name = "tbMZ";
            this.tbMZ.Size = new System.Drawing.Size(199, 21);
            this.tbMZ.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "姓名";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(73, 188);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(199, 21);
            this.tbEmail.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "电话";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "出生日期";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "地址";
            // 
            // rbNv
            // 
            this.rbNv.AutoSize = true;
            this.rbNv.Checked = true;
            this.rbNv.Location = new System.Drawing.Point(73, 49);
            this.rbNv.Name = "rbNv";
            this.rbNv.Size = new System.Drawing.Size(35, 16);
            this.rbNv.TabIndex = 13;
            this.rbNv.TabStop = true;
            this.rbNv.Text = "女";
            this.rbNv.UseVisualStyleBackColor = true;
            // 
            // rbNan
            // 
            this.rbNan.AutoSize = true;
            this.rbNan.Location = new System.Drawing.Point(156, 49);
            this.rbNan.Name = "rbNan";
            this.rbNan.Size = new System.Drawing.Size(35, 16);
            this.rbNan.TabIndex = 14;
            this.rbNan.TabStop = true;
            this.rbNan.Text = "男";
            this.rbNan.UseVisualStyleBackColor = true;
            // 
            // cbNJ
            // 
            this.cbNJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNJ.FormattingEnabled = true;
            this.cbNJ.Items.AddRange(new object[] {
            "一年级",
            "二年级",
            "三年级",
            "四年级"});
            this.cbNJ.Location = new System.Drawing.Point(73, 73);
            this.cbNJ.Name = "cbNJ";
            this.cbNJ.Size = new System.Drawing.Size(199, 20);
            this.cbNJ.TabIndex = 15;
            // 
            // dtpCSRQ
            // 
            this.dtpCSRQ.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCSRQ.Location = new System.Drawing.Point(73, 159);
            this.dtpCSRQ.Name = "dtpCSRQ";
            this.dtpCSRQ.Size = new System.Drawing.Size(200, 21);
            this.dtpCSRQ.TabIndex = 16;
            // 
            // tbnOK
            // 
            this.tbnOK.Location = new System.Drawing.Point(141, 384);
            this.tbnOK.Name = "tbnOK";
            this.tbnOK.Size = new System.Drawing.Size(75, 23);
            this.tbnOK.TabIndex = 2;
            this.tbnOK.Text = "确定";
            this.tbnOK.UseVisualStyleBackColor = true;
            this.tbnOK.Click += new System.EventHandler(this.tbnOK_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(227, 384);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 418);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加学生";
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbQRMM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.Button tbnOK;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbXH;
    }
}