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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBGenerator
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }


    public partial class Regular : Form
    {
        DataBase dataBase = new();
        int selectedRow;

        public Regular()
        {
            InitializeComponent();
        }
        private void Regular_Load(object sender, EventArgs e)
        {
            CreateColums();
            RefreshDataGrid(dataGridView1);
        }

        private void CreateColums()
        {
            dataGridView1.Columns.Add("ID", "id");
            dataGridView1.Columns.Add("Name", "Название");
            dataGridView1.Columns.Add("SecretIngredient", "Номер секретного ингрединта");
            dataGridView1.Columns.Add("Size", "Размер");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Buns";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }


        private void ClearFields()
        {
            tbID.Text = "";
            tbName.Text = "";
            tbSecretIngredient.Text = "";
            tbSize.Text = "";
        }


        private void pbErase_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                tbID.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                tbSecretIngredient.Text = row.Cells[2].Value.ToString();
                tbSize.Text = row.Cells[3].Value.ToString();
            }
        }

        private void pbUpdate_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Add_Form addForm = new Add_Form();
            addForm.Show();

        }


        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();


            string queryString = $@"select * from Buns 
where concat (ID, Name, SecretIngredient, Size) like N'%" + textBoxSearch.Text + "%'";

            SqlCommand com = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while(read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }


        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;

        }


        private void Update()
        {
            dataBase.openConnection();

            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[4].Value;

                if(rowState == RowState.Existed)
                    continue;

                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from buns where ID = {id}";
                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }

                if(rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var secretIngredient = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var size = dataGridView1.Rows[index].Cells[3].Value.ToString();

                    var changeQuery = $@"update Buns 
set Name = N'{name}', SecretIngredient = '{secretIngredient}', Size = N'{size}'
where ID = '{id}'";

                    var command = new SqlCommand (changeQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery(); 

                }

            }

            dataBase.closeConnection();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Update();
            ClearFields();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = tbID.Text;
            var name = tbName.Text;
            var size = tbSize.Text;
            int secretIngredient;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if(int.TryParse(tbSecretIngredient.Text, out secretIngredient) && secretIngredient<15)
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, name, secretIngredient, size);
                    dataGridView1.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Номер секретного ингредиента должен быть от 1 до 14");
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

    }
}
