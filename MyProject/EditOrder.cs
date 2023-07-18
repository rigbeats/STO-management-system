using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
		MainForm form1 = null;
		public EditOrder(int IdOfOrder, SqlConnection connectionStr, User user, MainForm form)
		{
			this.idOfOrder = IdOfOrder;
			connectionString = connectionStr;
			InitializeComponent();
			this.Text = "Редактирование заявки";
			this.user = user;
			this.form1 = form;
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

			UpdateTextBox();
		}

		private void editClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonRemoveService_Click(object sender, EventArgs e)
		{
			var row = gvCurrentOrder.SelectedRows[0];

			if (gvCurrentOrder.SelectedRows.Count > 0)
			{
				SqlCommand cmd = new SqlCommand(
					"DELETE FROM ListOfTasks " +
					$"WHERE UserId = (SELECT Id FROM Users WHERE Login = N'{user.Login}')  " +
					$"AND TypeOfWorkId = (SELECT Id FROM TypesOfWorks WHERE Name = N'{row.Cells[0].Value}')  " +
					$"AND OrderId = {idOfOrder} ",
					connectionString
					);
				gvCurrentOrder.Rows.Remove(gvCurrentOrder.SelectedRows[0]);
				gvCurrentOrder.Refresh();
				cmd.ExecuteNonQuery();

				UpdateTextBox();
			}
			else
			{
				MessageBox.Show("Пожалуйста, выберите строку в текущем заказе");
			}
		}

		private void buttonAddService_Click(object sender, EventArgs e)
		{
            if (gvCurrentOrder.Rows != null && gvCurrentOrder.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = gvListOfServices.Rows[gvListOfServices.SelectedCells[0].RowIndex];
                bool serviceAlreadyExists = false;

                foreach (DataGridViewRow checkingRow in gvCurrentOrder.Rows)
                {
                    if (checkingRow.Cells["Название"].Value != null && selectedRow.Cells["Название"].Value != null)
                    {
                        if (checkingRow.Cells["Название"].Value.ToString() == selectedRow.Cells["Название"].Value.ToString())
                        {
                            serviceAlreadyExists = true;
                            break;
                        }
                    }
                }

                if (serviceAlreadyExists)
                {
                    MessageBox.Show("Эта услуга уже включена в заказ");
                }
                else
                {
                    addService();
					UpdateTextBox();
                }
            }
            else
            {
                addService();
				UpdateTextBox();
            }

        }
        private void addService()
		{
			if (gvListOfServices.SelectedRows.Count > 0)
			{
				var row = gvListOfServices.SelectedRows[0];

				DataTable dt = (DataTable)gvCurrentOrder.DataSource;
				DataRow newRow = dt.NewRow();

				for (int i = 0; i < row.Cells.Count; i++)
				{
					newRow[i] = row.Cells[i].Value;
				}

				// Add the new row to the DataTable
				dt.Rows.Add(newRow);

				SqlCommand cmd = new SqlCommand(
					"INSERT INTO ListOfTasks (UserId, TypeOfWorkId, OrderId)" +
					"SELECT " +
					$"(SELECT Id FROM Users WHERE Login = N'{user.Login}'), " +
					$"(SELECT Id FROM TypesOfWorks WHERE Name = N'{row.Cells[0].Value}'), " +
					$"{idOfOrder} ",
					connectionString
					);

				gvCurrentOrder.Refresh();
				cmd.ExecuteNonQuery();
			}

			else
			{
				MessageBox.Show("Please select a row in the Current Order table.");
			}
		}

		private void EditOrder_FormClosed(object sender, FormClosedEventArgs e)
		{
			form1.UpdateListOfTasksTable();
		}

		private void finishOrder_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void UpdateTextBox()
		{
            totalCost.Clear();
            SqlCommand command = new SqlCommand(
                    "SELECT SUM(Price) " +
                    "FROM TypesOfWorks " +
                    "JOIN ListOfTasks ON TypesOfWorks.Id = ListOfTasks.TypeOfWorkId " +
                    $"WHERE OrderId = {idOfOrder} ",
                    connectionString);

            var cost = Convert.ToString(command.ExecuteScalar());
            totalCost.AppendText(cost);
        }
	}
}
