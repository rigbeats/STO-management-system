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
		}

		private void editClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void editHelp_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Здесь можно изменить заказ");          
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
			var row = gvCurrentOrder.SelectedRows[0];
			// Check if a row is selected in gvCurrentOrder
			if (gvCurrentOrder.SelectedRows.Count > 0)
			{
				// Remove the selected row from gvCurrentOrder
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
			}
			else
			{
				MessageBox.Show("Please select a row in the Current Order.");
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
                        // Compare the values of the service columns to check for a match
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
                }
            }
            else
            {
                addService();
            }

        }
        private void addService()
		{
			if (gvListOfServices.SelectedRows.Count > 0)
			{
				var row = gvListOfServices.SelectedRows[0];

				// Get the DataTable bound to gvCurrentOrder
				DataTable dt = (DataTable)gvCurrentOrder.DataSource;

				// Create a new row with the same schema as the DataTable
				DataRow newRow = dt.NewRow();

				// Copy the cell values from the selected row to the new row
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

				// Refresh the DataGridView to reflect the changes
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
	}
}
