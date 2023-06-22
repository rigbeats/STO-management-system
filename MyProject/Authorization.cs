using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;


namespace MyProject
{
    public partial class Authorization : Form
    {
        SqlConnection serviceStationConnection = null;
        Thread thread = null;

        public Authorization()
        {
            InitializeComponent();
            Size = new System.Drawing.Size(500, 300);
            this.Text = "Станция технического обслуживания";
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            serviceStationConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ServiceStation"].ConnectionString);
            serviceStationConnection.Open();

            if(serviceStationConnection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Соединение с базой данных не установлено");
            }
        }

        private void EnterData_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"SELECT * FROM Users WHERE Login = @login AND Password = @password",
                serviceStationConnection);

            command.Parameters.AddWithValue("login", login.Text);
            command.Parameters.AddWithValue("password", password.Text);

            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                User user = new User(login.Text, password.Text);

                serviceStationConnection.Close();
                this.Close();

                thread = new Thread(open);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start(user);
            }
            else
                MessageBox.Show("Введен неверный логин или пароль");
            dataReader.Close();
        }

        public void open(object obj)
        {
            Application.Run(new MainForm((User)obj));
        }
    }
}
