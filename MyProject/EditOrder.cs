using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class EditOrder : Form
    {
        int idOfOrder;
        SqlConnection connectionString = null;
        User user;
        public EditOrder(int IdOfOrder, SqlConnection connectionStr, User user)
        {
            this.idOfOrder = IdOfOrder;
            connectionString = connectionStr;
            InitializeComponent();
            this.Text = "Редактирование заявки";
            this.user = user;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ordersDataAdapter = new SqlDataAdapter(
            $"SELECT Name AS 'Название', Price AS 'Цена' FROM TypesOfWorks", 
            connectionString);
            DataSet dataSet = new DataSet();
            ordersDataAdapter.Fill(dataSet);
            gvListOfServices.DataSource = dataSet.Tables[0];
            SqlDataAdapter ordersDataAdapter2 = new SqlDataAdapter(
            "SELECT TypesOfWorks.Name AS 'Название', " +
            "TypesOfWorks.Price AS 'Цeнa' " +
            "FROM " +
            "Users JOIN ListOfTasks ON Users.Id = ListOfTasks.UserId " +
            "JOIN TypesOfWorks ON TypesOfWorks.Id = ListOfTasks.TypeOfWorkId " +
            "JOIN Orders ON Orders.Id = ListOfTasks.OrderId " +
            "JOIN Makes ON Makes.Id = Orders.MakeId "+
            $"WHERE Users.Login = '{user.Login}' " +
            $"AND Orders.Id = '{idOfOrder}'",
            connectionString);
            DataSet dataSet2 = new DataSet();
            ordersDataAdapter2.Fill(dataSet2);
            gvCurrentOrder.DataSource = dataSet2.Tables[0];
        }

        private void editClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editHelp_Click(object sender, EventArgs e)
        {
            //создаю новое окошко хелп
            Help help = new Help();

            //сюды будет текст
            help.SetLabelText("Здесь можно редактировать заявку");
            
            help.Show();            
        }

        private void orderedService_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void gvListOfServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvCurrentOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonRemoveService_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in gvCurrentOrder
            if (gvCurrentOrder.SelectedRows.Count > 0)
            {
                // Remove the selected row from gvCurrentOrder
                gvCurrentOrder.Rows.Remove(gvCurrentOrder.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Please select a row in the Current Order.");
            }
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            if (gvListOfServices.SelectedRows.Count > 0)
            {
                var row = gvListOfServices.SelectedRows[0];


                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO ListOfTasks (UserId, TypeOfWorkId, OrderId)" +
                    "SELECT " +
                    $"(SELECT Id FROM Users WHERE Login = N'{ user.Login }'), " +
                    $"(SELECT Id FROM TypesOfWorks WHERE Name = N'{ row.Cells[0].Value }'), " +
                    $"{ idOfOrder } ",
                    connectionString
                    );

                cmd.ExecuteNonQuery();
            }

            else
            {
                MessageBox.Show("Please select a row in the Current Order table.");
            }
        }
    }
}
