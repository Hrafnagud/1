using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsFormsApp
{
    public partial class FormEmre : Form
    {
        public FormEmre()   //Can access here from the Form.cs Properties!
        {
            InitializeComponent();
            Text = "Welcome to Emre's Form!";
            BackColor = Color.Blue;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            if (textUsername.Text == "Admin" && textPassword.Text == "12345")
            {
                MessageBox.Show($"Logged in as {textUsername.Text}!");
            }
            else
            {
                MessageBox.Show("Unauthorized user thou art! MotherFucker?!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
