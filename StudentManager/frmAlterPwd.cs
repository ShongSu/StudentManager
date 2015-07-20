using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Water.Utilities.Data;

namespace WindowsFormsApplication3
{
    public partial class frmAlterPwd : Form
    {
        private string m_UserName;

        public frmAlterPwd()
        {
            InitializeComponent();
        }

        public frmAlterPwd(string username)
            : this()
        {
            m_UserName = username;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbNewPwd.Text.Trim() != tbConformPwd.Text.Trim())
            {
                MessageBox.Show("新密码与确认新密码不一致！");

                return;
            }

            string sql = "UPDATE [User] SET Password = '{0}' WHERE Name = '{1}'";
            sql = string.Format(sql, tbNewPwd.Text, m_UserName);
            using (SqlServerHelper ssh = new SqlServerHelper(
                DataConst.dataBase, DataConst.userName, DataConst.password))
            {
                object o = ssh.ExecuteNonQuery(sql);

                if ((int)o == 0)
                {
                    MessageBox.Show(string.Format("用户 {0} 不存在！",
                        m_UserName), "用户密码修改提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(string.Format("用户 {0} 的密码修改成功！",
                        m_UserName), "用户密码修改提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
