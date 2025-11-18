using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupProject
{
    public partial class UserAddEvent : Form
    {
        public UserAddEvent()
        {
            InitializeComponent();

        }

        private void UserAddEvent_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //cancel selected
        {
            this.Hide();
            var menu = Application.OpenForms.OfType<UserMenu>().FirstOrDefault();
            menu.Show();
            menu.BringToFront();
            menu.Activate();
        }

       
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }







    }
}