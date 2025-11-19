using MySql.Data.MySqlClient;
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
    public partial class EditEvents : Form
    {
        // keep track of selected event id
        private int selectedEventId;
        public EditEvents(int eventId)
        {
            InitializeComponent();
            // store selected event id
            selectedEventId = eventId;
            // load event info
            EditEvents_Load(this, EventArgs.Empty);
        }

        // load event info into boxes to edit
        private void EditEvents_Load(object sender, EventArgs e)
        {
            string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    // get event info
                    string query = "SELECT title, dateTime, description, location FROM groupjnk_event WHERE eventId = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedEventId);

                    // execute query
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            titleBox.Text = reader["title"].ToString();

                            // parse date and time
                            DateTime dt = Convert.ToDateTime(reader["dateTime"]);
                            dateBox.Text = dt.ToString("yyyy-MM-dd");
                            timeBox.Text = dt.ToString("HH:mm");

                            descriptionBox.Text = reader["description"].ToString();
                            locationBox.Text = reader["location"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Event not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // save updated event info
        private void saveButton_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // parse date and time
                    DateTime updatedDateTime = DateTime.Parse(dateBox.Text + " " + timeBox.Text);

                    // set relavent info
                    string query = @"UPDATE groupjnk_event SET title = @title, dateTime = @dateTime, description = @description, location = @location WHERE eventId = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", titleBox.Text);
                    cmd.Parameters.AddWithValue("@dateTime", updatedDateTime);
                    cmd.Parameters.AddWithValue("@description", descriptionBox.Text);
                    cmd.Parameters.AddWithValue("@location", locationBox.Text);
                    cmd.Parameters.AddWithValue("@id", selectedEventId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Event updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating event: " + ex.Message);
            }
        }



        // return to user menu
        private void button2_Click(object sender, EventArgs e)
        {
            UserMenu userMenuForm = new UserMenu();
            userMenuForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
