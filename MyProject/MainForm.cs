using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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
            this.Text = "Станция технического обслуживания";
        }

        private void MainForm_Load(object sender, EventArgs e) //Загрузка формы
        {
            serviceStationConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ServiceStation"].ConnectionString);
            serviceStationConnection.Open();

            if (user.Login == "admin")
            {
                listOfMakes.Enabled = true;
                listOfModels.Enabled = true;
                listOfUsers.Enabled = true;
                registrationNumber.Enabled = true;
                addButton.Enabled = true;
            }


            UpdateOrdersTable();
            row = orders.Rows[0];
            UpdateListOfTasksTable();
        }

        private void Orders_CellClick(object sender, DataGridViewCellEventArgs e) //Обработка нажатия на строку в верхней таблице
        {
            row = orders.Rows[e.RowIndex];
            UpdateListOfTasksTable();
        }

        private void deleteButton_Click(object sender, EventArgs e) //Обработка нажатия на кнопку "Удалить" заявку
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

        private void performButton_Click(object sender, EventArgs e) //Обработка нажатия на кнопку "Выполнить" заявку
        {
            if (row == null)
                MessageBox.Show("Выберите заявку, которую хотите выполнить");
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

        private void listOfMakes_DropDown(object sender, EventArgs e)
        {
            AddValuesInComboBox(
               "SELECT Name FROM Makes",
               listOfMakes);
        }

        private void listOfMakes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AddValuesInComboBox(
                "SELECT Models.Name " +
                "FROM Models " +
                "JOIN Makes ON Makes.Id = Models.MakeId " +
                $"WHERE Makes.Name = '{listOfMakes.SelectedValue}' ",
                listOfModels);
        }

        private void listOfUsers_DropDown(object sender, EventArgs e)
        {
            AddValuesInComboBox(
                "SELECT Users.Login " +
                "FROM Users ",
                listOfUsers
                );
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (listOfModels.SelectedValue == null || listOfMakes.SelectedValue == null || registrationNumber.Text == "")
                MessageBox.Show("Все поля должны быть заполнены");
            else
            {
                SqlCommand addToOrders = new SqlCommand(
                    "INSERT INTO Orders(UserId, MakeId, ModelId, Date, Status, RegistrationNumber) " +
                    "SELECT " +
                    $"(SELECT Id FROM Users WHERE Login = '{listOfUsers.SelectedValue}'), " +
                    $"(SELECT Id FROM Makes WHERE Name = '{listOfMakes.SelectedValue}'), " +
                    $"(SELECT Id FROM Models WHERE Name = '{listOfModels.SelectedValue}')," +
                    $"'{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}', " +
                    "N'В процессе', " +
                    $"'{registrationNumber.Text}';",
                    serviceStationConnection);

                addToOrders.ExecuteNonQuery();
                UpdateOrdersTable();

                MessageBox.Show("Заявка добавлена");
            }
        }







        public void UpdateOrdersTable() //Обновление значений в верхней таблице
        {
            SqlDataAdapter ordersDataAdapter = null;

            if (user.Login == "admin")
            {
                ordersDataAdapter = new SqlDataAdapter(
                    "SELECT Orders.Id AS Id, " +
                    "Makes.Name AS 'Марка', " +
                    "Models.Name AS 'Модель', " +
                    "Orders.RegistrationNumber AS 'Гос. номер', " +
                    "Users.Login AS 'Пользователь', " +
                    "Orders.Date AS 'Дата', " +
                    "Orders.Status AS 'Статус' " +
                    "FROM " +
                    "Makes JOIN Orders ON Makes.Id = Orders.MakeId " +
                    "JOIN Models ON Orders.ModelId = Models.Id " +
                    "JOIN Users ON Orders.UserId = Users.Id " +
                    "ORDER BY Orders.Date DESC ",
                    serviceStationConnection
                    );
            }
            else
            {
                ordersDataAdapter = new SqlDataAdapter(
                    "SELECT Orders.Id AS Id, " +
                    "Makes.Name AS 'Марка', " +
                    "Models.Name AS 'Модель', " +
                    "Orders.RegistrationNumber AS 'Гос. номер', " +
                    "Users.Login AS 'Пользователь', " +
                    "Orders.Date AS 'Дата', " +
                    "Orders.Status AS 'Статус' " +
                    "FROM " +
                    "Makes JOIN Orders ON Makes.Id = Orders.MakeId " +
                    "JOIN Models ON Orders.ModelId = Models.Id " +
                    "JOIN Users ON Orders.UserId = Users.Id " +
                    $"WHERE Users.Login = '{user.Login}' " +
                    "AND Orders.Status = N'В процессе' " +
                    "ORDER BY Orders.Date DESC ",
                    serviceStationConnection
                    );
            }

            DataSet dataSet = new DataSet();
            ordersDataAdapter.Fill(dataSet);
            orders.DataSource = dataSet.Tables[0];
            orders.Columns["Id"].Visible = false;
        }

        public void UpdateListOfTasksTable() //Обновление значений в нижней таблице
        {
            if (row.Index >= 0 && row.Index < orders.Rows.Count)
            {
                totalCost.Clear();

                SqlDataAdapter listOfTasksAdapter = new SqlDataAdapter(
                    "SELECT TypesOfWorks.Name AS 'Название', " +
                    "TypesOfWorks.Price AS 'Цена' " +
                    "FROM " +
                    "Users JOIN ListOfTasks ON Users.Id = ListOfTasks.UserId " +
                    "JOIN TypesOfWorks ON TypesOfWorks.Id = ListOfTasks.TypeOfWorkId " +
                    "JOIN Orders ON Orders.Id = ListOfTasks.OrderId " +
                    "JOIN Makes ON Makes.Id = Orders.MakeId " +
                    $"AND Makes.Name = '{row.Cells[1].Value}' " +  //столбец с названем марки
                    $"WHERE Users.Login = '{user.Login}' " +
                    $"AND Orders.Id = '{row.Cells[0].Value}'",
                    serviceStationConnection);

                DataSet dataSet = new DataSet();
                listOfTasksAdapter.Fill(dataSet);
                listOfTasks.DataSource = dataSet.Tables[0];


                SqlCommand command = new SqlCommand(
                    "SELECT SUM(Price) " +
                    "FROM TypesOfWorks " +
                    "JOIN ListOfTasks ON TypesOfWorks.Id = ListOfTasks.TypeOfWorkId " +
                    $"WHERE OrderId = {row.Cells[0].Value} ",
                    serviceStationConnection);

                var cost = Convert.ToString(command.ExecuteScalar());
                totalCost.AppendText(cost);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (row == null)
                MessageBox.Show("Выберите заявку, которую хотите удалить");
            else
            {
                EditOrder editOrder = new EditOrder((int)row.Cells[0].Value, serviceStationConnection, user, this);
                editOrder.Show();
            }
        }

        private void AddValuesInComboBox(string request, ComboBox comboBox)
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
