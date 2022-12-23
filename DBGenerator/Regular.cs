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
            dataGridView1.Columns.Add("size", "Размер");
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

        private void pbErase_Click(object sender, EventArgs e)
        {

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
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Add_Form addForm = new Add_Form();
            addForm.Show();

        }
    }
}
