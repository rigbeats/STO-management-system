using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.smallForms
{
    public partial class EditModels : Form
    {
        SqlConnection serviceStationConnection;
        DataGridViewRow selectedRow;

        public EditModels(SqlConnection connectionString)
        {
            InitializeComponent();
            this.serviceStationConnection = connectionString;
        }

        private void EditModels_Load(object sender, EventArgs e)
        {
            UpdateTable(
                "SELECT Models.Name AS 'Модель', " +
                "Makes.Name AS 'Марка' " +
                "FROM " +
                "Models JOIN Makes ON Models.MakeId = Makes.Id ");

            UpdateComboBox(
                "SELECT Name FROM Makes ORDER BY Name",
                listOfMakes);
        }

        public void UpdateTable(string request)
        {
            SqlDataAdapter ordersDataAdapter = new SqlDataAdapter(
                    request,
                    serviceStationConnection
                    );

            DataSet dataSet = new DataSet();
            ordersDataAdapter.Fill(dataSet);
            Models.DataSource = dataSet.Tables[0];
        }

        private void SearchModel_TextChanged(object sender, EventArgs e)
        {
            UpdateTable(
                "SELECT Models.Name AS 'Модель', " +
                "Makes.Name AS 'Марка' " +
                "FROM " +
                "Models JOIN Makes ON Models.MakeId = Makes.Id " +
                $"WHERE Models.Name LIKE '%{SearchModel.Text}%' ");
        }

        private void Models_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = Models.Rows[e.RowIndex];
                EditString.Text = (string)selectedRow.Cells[0].Value;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (selectedRow == null)
                MessageBox.Show("Выберите название модели, которое хотите изменить");
            else
            {
                bool makeAlreadyExists = false;

                foreach (DataGridViewRow checkingRow in Models.Rows)
                {
                    if (checkingRow.Cells["Модель"].Value.ToString() == EditString.Text)
                    {
                        makeAlreadyExists = true;
                        break;
                    }
                }

                if (makeAlreadyExists)
                    MessageBox.Show("Модель уже существует");
                else
                {
                    SqlCommand sqlCommand = new SqlCommand(
                    "UPDATE Models " +
                    $"SET Name = '{EditString.Text}' " +
                    $"WHERE Name = '{selectedRow.Cells[0].Value}' ",
                    serviceStationConnection);

                    sqlCommand.ExecuteNonQuery();

                    string requestion;
                    if (SearchModel.Text == "")
                        requestion = "SELECT Models.Name AS 'Модель', " +
                        "Makes.Name AS 'Марка' " +
                        "FROM " +
                        "Models JOIN Makes ON Models.MakeId = Makes.Id ";
                    else
                        requestion = "SELECT Models.Name AS 'Модель', " +
                        "Makes.Name AS 'Марка' " +
                        "FROM " +
                        "Models JOIN Makes ON Models.MakeId = Makes.Id " +
                        $"WHERE Name LIKE '%{SearchModel.Text}%' ";

                    UpdateTable(requestion);
                    EditString.Text = "";
                    selectedRow = null;
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            bool makeAlreadyExists = false;

            foreach (DataGridViewRow checkingRow in Models.Rows)
            {
                if (checkingRow.Cells["Модель"].Value.ToString() == AddString.Text && checkingRow.Cells["Марка"].Value.ToString() == listOfMakes.SelectedValue.ToString())
                {
                    makeAlreadyExists = true;
                    break;
                }
            }

            if (makeAlreadyExists)
                MessageBox.Show("Модель уже существует");
            else
            {
                SqlCommand sqlCommand = new SqlCommand(
                "INSERT INTO Models (Name, MakeId) " +
                "Select " +
                $"'{AddString.Text}', " +
                $"(SELECT Id FROM Makes WHERE Name = '{listOfMakes.SelectedValue}') ",
                serviceStationConnection);

                sqlCommand.ExecuteNonQuery();
                UpdateTable(
                    "SELECT Models.Name AS 'Модель', " +
                    "Makes.Name AS 'Марка' " +
                    "FROM " +
                    "Models JOIN Makes ON Models.MakeId = Makes.Id ");

                AddString.Text = "";
                MessageBox.Show("Модель авто успешно добавлена");
            }
        }

        private void UpdateComboBox(string request, ComboBox comboBox)
        {
            SqlCommand command = new SqlCommand(request, serviceStationConnection);
            var strings = new List<string>();

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    strings.Add(reader.GetString(0));
                }
            }
            comboBox.DataSource = strings;
        }
    }
}
