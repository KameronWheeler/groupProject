using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace groupProject
{
    public partial class ViewEvents : Form
    {
        // current user's id
        private int id;
        public ViewEvents()
        {
            InitializeComponent();
            id = CurrentUser.id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserMenu userMenuForm = new UserMenu();
            userMenuForm.Show();
            this.Hide();
        }

        private void ViewEvents_Load(object sender, EventArgs e)
        {
            DateTime selectedDate = CurrentUser.selectedDate;
            String selectedEventTitle = CurrentUser.selectedEventTitle;

            textBox2.Text = selectedEventTitle;

            if (!string.IsNullOrEmpty(selectedEventTitle))
            {
                Console.WriteLine("Selected Event Title: " + selectedEventTitle);
                // Fetch event details from the database
                string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
                try
                {
                    using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT description, dateTime FROM groupjnk_event WHERE title = @title";
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@title", selectedEventTitle);
                        cmd.Parameters.AddWithValue("@userId", id);
                        using (MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string description = reader["description"].ToString();
                                DateTime eventDateTime = Convert.ToDateTime(reader["dateTime"]);
                                textBox1.Text = description;
                                textBox3.Text = eventDateTime.ToString("MM/dd/yyyy");
                                textBox4.Text = eventDateTime.ToString("hh:mm tt");
                            }
                            else
                            {
                                MessageBox.Show("Event not found in database.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}