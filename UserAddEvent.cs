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
            UserMenu userMenu = new UserMenu();
            userMenu.Show();
            this.Hide();
        }

       
    }
}
