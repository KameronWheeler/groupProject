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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
            String User = CurrentUser.MySharedString;
            Console.WriteLine("Current User: " + User + " isManager: " + CurrentUser.isManager);
            label1.Text = "Welcome, " + User;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserAddEvent addEventForm = new UserAddEvent();
            addEventForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewEvents viewEventsForm = new ViewEvents();
            viewEventsForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditEvents editEventsForm = new EditEvents();
            editEventsForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteEvent deleteEventForm = new DeleteEvent();
            deleteEventForm.Show();
            this.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Console.WriteLine("Selected date: " + e.Start.ToShortDateString());
            CurrentUser.selectedDate = e.Start.ToShortDateString();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
