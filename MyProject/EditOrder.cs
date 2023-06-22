using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class EditOrder : Form
    {
        public EditOrder()
        {
            InitializeComponent();
            this.Text = "Редактирование заявки";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
