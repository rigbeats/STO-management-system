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
    public partial class EditTypesOfWorks : Form
    {
        SqlConnection serviceStationConnection;
        DataGridViewRow selectedRow;

        public EditTypesOfWorks(SqlConnection connectionString)
        {
            InitializeComponent();
            this.serviceStationConnection = connectionString;
        }

        private void EditService_Load(object sender, EventArgs e)
        {
            UpdateMakesTable("SELECT Name, Price FROM TypesOfWorks");
        }

        public void UpdateMakesTable(string request) //Обновление значений в верхней таблице
        {
            SqlDataAdapter ordersDataAdapter = new SqlDataAdapter(
                    request,
                    serviceStationConnection
                    );

            DataSet dataSet = new DataSet();
            ordersDataAdapter.Fill(dataSet);
            Services.DataSource = dataSet.Tables[0];
        }

        private void SearchMake_TextChanged(object sender, EventArgs e)
        {
            UpdateMakesTable(
                "SELECT Name, Price FROM TypesOfWorks " +
                $"WHERE Name LIKE N'%{SearchService.Text}%' ");
        }

        private void Makes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = Services.Rows[e.RowIndex];
            EditName.Text = (string)selectedRow.Cells[0].Value;
            EditPrice.Text = Convert.ToString(selectedRow.Cells[1].Value);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (selectedRow == null)
                MessageBox.Show("Выберите название услуги, которую хотите изменить");
            else
            {
                SqlCommand sqlCommand = new SqlCommand(
                "UPDATE TypesOfWorks " +
                $"SET " +
                $"Name = N'{EditName.Text}', " +
                $"Price = N'{EditPrice.Text}' " +
                $"WHERE Name = N'{selectedRow.Cells[0].Value}' ",
                serviceStationConnection);

                sqlCommand.ExecuteNonQuery();

                string requestion;
                if (SearchService.Text == "")
                    requestion = "Select Name, Price FROM TypesOfWorks";
                else
                    requestion = "SELECT Name, Price FROM TypesOfWorks " +
                    $"WHERE Name LIKE N'%{SearchService.Text}%' ";

                UpdateMakesTable(requestion);
                EditName.Text = "";
                EditPrice.Text = "";
                selectedRow = null;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand(
                "INSERT INTO TypesOfWorks (Name, Price)" +
                $"VALUES (N'{AddName.Text}', {AddPrice.Text}) ",
                serviceStationConnection);

            sqlCommand.ExecuteNonQuery();
            UpdateMakesTable("Select Name, Price FROM TypesOfWorks");
            AddName.Text = "";
            AddPrice.Text = "";
            MessageBox.Show("Услуга успешно добавлена");
        }
    }
}
