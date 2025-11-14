using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupProject
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            //label2.Text = "";
            //label2.Text = "Username/Password incorrect.";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            // Simple hardcoded authentication for demonstration purposes
            if (username == "admin" && password == "password")
            {
                // Successful login
                UserMenu userMenu = new UserMenu();
                userMenu.Show();
                this.Hide();
            }
            else
            {
                // Failed login
                label2.Text = "Username/Password incorrect.";
            }

            //something
        }
    }
}
