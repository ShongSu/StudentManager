using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Water.Utilities.Data;
using System.Data.Common;

namespace WindowsFormsApplication3
{
    public partial class frmAddStudent : Form
    {
        private DataRow _student = null;
        public string XH { get { return tbXH.Text.Trim(); } }
        public string MM { get { return tbMM.Text.Trim(); } }
        public string XM { get { return tbMZ.Text.Trim(); } }
        public int XB { get { return rbNv.Checked ? 0 : 1; } }
        public int NJ { get { return cbNJ.SelectedIndex; } }
        public string DH { get { return tbDH.Text.Trim(); } }
        public string DZ { get { return tbDZ.Text.Trim(); } }
        public string CSRQ { get { return dtpCSRQ.Value.ToShortDateString(); } }
        public string Email { get { return tbEmail.Text.Trim(); } }

        public frmAddStudent()
        {
            InitializeComponent();
        }

        public frmAddStudent(DataRow dr, bool edit=false)
            : this()
        {
            if (edit)
            {
                this.Text = "修改学生";
                _student = dr;
            }
            else
            {
                this.Text = "添加学生";
            }
            tbXH.Enabled = !edit;
        }

        private void tbnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbXH.Text.Trim()) ||
                string.IsNullOrWhiteSpace(tbMZ.Text.Trim()))
            {
                MessageBox.Show("学号或者姓名不能为空！");

                return;
            }

            if (tbMM.Text.Trim() != tbQRMM.Text.Trim())
            {
                MessageBox.Show("密码与确认密码不一致！");

                return;
            }


            this.DialogResult = DialogResult.OK;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls(this, _student == null ? null : tbXH);
        }

        private void ClearControls(Control c, params Control[] cs)
        {
            if (c.Controls.Count > 0)
            {
                foreach (Control item in c.Controls)
                {
                    ClearControls(item, cs);
                }
            }
            else
            {
                IEnumerable<Control> value = from v in cs
                                             where v == c
                                             select v;
                if (value != null && value.Count() == 0)
                {
                    if (!(c is GroupBox) && !(c is Form) &&
                    !(c is DateTimePicker) && !(c is RadioButton) &&
                    !(c is Button) && !(c is Label) && !(c is ComboBox))
                    {
                        c.Text = "";
                    }
                    else if (c is DateTimePicker)
                        ((DateTimePicker)c).Value = DateTime.Now;
                    else if (c is ComboBox)
                    {
                        if (cbNJ.Items.Count > 0)
                        {
                            cbNJ.SelectedIndex = 0;
                        }
                    }
                    else if (c is RadioButton)
                        rbNv.Checked = true;
                }
            }
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            using (SqlServerHelper ssh = new SqlServerHelper( 
                DataConst.dataBase, DataConst.userName, DataConst.password))
            {
                string sql = "SELECT * FROM Grade";
                DbDataReader ddr = ssh.ExecuteReader(sql);

                cbNJ.Items.Clear();
                while (ddr.Read())
                {
                    cbNJ.Items.Add(ddr["Name"]);
                }
            } 
            
            if (cbNJ.Items.Count > 0)
            {
                cbNJ.SelectedIndex = 0;
            }

            if (_student != null)
            {
                tbXH.Text = GetFieldValue<string>(_student, "XH");
                tbMM.Text = GetFieldValue<string>(_student, "MM");
                tbMZ.Text = GetFieldValue<string>(_student, "XM");
                rbNv.Checked = GetFieldValue<bool>(_student, "XB");
                cbNJ.SelectedIndex = GetFieldValue<int>(_student, "NJ");
                tbDH.Text = GetFieldValue<string>(_student, "DH");
                tbDZ.Text = GetFieldValue<string>(_student, "DZ");
                dtpCSRQ.Value = GetFieldValue<DateTime>(_student, "CSRQ", 
                    DateTime.Now);
                tbEmail.Text = GetFieldValue<string>(_student, "Email");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr"></param>
        /// <param name="fieldName"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        private T GetFieldValue<T>(DataRow dr, string fieldName, 
            T defaultValue = default(T))
        {
            T ret = defaultValue;

            try
            {
                object obj = dr.Field<object>(fieldName);
                if (obj != null)
                    ret = (T)obj;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return ret;
        }
    }
}
