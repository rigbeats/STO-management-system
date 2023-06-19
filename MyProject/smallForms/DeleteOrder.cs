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
    public partial class DeleteOrder : Form
    {
        int idOfOrder;
        static SqlConnection connectionString = null;

        public DeleteOrder(int idOfOrder, SqlConnection connectionStr)
        {
            this.idOfOrder = idOfOrder;
            connectionString = connectionStr;
            InitializeComponent();
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            connectionString.Open();
            SqlCommand command = new SqlCommand(
                "DELETE " +
                "FROM Orders " +
                $"WHERE Id = '{idOfOrder}'",
                connectionString);

            command.ExecuteNonQuery();
            connectionString.Close();
            this.Close();
        }
    }
}
