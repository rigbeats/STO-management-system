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
using System.Windows.Forms.DataVisualization.Charting;

namespace MyProject.smallForms
{
    public partial class EditAccounts : Form
    {
        SqlConnection serviceStationConnection;
        DataGridViewRow selectedRow;

        public EditAccounts(SqlConnection connectionString)
        {
            InitializeComponent();
            this.serviceStationConnection = connectionString;
        }

        private void EditAccounts_Load(object sender, EventArgs e)
        {
            UpdateAccountsTable("SELECT Login, Password FROM Users");
        }

        public void UpdateAccountsTable(string request) //Обновление значений в верхней таблице
        {
            SqlDataAdapter ordersDataAdapter = new SqlDataAdapter(
                    request,
                    serviceStationConnection
                    );

            DataSet dataSet = new DataSet();
            ordersDataAdapter.Fill(dataSet);
            accounts.DataSource = dataSet.Tables[0];
        }

        private void SearchAccounts_TextChanged(object sender, EventArgs e)
        {
            UpdateAccountsTable(
                "SELECT Login, Password FROM Users " +
                $"WHERE Login LIKE N'%{SearchAccount.Text}%' ");
        }

        private void Accounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = accounts.Rows[e.RowIndex];
                EditLogin.Text = (string)selectedRow.Cells[0].Value;
                EditPassword.Text = Convert.ToString(selectedRow.Cells[1].Value);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (selectedRow == null)
                MessageBox.Show("Выберите аккаунт, которую хотите изменить");
            else
            {
                SqlCommand sqlCommand = new SqlCommand(
                "UPDATE Users " +
                $"SET " +
                $"Login = N'{EditLogin.Text}', " +
                $"Password = N'{EditPassword.Text}' " +
                $"WHERE Login = N'{selectedRow.Cells[0].Value}' ",
                serviceStationConnection);

                sqlCommand.ExecuteNonQuery();

                string requestion;
                if (SearchAccount.Text == "")
                    requestion = "Select Login, Password FROM Users";
                else
                    requestion = "SELECT Login, Password FROM Users " +
                    $"WHERE Login LIKE N'%{SearchAccount.Text}%' ";

                UpdateAccountsTable(requestion);
                EditLogin.Text = "";
                EditPassword.Text = "";
                selectedRow = null;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand(
                "INSERT INTO Users (Login, Password)" +
                $"VALUES (N'{AddLogin.Text}', {AddPassword.Text}) ",
                serviceStationConnection);

            sqlCommand.ExecuteNonQuery();
            UpdateAccountsTable("Select Login, Password FROM Users");
            AddLogin.Text = "";
            AddPassword.Text = "";
            MessageBox.Show("аккаунт успешно добавлен");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand(
                "DELETE FROM Users " +
                $"WHERE Login = N'{selectedRow.Cells[0].Value}'",
                serviceStationConnection);
            
            sqlCommand.ExecuteNonQuery();
            UpdateAccountsTable("Select Login, Password FROM Users");

            MessageBox.Show("Аккаунт удален");
        }
    }
}
