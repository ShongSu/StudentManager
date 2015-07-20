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

namespace WindowsFormsApplication3
{
    public partial class frmLogin : Form
    {
        public string UserName { get { return tbXM.Text.Trim(); } }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!IsNameValid())
            {
                MessageBox.Show("用户名不能为空或空格！");

                return;
            }
            string sql = "SELECT COUNT(*) FROM [User] WHERE [Name] = '{0}' and [Password] = '{1}'";
            sql = string.Format(sql, tbXM.Text, tbMM.Text);
            using (SqlServerHelper ssh = new SqlServerHelper(DataConst.dataBase, DataConst.userName, DataConst.password))
            {
                object o = ssh.ExecuteScalar(sql);

                if ((int)o == 0)
                {
                    MessageBox.Show(string.Format("用户 {0} 不存在\r\n或密码错误！",
                        tbXM.Text), "用户登录信息出错提示", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (IsNameValid())
            {
                // Clear the error, if any, in the error provider.

                ep.SetError(this.tbXM, String.Empty);
            }
            else
            {
                // Set the error if the name is not valid.

                ep.SetError(this.tbXM, "用户名不能为空或空格！");
            }

        }

        private bool IsNameValid()
        {
            bool ret = false;

            try
            {
                tbXM.Text = tbXM.Text.Trim(' ').Trim('　');
  
                if (tbXM.Text != "")
                    ret = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return ret;
        }


    }
}
