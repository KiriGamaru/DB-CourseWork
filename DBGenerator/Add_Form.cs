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
    public partial class Add_Form : Form
    {

        DataBase dataBase = new();

        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var name = tbName.Text;
            var size = tbSize.Text;
            int secretIngredient;

            if (int.TryParse(tbSecretIngredient.Text, out secretIngredient) && secretIngredient > 0  && secretIngredient <= 14)
            {
                var addQuery = $@"insert into Buns (Name, SecretIngredient, Size)
values (N'{name}', N'{secretIngredient}', N'{size}')";

                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!","Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Номер секретного ингредиента должен быть от 1 до 14!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataBase.closeConnection();
        }
    }
}
