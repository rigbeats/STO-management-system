using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            this.Text = "Справка";

        }
        internal string GetLabelText()
        { 
            return this.Text; 
        }

        internal void SetLabelText(string text)
        {
            helpLabel.Text = text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void helpLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
