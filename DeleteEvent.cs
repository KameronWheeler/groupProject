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
    public partial class DeleteEvent : Form
    {
        private int selectedEventId;

        public DeleteEvent(int eventId)
        {
            InitializeComponent();
            selectedEventId = eventId;
            DeleteEvent_Load(this, EventArgs.Empty);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DeleteEvent_Load(object sender, EventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            UserMenu userMenuForm = new UserMenu();
            userMenuForm.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this event?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM groupjnk_event WHERE eventId = @eventId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@eventId", selectedEventId);

                    int rowsDeleted = cmd.ExecuteNonQuery();

                    if (rowsDeleted > 0)
                    {
                        MessageBox.Show("Event deleted successfully.");
                        this.Close(); // close EditEvents
                    }
                    else
                    {
                        MessageBox.Show("Event could not be deleted.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            // go back to user menu
            this.Hide();
            UserMenu userMenuForm = new UserMenu();
            userMenuForm.Show();
            this.Hide();
        }

    }
}
