using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;

namespace WindowsFormsApplication3
{
    public partial class frmSelectedColumn : Form
    {
        private DataGridViewColumnCollection _columns;
        private List<string> _selectedColumnNames = new List<string>();
        private List<string> _selectedColumnTexts = new List<string>();

        public List<string> SelectedColumnNames
        {
            get
            {
                return _selectedColumnNames;
            }
        }

        public List<string> SelectedColumnTexts
        {
            get
            {
                return _selectedColumnTexts;
            }
        }


        public frmSelectedColumn()
        {
            InitializeComponent();
        }

        public frmSelectedColumn(DataGridViewColumnCollection cs)
            : this()
        {
            _columns = cs;
            lvColumns.Items.Clear();
            foreach (DataGridViewColumn item in _columns)
            {
                ListViewItem lvi = new ListViewItem(Languages.Language.GetString(item.HeaderText));
                lvi.Tag = item.Name;
                lvColumns.Items.Add(lvi);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmSelectedColumn_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool nochecked = true;
            foreach (ListViewItem item in lvColumns.Items)
            {
                nochecked &= !item.Checked;

                if (item.Checked)
                {
                    _selectedColumnNames.Add(item.Tag.ToString());
                    _selectedColumnTexts.Add(item.Text);
                }
            }

            if (nochecked)
            {
                MessageBox.Show("请至少选中一列！");
            }
            else
                this.DialogResult = DialogResult.OK;
        }

        // 上移
        private void ListViewUpMove(ListView listView)         
        {             
            if (listView.SelectedItems.Count == 0)             
            {                 
                return;             
            }             
            listView.BeginUpdate();             
            if (listView.SelectedItems[0].Index > 0)             
            {                 
                foreach (ListViewItem lvi in listView.SelectedItems) 
                {      
                    ListViewItem lviSelectedItem = lvi;  
                    int indexSelectedItem = lvi.Index;  
                    listView.Items.RemoveAt(indexSelectedItem);  
                    listView.Items.Insert(indexSelectedItem - 1, lviSelectedItem);   
                }             
            }            
            listView.EndUpdate();       
            if (listView.Items.Count > 0 && listView.SelectedItems.Count > 0)       
            {               
                listView.Focus();        
                listView.SelectedItems[0].Focused = true;     
                listView.SelectedItems[0].EnsureVisible();   
            }         
        } 
        //下移        
        private void ListViewDownMove(ListView listView)
        {
            if (listView.SelectedItems.Count == 0)
            {
                return;
            }
            listView.BeginUpdate();
            int indexMaxSelectedItem = listView.SelectedItems[listView.SelectedItems.Count - 1].Index;
            if (indexMaxSelectedItem < listView.Items.Count - 1)
            {
                for (int i = listView.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem lviSelectedItem = listView.SelectedItems[i];
                    int indexSelectedItem = lviSelectedItem.Index;
                    listView.Items.RemoveAt(indexSelectedItem);
                    listView.Items.Insert(indexSelectedItem + 1, lviSelectedItem);
                }
            }
            listView.EndUpdate();
            if (listView.Items.Count > 0 && listView.SelectedItems.Count > 0)
            {
                listView.Focus();
                listView.SelectedItems[listView.SelectedItems.Count - 1].Focused = true;
                listView.SelectedItems[listView.SelectedItems.Count - 1].EnsureVisible();
            }
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            ListViewUpMove(lvColumns);
        }
    }
}
