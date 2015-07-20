using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Water.Utilities.Data;
using System.Data.Common;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication3
{
    public partial class frmEnquiry : Form
    {
        private string _tableName = string.Empty;
        private frmEnquiry()
        {
            InitializeComponent();
        }

        public frmEnquiry(string tableName)
            : this()
        {
            _tableName = tableName;
        }

        private void frmEnquiry_Load(object sender, EventArgs e)
        {
            string sql = "Select Name, Xtype FROM SysColumns Where id=Object_Id('{0}')";
            sql = string.Format(sql, _tableName);

            using (SqlServerHelper ssh = new SqlServerHelper(
                DataConst.dataBase, DataConst.userName, DataConst.password))
            {
                DbDataReader ddr = ssh.ExecuteReader(sql);

                while (ddr.Read())
                {
                    cbFieldNames.Items.Add(new ComboBoxItem()
                    {
                        Text = ddr["name"].ToString(),
                        Xtype = int.Parse(ddr["Xtype"].ToString())
                    });
                }

                cbFieldNames.SelectedIndex =
                    cbFieldNames.Items.Count > 0 ? 0 : -1;
            }

            cbOption.SelectedIndex = 0;
        }

        private void btnEnquiry_Click(object sender, EventArgs e)
        {
            DataTable dt = DoEnquiry();
            if (dt != null)
            {
                dgvEnquiry.DataSource = dt;
            }
        }

        private DataTable DoEnquiry()
        {
            ComboBoxItem cbi = (ComboBoxItem)cbFieldNames.SelectedItem;


            string sql = "Select * from " + _tableName;

            if (!chkEnquiry.Checked)
            {
                string filter = GetOption(cbi.Text, cbi.Xtype,
                    cbOption.SelectedIndex, tbMinValue.Text,
                    tbMaxValue.Text);

                sql += " WHERE ";

                sql += filter;
            }

            DataTable dt = null;
            using (SqlServerHelper ssh = new SqlServerHelper(
                DataConst.dataBase, DataConst.userName, DataConst.password))
            {
                DataSet ds = ssh.ExecuteQuery(sql);

                if (ds != null && ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                }
            }

            return dt;
        }
        /// <summary>
        /// 大于、小于、等于、大于等于、
        /// 小于等于、类似、介于
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="xt"></param>
        /// <param name="index"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        private string GetOption(string fileName, int xt,
            int index, string min, string max)
        {
            string ret = " = ";

            bool b = IsNumber(xt);
            switch (index)
            {
                case 0:
                    if (b)
                        ret = "{0} > '{1}'";
                    else
                        ret = "{0} > {1}";

                    ret = string.Format(ret, fileName, min);

                    break;
                case 1:
                    if (b)
                        ret = "{0} < '{1}'";
                    else
                        ret = "{0} < {1}";

                    ret = string.Format(ret, fileName, min);
                    break;
                case 2:
                    if (b)
                        ret = "{0} = '{1}'";
                    else
                        ret = "{0} = {1}";

                    ret = string.Format(ret, fileName, min);
                    break;
                case 3:
                    if (b)
                        ret = "{0} >= '{1}'";
                    else
                        ret = "{0} >= {1}";

                    ret = string.Format(ret, fileName, min);
                    break;
                case 4:
                    if (b)
                        ret = "{0} <= '{1}'";
                    else
                        ret = "{0} <= {1}";

                    ret = string.Format(ret, fileName, min);
                    break;
                case 5:
                    ret = "{0} like '%{1}%'";

                    ret = string.Format(ret, fileName, min);

                    break;
                case 6:
                    if (b)
                        ret = "{0} between '{1}' and '{2}' ";
                    else
                        ret = "{0} between {1} and {2} ";

                    ret = string.Format(ret, fileName, min, max);
                    break;
            }

            return ret;
        }

        private bool IsNumber(int xt)
        {
            bool ret = false;


            switch ((xtype)xt)
            {
                case xtype.uniqueidentifier:
                case xtype.date:
                case xtype.time:
                case xtype.datetime2:
                case xtype.smalldatetime:
                case xtype.datetime:
                case xtype.varchar:
                case xtype.Char:
                case xtype.timestamp:
                case xtype.nvarchar:
                case xtype.nchar:
                    ret = true;
                    break;
            }

            return ret;
        }

        private void cbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOption.SelectedIndex == 6)
            {
                labMinValue.Text = "最小值";
                labMaxValue.Visible = true;
                tbMaxValue.Visible = true;
                pEnquiry.Height = 160;
            }
            else
            {
                labMinValue.Text = "值";
                labMaxValue.Visible = false;
                tbMaxValue.Visible = false;
                pEnquiry.Height = 125;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmSelectedColumn frm = new frmSelectedColumn(dgvEnquiry.Columns);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                List<string> scs = frm.SelectedColumnNames;

                if (dgvEnquiry.Rows.Count == 0)
                    return;
                try
                {
                    //建立Excel对象    
                    Excel.Application excel = new Excel.Application();
                    excel.Application.Workbooks.Add(true);
                    excel.Visible = true;
                    Excel.Worksheet sheet = (Excel.Worksheet)excel.Application.Worksheets[1];

                    sheet.Name = (dgvEnquiry.DataSource is DataTable) ?
                        (dgvEnquiry.DataSource as DataTable).TableName : "表名";

                    //生成字段名称    
                    for (int i = 0; i < scs.Count; i++)
                    {
                        excel.Cells[1, i + 1] = frm.SelectedColumnTexts[i];//dgvEnquiry.Columns[i].HeaderText;
                    }
                    //填充数据    
                    for (int i = 0; i < dgvEnquiry.RowCount; i++)
                    {
                        for (int j = 0; j < scs.Count; j++)
                        {
                            if (dgvEnquiry.Rows[i].Cells[scs[j]].ValueType == typeof(string))
                            {
                                excel.Cells[i + 2, j + 1] = "'" + dgvEnquiry.Rows[i].Cells[scs[j]].Value.ToString();
                            }
                            else
                            {
                                excel.Cells[i + 2, j + 1] = dgvEnquiry.Rows[i].Cells[scs[j]].Value.ToString();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        private void dgvEnquiry_CellFormatting(object sender, 
            DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEnquiry.Columns[e.ColumnIndex].Name == "XM")
            {
                e.Value = Languages.Language.GetString(e.Value.ToString());
            }
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }

        public int Xtype { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
