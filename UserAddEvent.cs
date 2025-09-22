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
            eventTitleBox.Text = "Dr. Appointment";
            dateBox.Text = "09/25/2025";
            timeBox.Text = "10:00 AM";
            descBox.Text = "Annual physical check-up.";

        }

        private void UserAddEvent_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                   
        }
    }
}
