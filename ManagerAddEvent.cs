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
    public partial class ManagerAddEvent : Form
    {
        public ManagerAddEvent()
        {
            InitializeComponent();
            textBox4.Text = "employeenumber@company.com";
            participantList.Items.Add("employeenumber@company.com");
            eventTitleBox.Text = "Company picnic";
            eventDateBox.Text = "10/20/2025";
            eventTimeBox.Text = "12:00 PM";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ManagerAddEvent_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
