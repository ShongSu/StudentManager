using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //System.Threading.Thread.CurrentThread.CurrentUICulture =
            //    new System.Globalization.CultureInfo("en");

            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("zh-CHS");

            //System.Threading.Thread.CurrentThread.CurrentUICulture =
            //    new System.Globalization.CultureInfo("zh-CHT");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
                Application.Run(new frmMain(login.UserName));
            else
                Application.Exit();
        }
    }
}
