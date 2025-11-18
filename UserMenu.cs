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
        // current user's id
        private int id;
        public UserMenu()
        {
            InitializeComponent();
            id = CurrentUser.id;
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

                    string query = @"
                SELECT DISTINCT e.title
                FROM groupjnk_event e
                LEFT JOIN groupjnk_created_event ce
                    ON e.eventId = ce.eventId
                WHERE
                    e.dateTime >= @startDate
                    AND e.dateTime < @endDate
                    AND (
                        e.companyEvent = 1      -- company event
                        OR ce.userId = @userId  -- this user's event
                    );
            ";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@startDate", selectedDate);
                    cmd.Parameters.AddWithValue("@endDate", nextDate);
                    cmd.Parameters.AddWithValue("@userId", id);  // use your existing ID

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

        // go to edit events
        private void button2_Click(object sender, EventArgs e)
        {
            string title = eventBox.SelectedItem.ToString();
            // get the id for this event
            int id = getId(title);

            EditEvents editEventsForm = new EditEvents(id);
            editEventsForm.Show();
            this.Hide();
        }

        // get id for viewing, editing, or deleting
        private int getId(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please select an event first.");
                return -1;
            }

            int eventId = -1;
            string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT eventId FROM groupjnk_event WHERE title = @title LIMIT 1"; // get the id for this title
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", title);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        eventId = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Event not found in database.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return eventId;
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

        private void UserMenu_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
