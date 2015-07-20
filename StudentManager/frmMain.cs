using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Water.Utilities.Data;
using System.IO;
using Languages;

namespace WindowsFormsApplication3
{
    public partial class frmMain : Form
    {
        private string m_UserName;
        private DataRow _selectedDataRow = null;

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string username)
            : this()
        {
            m_UserName = username;

            Text = Language.GetString("XH");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Students";
            using (SqlServerHelper ssh = new SqlServerHelper(
                DataConst.dataBase, DataConst.userName, DataConst.password))
            {
                DataSet ds = ssh.ExecuteQuery(sql);

                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    int index = 0;
                    lvStudents.Items.Clear();
                    foreach (DataRow dr in dt.AsEnumerable())
                    {
                        ListViewItem lvi = new ListViewItem(dr.Field<string>("XM"));

                        //byte[] buff = (byte[])dr["Image"];
                        //MemoryStream ms = new MemoryStream(buff);
                        //ms.Position = 0;
                        //Image ret = System.Drawing.Image.FromStream(ms, true);
                        //ilLarge.Images.Add("zs", ret);

                        lvi.ImageIndex = index;

                        lvi.Tag = dr;

                        index++;

                        lvStudents.Items.Add(lvi);
                    }
                }
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否真的退出！", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {

            }
            else
                e.Cancel = true;
        }

        #region 功能按钮或菜单事件
        private void ToolStripMenuItem_Click(object sender,
            EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                object tag = ((ToolStripMenuItem)sender).Tag;

                Tools_Clicked(tag);
            }
        }

        private void Tools_Clicked(object tag)
        {
            if (tag != null)
            {
                switch (tag.ToString())
                {
                    case "1":
                        #region 添加学生
                        using (frmAddStudent frm = new frmAddStudent(null))
                        {
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                string sql = "INSERT INTO [Students] " +
                                            "([XH], [XM], [MM], [XB], [NJ], [DH], [DZ], [CSRQ], [Email]) VALUES " +
                                            "('{0}', '{1}', '{2}', {3}, {4}, '{5}', '{6}', '{7}', '{8}')";

                                sql = string.Format(sql, frm.XH, frm.XM,
                                    frm.MM, frm.XB, frm.NJ, frm.DH,
                                    frm.DZ, frm.CSRQ, frm.Email);

                                using (SqlServerHelper ssh = new SqlServerHelper(
                                    DataConst.dataBase, DataConst.userName, DataConst.password))
                                {
                                    object o = ssh.ExecuteScalar(string.Format("Select count(*) from Students where xh = '{0}'",
                                        frm.XH));

                                    if ((int)o != 0)
                                    {
                                        MessageBox.Show(string.Format("学号为 {0} 的学生已经存在，请重新分配学号！",
                                            frm.XH), "添加学生出错提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        if (ssh.ExecuteNonQuery(sql) > 0)
                                        {
                                            this.DialogResult = DialogResult.OK;
                                        }
                                    }
                                }
                            }
                        }
                        #endregion
                        break;
                    case "2":
                        #region 修改学生

                        if (lvStudents.SelectedItems.Count > 0)
                        {
                            ListViewItem lvi = lvStudents.SelectedItems[0];
                            if (lvi != null && lvi.Tag is DataRow)
                            {
                                using (frmAddStudent frm = 
                                    new frmAddStudent(lvi.Tag as DataRow, true))
                                {
                                    if (frm.ShowDialog() == DialogResult.OK)
                                    {
                                    }
                                }
                            }
                            else
                                MessageBox.Show("选中的学生信息不正确！");
                        }
                        else
                            MessageBox.Show("请先选中需要修改的学生！");
                        #endregion
                        break;
                    case "3":
                        #region 修改密码
                        using (frmAlterPwd frm = new frmAlterPwd(m_UserName))
                        {
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                            }
                        }
                        #endregion
                        break;
                    case "4":
                        #region 查询学生
                        using (frmEnquiry frm = new frmEnquiry("Students"))
                        {
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                            }
                        }
                        #endregion
                        break;

                    case "9":
                        this.Close();
                        break;
                }
            }
        }

        private void ToolStrip_ItemClicked(object sender,
            ToolStripItemClickedEventArgs e)
        {
            object tag = e.ClickedItem.Tag;

            Tools_Clicked(tag);
        }
        #endregion


        private void lvStudents_ItemSelectionChanged(object sender,
            ListViewItemSelectionChangedEventArgs e)
        {
            ListViewItem lvi = e.Item;

            if (lvi.Tag is DataRow)
            {
                _selectedDataRow = lvi.Tag as DataRow;

                //Text = dr.Field<string>("MM");
            }
        }

        private void lvStudents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                if (_selectedDataRow != null)
                {
                    if (MessageBox.Show("是否确认删除当前选中的信息！", "删除提示",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        string sql = "DELETE FROM Students WHERE XH = '{0}'";
                        sql = string.Format(sql, _selectedDataRow.Field<object>("XH"));
                        using (SqlServerHelper ssh = new SqlServerHelper(
                                        DataConst.dataBase, DataConst.userName, DataConst.password))
                        {
                            if (ssh.ExecuteNonQuery(sql) > 0)
                            {
                                _selectedDataRow = null;
                                lvStudents.Items.Remove(lvStudents.SelectedItems[0]);                                
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("请先选中需要修改的学生！"); 
            }
        }
    }
}
