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
    public partial class sign_up : Form
    {
        DataBase dataBase = new DataBase();
        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonCreateAcc_Click(object sender, EventArgs e)
        {
            if (checkUser())

            {
                return;
            }
            var login = textBoxLog.Text;
            var password = textBoxPass.Text;

            string queryString = $@"insert into 
register(login_user, password_user) values('{login}', '{password}')";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                log_in frm_login = new log_in();
                this.Hide();
                frm_login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
            dataBase.closeConnection();
        }

        private Boolean checkUser()
        {
            var loginUser = textBoxLog.Text;
            var passUser = textBoxPass.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $@"select * from register 
where login_user = '{loginUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с логином " + loginUser + " уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }



        private void sign_up_Load(object sender, EventArgs e)
        {
            textBoxPass.PasswordChar = '●';
            textBoxLog.MaxLength = 50;
            textBoxPass.MaxLength = 50;
        }
    }
}
