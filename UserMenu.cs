using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            // load todays events to start
            LoadEventTitlesForSelectedDate();
            string User = CurrentUser.MySharedString;
            Console.WriteLine("Current User: " + User + " isManager: " + CurrentUser.isManager);
            label1.Text = "Welcome, " + User;

        }

        public void LoadEventTitlesForSelectedDate()
        {
            string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    DateTime selectedDate = monthCalendar1.SelectionStart.Date;
                    DateTime nextDate = selectedDate.AddDays(1);

                    string query = "SELECT title FROM groupjnk_event WHERE dateTime >= @startDate AND dateTime < @endDate";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@startDate", selectedDate);
                    cmd.Parameters.AddWithValue("@endDate", nextDate);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        eventBox.Items.Clear();

                        while (reader.Read())
                        {
                            eventBox.Items.Add(reader["title"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
            LoadEventTitlesForSelectedDate();
        }
    }
}
