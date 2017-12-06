using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditor
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm lf = new LoginForm();

            if (lf.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm(lf.user_id));
            }
        }
    }
}
