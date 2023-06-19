using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProject.smallForms;

namespace MyProject
{
    public partial class MainForm : Form
    {
        SqlConnection serviceStationConnection = null;
        static DataGridViewRow row = null;
        User user;

        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            serviceStationConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ServiceStation"].ConnectionString);

            serviceStationConnection.Open();
            UpdateOrdersTable();
        }

        private void Orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateListOfTasksTable(e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (row == null)
                MessageBox.Show("Выберите заявку, которую хотите удалить");
            else
            {
                var form = new DeleteOrder((int)row.Cells[0].Value, serviceStationConnection);
                form.ShowDialog();
                UpdateOrdersTable();
                row = null;
            }
        }

        private void performButton_Click(object sender, EventArgs e)
        {
            if (row == null)
                MessageBox.Show("Выберите заявку, которую хотите удалить");
            else
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Orders " +
                    "SET Status = N'Выполнено' " +
                    $"WHERE Id = '{row.Cells[0].Value}' ",
                    serviceStationConnection);

                command.ExecuteNonQuery();
                UpdateOrdersTable();
                row = null;
            }
        }









        public void UpdateOrdersTable()
        {
            SqlDataAdapter ordersDataAdapter = new SqlDataAdapter(
                "SELECT Orders.Id AS Id, " +
                "Makes.Name AS 'Марка', " +
                "Models.Name AS 'Модель', " +
                "Orders.Date AS 'Дата', " +
                "Orders.Status AS 'Статус' " +
                "FROM " +
                "Makes JOIN Orders ON Makes.Id = Orders.MakeId " +
                "JOIN Models ON Orders.ModelId = Models.Id " +
                "JOIN Users ON Orders.UserId = Users.Id " +
                $"WHERE Users.Login = '{user.Login}' " +
                "AND Orders.Status = N'В процессе' ",
                serviceStationConnection
                );

            DataSet dataSet = new DataSet();
            ordersDataAdapter.Fill(dataSet);
            orders.DataSource = dataSet.Tables[0];
            orders.Columns["Id"].Visible = false;
            orders.ClearSelection();
        }

        public void UpdateListOfTasksTable(DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < orders.Rows.Count)
            {
                row = orders.Rows[rowIndex];

                SqlDataAdapter listOfTasksAdapter = new SqlDataAdapter(
                    "SELECT TypesOfWorks.Name AS 'Название', " +
                    "TypesOfWorks.Price AS 'Цена' " +
                    "FROM " +
                    "Users JOIN ListOfTasks ON Users.Id = ListOfTasks.UserId " +
                    "JOIN TypesOfWorks ON TypesOfWorks.Id = ListOfTasks.TypeOfWorkId " +
                    "JOIN Orders ON Orders.Id = ListOfTasks.OrderId " +
                    "JOIN Makes ON Makes.Id = Orders.MakeId " +
                    $"WHERE Users.Login = '{user.Login}' " +
                    $"AND Makes.Name = '{row.Cells[1].Value}' ", //столбец с названем марки
                    serviceStationConnection
                    );

                DataSet dataSet = new DataSet();
                listOfTasksAdapter.Fill(dataSet);
                listOfTasks.DataSource = dataSet.Tables[0];
            }
        }
    }
}
