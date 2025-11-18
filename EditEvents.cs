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
        private int selectedEventId;
        public EditEvents(int eventId)
        {
            InitializeComponent();
            selectedEventId = eventId;
            EditEvents_Load(this, EventArgs.Empty);
        }
        private void EditEvents_Load(object sender, EventArgs e)
        {
            string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT title, dateTime, description, location FROM groupjnk_event WHERE eventId = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedEventId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            titleBox.Text = reader["title"].ToString();

                            DateTime dt = Convert.ToDateTime(reader["dateTime"]);
                            dateBox.Text = dt.ToString("yyyy-MM-dd");
                            timeBox.Text = dt.ToString("HH:mm");

                            descriptionBox.Text = reader["description"].ToString();
                            locationBox.Text = reader["location"].ToString(); // new line
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


        private void saveButton_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    DateTime updatedDateTime = DateTime.Parse(dateBox.Text + " " + timeBox.Text);

                    string query = @"UPDATE groupjnk_event
                             SET title = @title, dateTime = @dateTime, description = @description, location = @location
                             WHERE eventId = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", titleBox.Text);
                    cmd.Parameters.AddWithValue("@dateTime", updatedDateTime);
                    cmd.Parameters.AddWithValue("@description", descriptionBox.Text);
                    cmd.Parameters.AddWithValue("@location", locationBox.Text); // new line
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
