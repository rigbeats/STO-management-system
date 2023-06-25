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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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

            login.Text = "Введите логин";
            login.ForeColor = Color.Gray;
            login.SelectionStart = 0;

            password.Text = "Введите пароль";
            password.ForeColor = Color.Gray;
            password.SelectionStart = 0;
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

        private void login_Click(object sender, EventArgs e)
        {
            if (login.Text == "Введите логин")
            {
                login.Text = "";
                login.ForeColor = Color.Black;
            }
        }

        private void password_Click(object sender, EventArgs e)
        {
            if (password.Text == "Введите пароль")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
                password.PasswordChar = '*';
            }
        }

        private void login_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(login.Text))
            {
                login.Text = "Введите логин";
                login.ForeColor = Color.Gray;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password.Text))
            {
                password.Text = "Введите пароль";
                password.ForeColor = Color.Gray;
                password.PasswordChar = '\0' ;
            }
        }
    }
}
