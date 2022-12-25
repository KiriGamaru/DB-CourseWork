using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBGenerator
{
    public partial class log_in : Form
    {
        DataBase dataBase = new DataBase();

        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            textBoxPass.PasswordChar = '●';
            textBoxLog.MaxLength = 50;
            textBoxPass.MaxLength = 50;
        }

        private void buttonCreateAcc_Click(object sender, EventArgs e)
        {
            var loginUser = textBoxLog.Text;
            var passUser = textBoxPass.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $@"select id_user, login_user, password_user
from register 
where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!","Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (loginUser == "admin")
                {
                    //__________
                    Form1 form1 = new Form1();
                    Regular regform = new Regular();
                    this.Hide();
                    regform.Show();
                    form1.Show();
                    //__________
                }
                else
                {
                    //__________
                    Regular regform = new Regular();
                    this.Hide();
                    regform.ShowDialog();
                    this.Show();
                    //__________
                }
            }
            else
                MessageBox.Show("Неверный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up frm_sign = new sign_up();
            this.Hide();
            frm_sign.ShowDialog();
            this.Show();
        }

    }
}
