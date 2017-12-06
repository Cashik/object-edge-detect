using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class LoginForm : Form
    {
        public int user_id;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContoursDataSet1TableAdapters.QueriesTableAdapter query = new ContoursDataSet1TableAdapters.QueriesTableAdapter();
            if (1 == Convert.ToInt32(query.Login(login_tb.Text, password_tb.Text)))
            {
                user_id = Convert.ToInt32(query.UserIdByLogin(login_tb.Text));
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ошибка", "Неверная комбинация логин/пароль.");
            }

        }
    }
}
