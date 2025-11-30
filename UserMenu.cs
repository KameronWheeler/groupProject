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

        // load event titles for selected date
        public void LoadEventTitlesForSelectedDate()
        {
            string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // get selected date from calendar
                    DateTime selectedDate = monthCalendar1.SelectionStart.Date;
                    // use full day range
                    DateTime nextDate = selectedDate.AddDays(1);

                    string query = @"SELECT DISTINCT e.title FROM groupjnk_event e LEFT JOIN groupjnk_created_event ce ON e.eventId = ce.eventId WHERE e.dateTime >= @startDate AND e.dateTime < @endDate AND (e.companyEvent = 1 OR ce.userId = @userId);";

                    // prepare statement with parameters
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@startDate", selectedDate);
                    cmd.Parameters.AddWithValue("@endDate", nextDate);
                    cmd.Parameters.AddWithValue("@userId", id);

                    // execute query
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

        // go to add event
        private void button5_Click(object sender, EventArgs e)
        {

            UserAddEvent addEventForm = new UserAddEvent();
            CurrentUser.selectedDate = monthCalendar1.SelectionStart.Date;

            addEventForm.Show();
            this.Hide();
        }

        // go to view events
        private void button1_Click(object sender, EventArgs e)
        {

            // check if anything is selected
            if (eventBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an event first.");
                return;
            }

            ViewEvents viewEventsForm = new ViewEvents();
            viewEventsForm.Show();
            this.Hide();
        }

        // go to edit events
        private void button2_Click(object sender, EventArgs e)
        {

            // check if anything is selected
            if (eventBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an event first.");
                return;
            }


            string title = eventBox.SelectedItem.ToString();
            // get the id for this event
            int id = getId(title);


            // check if this event is a company event
            bool isCompanyEvent = IsCompanyEvent(id);

            // if a user is not a manager, they cannot edit company events
            if (isCompanyEvent && !CurrentUser.isManager)
            {
                MessageBox.Show("You do not have permission to edit company-wide events.");
                return;
            }

            EditEvents editEventsForm = new EditEvents(id);
            editEventsForm.Show();
            this.Hide();
        }

        // get id for viewing, editing, or deleting
        private int getId(string title)
        {
            // make sure an event is selected
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
                    // get the id for this title
                    string query = "SELECT eventId FROM groupjnk_event WHERE title = @title LIMIT 1";
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

        // helper function to check if event is company event
        private bool IsCompanyEvent(int eventId)
        {
            string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            bool companyEvent = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // query to check if event is a company event
                string query = "SELECT companyEvent FROM groupjnk_event WHERE eventId = @eventId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@eventId", eventId);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    companyEvent = Convert.ToBoolean(result);
                }
            }

            return companyEvent;
        }


        // go to delete events
        private void button3_Click(object sender, EventArgs e)
        {

            // check if anything is selected
            if (eventBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an event first.");
                return;
            }


            string title = eventBox.SelectedItem.ToString();
            // get the id for this event
            int id = getId(title);

            // check if this event is a company event
            bool isCompanyEvent = IsCompanyEvent(id);

            // if a user is not a manager, they cannot edit company events
            if (isCompanyEvent && !CurrentUser.isManager)
            {
                MessageBox.Show("You do not have permission to edit company-wide events.");
                return;
            }

            DeleteEvent deleteEventForm = new DeleteEvent(id);
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
