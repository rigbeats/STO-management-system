using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.smallForms
{
    public partial class EditMakes : Form
    {
        SqlConnection serviceStationConnection;
        DataGridViewRow selectedRow;

        public EditMakes(SqlConnection connectionString)
        {
            InitializeComponent();
            this.serviceStationConnection = connectionString;
        }

        private void EditMakes_Load(object sender, EventArgs e)
        {
            UpdateMakesTable("SELECT Name FROM Makes");
        }

        public void UpdateMakesTable(string request) //Обновление значений в верхней таблице
        {
            SqlDataAdapter ordersDataAdapter = new SqlDataAdapter(
                    request,
                    serviceStationConnection
                    );

            DataSet dataSet = new DataSet();
            ordersDataAdapter.Fill(dataSet);
            Makes.DataSource = dataSet.Tables[0];
        }

        private void SearchMake_TextChanged(object sender, EventArgs e)
        {
            UpdateMakesTable(
                "SELECT Name FROM Makes " +
                $"WHERE Name LIKE '%{SearchMake.Text}%' ");
        }

        private void Makes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = Makes.Rows[e.RowIndex];
            EditString.Text = (string)selectedRow.Cells[0].Value;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (selectedRow == null)
                MessageBox.Show("Выберите название марки, которое хотите изменить");
            else
            {
                SqlCommand sqlCommand = new SqlCommand(
                "UPDATE Makes " +
                $"SET Name = '{EditString.Text}' " +
                $"WHERE Name = '{selectedRow.Cells[0].Value}' ",
                serviceStationConnection);

                sqlCommand.ExecuteNonQuery();

                string requestion;
                if (SearchMake.Text == "")
                    requestion = "SELECT Name FROM Makes";
                else
                    requestion = "SELECT Name FROM Makes " +
                                $"WHERE Name LIKE '%{SearchMake.Text}%' ";

                UpdateMakesTable(requestion);
                EditString.Text = "";
                selectedRow = null;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand(
                "INSERT INTO Makes (Name)" +
                $"VALUES ('{AddString.Text}') ",
                serviceStationConnection);

            sqlCommand.ExecuteNonQuery();
            UpdateMakesTable("Select Name FROM Makes");
            AddString.Text = "";
            MessageBox.Show("Марка авто успешно добавлена");
        }
    }
}
