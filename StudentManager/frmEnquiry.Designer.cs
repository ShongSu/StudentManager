namespace WindowsFormsApplication3
{
    partial class frmEnquiry
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
            this.pEnquiry = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gbEnquiry = new System.Windows.Forms.GroupBox();
            this.chkEnquiry = new System.Windows.Forms.CheckBox();
            this.cbOption = new System.Windows.Forms.ComboBox();
            this.labMaxValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaxValue = new System.Windows.Forms.TextBox();
            this.cbFieldNames = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labMinValue = new System.Windows.Forms.Label();
            this.tbMinValue = new System.Windows.Forms.TextBox();
            this.btnEnquiry = new System.Windows.Forms.Button();
            this.dgvEnquiry = new System.Windows.Forms.DataGridView();
            this.pEnquiry.SuspendLayout();
            this.gbEnquiry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnquiry)).BeginInit();
            this.SuspendLayout();
            // 
            // pEnquiry
            // 
            this.pEnquiry.Controls.Add(this.btnPrint);
            this.pEnquiry.Controls.Add(this.gbEnquiry);
            this.pEnquiry.Controls.Add(this.btnEnquiry);
            this.pEnquiry.Dock = System.Windows.Forms.DockStyle.Top;
            this.pEnquiry.Location = new System.Drawing.Point(5, 5);
            this.pEnquiry.Name = "pEnquiry";
            this.pEnquiry.Padding = new System.Windows.Forms.Padding(5);
            this.pEnquiry.Size = new System.Drawing.Size(491, 125);
            this.pEnquiry.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(422, 69);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(58, 33);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gbEnquiry
            // 
            this.gbEnquiry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbEnquiry.Controls.Add(this.chkEnquiry);
            this.gbEnquiry.Controls.Add(this.cbOption);
            this.gbEnquiry.Controls.Add(this.labMaxValue);
            this.gbEnquiry.Controls.Add(this.label1);
            this.gbEnquiry.Controls.Add(this.tbMaxValue);
            this.gbEnquiry.Controls.Add(this.cbFieldNames);
            this.gbEnquiry.Controls.Add(this.label2);
            this.gbEnquiry.Controls.Add(this.labMinValue);
            this.gbEnquiry.Controls.Add(this.tbMinValue);
            this.gbEnquiry.Location = new System.Drawing.Point(19, 24);
            this.gbEnquiry.Name = "gbEnquiry";
            this.gbEnquiry.Size = new System.Drawing.Size(386, 86);
            this.gbEnquiry.TabIndex = 9;
            this.gbEnquiry.TabStop = false;
            // 
            // chkEnquiry
            // 
            this.chkEnquiry.AutoSize = true;
            this.chkEnquiry.Location = new System.Drawing.Point(12, 0);
            this.chkEnquiry.Name = "chkEnquiry";
            this.chkEnquiry.Size = new System.Drawing.Size(72, 16);
            this.chkEnquiry.TabIndex = 10;
            this.chkEnquiry.Text = "查询全部";
            this.chkEnquiry.UseVisualStyleBackColor = true;
            // 
            // cbOption
            // 
            this.cbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOption.FormattingEnabled = true;
            this.cbOption.Items.AddRange(new object[] {
            "大于",
            "小于",
            "等于",
            "大于等于",
            "小于等于",
            "类似",
            "介于"});
            this.cbOption.Location = new System.Drawing.Point(139, 42);
            this.cbOption.Name = "cbOption";
            this.cbOption.Size = new System.Drawing.Size(106, 20);
            this.cbOption.TabIndex = 3;
            this.cbOption.SelectedIndexChanged += new System.EventHandler(this.cbOption_SelectedIndexChanged);
            // 
            // labMaxValue
            // 
            this.labMaxValue.AutoSize = true;
            this.labMaxValue.Location = new System.Drawing.Point(263, 76);
            this.labMaxValue.Name = "labMaxValue";
            this.labMaxValue.Size = new System.Drawing.Size(41, 12);
            this.labMaxValue.TabIndex = 8;
            this.labMaxValue.Text = "最大值";
            this.labMaxValue.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "字段名称";
            // 
            // tbMaxValue
            // 
            this.tbMaxValue.Location = new System.Drawing.Point(265, 91);
            this.tbMaxValue.Name = "tbMaxValue";
            this.tbMaxValue.Size = new System.Drawing.Size(103, 21);
            this.tbMaxValue.TabIndex = 7;
            this.tbMaxValue.Visible = false;
            // 
            // cbFieldNames
            // 
            this.cbFieldNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFieldNames.FormattingEnabled = true;
            this.cbFieldNames.Location = new System.Drawing.Point(12, 42);
            this.cbFieldNames.Name = "cbFieldNames";
            this.cbFieldNames.Size = new System.Drawing.Size(106, 20);
            this.cbFieldNames.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "条件";
            // 
            // labMinValue
            // 
            this.labMinValue.AutoSize = true;
            this.labMinValue.Location = new System.Drawing.Point(263, 26);
            this.labMinValue.Name = "labMinValue";
            this.labMinValue.Size = new System.Drawing.Size(17, 12);
            this.labMinValue.TabIndex = 5;
            this.labMinValue.Text = "值";
            // 
            // tbMinValue
            // 
            this.tbMinValue.Location = new System.Drawing.Point(265, 41);
            this.tbMinValue.Name = "tbMinValue";
            this.tbMinValue.Size = new System.Drawing.Size(103, 21);
            this.tbMinValue.TabIndex = 4;
            // 
            // btnEnquiry
            // 
            this.btnEnquiry.Location = new System.Drawing.Point(422, 30);
            this.btnEnquiry.Name = "btnEnquiry";
            this.btnEnquiry.Size = new System.Drawing.Size(58, 33);
            this.btnEnquiry.TabIndex = 6;
            this.btnEnquiry.Text = "查询";
            this.btnEnquiry.UseVisualStyleBackColor = true;
            this.btnEnquiry.Click += new System.EventHandler(this.btnEnquiry_Click);
            // 
            // dgvEnquiry
            // 
            this.dgvEnquiry.AllowDrop = true;
            this.dgvEnquiry.AllowUserToAddRows = false;
            this.dgvEnquiry.AllowUserToDeleteRows = false;
            this.dgvEnquiry.AllowUserToOrderColumns = true;
            this.dgvEnquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnquiry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnquiry.Location = new System.Drawing.Point(5, 130);
            this.dgvEnquiry.Name = "dgvEnquiry";
            this.dgvEnquiry.ReadOnly = true;
            this.dgvEnquiry.RowTemplate.Height = 23;
            this.dgvEnquiry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnquiry.Size = new System.Drawing.Size(491, 218);
            this.dgvEnquiry.TabIndex = 2;
            this.dgvEnquiry.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEnquiry_CellFormatting);
            // 
            // frmEnquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 353);
            this.Controls.Add(this.dgvEnquiry);
            this.Controls.Add(this.pEnquiry);
            this.Name = "frmEnquiry";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息查询";
            this.Load += new System.EventHandler(this.frmEnquiry_Load);
            this.pEnquiry.ResumeLayout(false);
            this.gbEnquiry.ResumeLayout(false);
            this.gbEnquiry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnquiry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pEnquiry;
        private System.Windows.Forms.ComboBox cbOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFieldNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labMinValue;
        private System.Windows.Forms.TextBox tbMinValue;
        private System.Windows.Forms.Button btnEnquiry;
        private System.Windows.Forms.DataGridView dgvEnquiry;
        private System.Windows.Forms.Label labMaxValue;
        private System.Windows.Forms.TextBox tbMaxValue;
        private System.Windows.Forms.GroupBox gbEnquiry;
        private System.Windows.Forms.CheckBox chkEnquiry;
        private System.Windows.Forms.Button btnPrint;

    }
}