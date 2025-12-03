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
    public partial class ManagerAddEvent : Form
    {
        public ManagerAddEvent()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ManagerAddEvent_Load(object sender, EventArgs e)
        {
            eventDateBox.Text = CurrentUser.selectedDate.ToString("MM/dd/yyyy");
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "hh:mm tt";
            dateTimePicker1.ShowUpDown = true;
            anyEventBox_TextChanged(sender, e);//initial check to enable/disable save button
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void anyEventBox_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(eventTitleBox.Text) || String.IsNullOrWhiteSpace(eventLocationBox.Text))
            {//enabled so long as both title and location are not empty or whitespace
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void eventTitleBox_TextChanged(object sender, EventArgs e)
        {
            anyEventBox_TextChanged(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string title = (eventTitleBox.Text).Trim();
            string desc = (eventDescBox.Text).Trim();
            string location = (eventLocationBox.Text).Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Event title cannot be empty or whitespace.");
                return;
            }

            DateTime datePart;
            if (!DateTime.TryParse(eventDateBox.Text, out datePart))
            {
                MessageBox.Show("Invalid date format. Please enter a valid date.");
                return;
            }

            // Take the date part
            DateTime datePartOnly = datePart.Date;

            // Take the time part but drop seconds/milliseconds
            TimeSpan timePart = new TimeSpan(dateTimePicker1.Value.Hour, dateTimePicker1.Value.Minute, 0);

            // Combine into final DateTime
            DateTime date = datePartOnly + timePart;
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            try
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                   
                    string conflictSQL = @"SELECT COUNT(*) FROM groupjnk_event 
                                   WHERE dateTime = @dateTime;";
                    using (var conflictCmd = new MySqlCommand(conflictSQL, conn))
                    {
                        conflictCmd.Parameters.AddWithValue("@dateTime", date);
                        

                        int conflictCount = Convert.ToInt32(conflictCmd.ExecuteScalar());
                        if (conflictCount > 0)
                        {
                            MessageBox.Show("An event already exists at this time.");
                            return; // Stop execution
                        }
                    }

                    long eventID = -1;
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string insertionSQL = @"INSERT INTO groupjnk_event 
                        (title, dateTime, description, location, companyEvent) 
                        VALUES (@title, @dateTime, @description, @location, @companyEvent);";

                            using (var command = new MySqlCommand(insertionSQL, conn, transaction))
                            {
                                command.Parameters.AddWithValue("@title", title);
                                command.Parameters.AddWithValue("@dateTime", date);
                                command.Parameters.AddWithValue("@description", desc);
                                command.Parameters.AddWithValue("@location", location);
                                command.Parameters.AddWithValue("@companyEvent", isMeetingBox.Checked ? 1 : 0);

                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    transaction.Commit();
                                    eventID = command.LastInsertedId;

                                    this.Hide();
                                    var menu = Application.OpenForms.OfType<UserMenu>().FirstOrDefault();
                                    menu.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to add event.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                            transaction.Rollback();
                        }
                    }

                    // Second insert into created_event table
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string insertionSQL = @"INSERT INTO groupjnk_created_event (eventID, userID) 
                                            VALUES (@eventID, @userID);";

                            using (var command = new MySqlCommand(insertionSQL, conn, transaction))
                            {
                                command.Parameters.AddWithValue("@eventID", (int)eventID);
                                command.Parameters.AddWithValue("@userID", CurrentUser.id);

                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    transaction.Commit();
                                    this.Hide();
                                    var menu = Application.OpenForms.OfType<UserMenu>().FirstOrDefault();
                                    menu.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to add entry.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                            transaction.Rollback();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("Done.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = Application.OpenForms.OfType<UserMenu>().FirstOrDefault();
            menu.Show();
            menu.BringToFront();
            menu.Activate();
        }

        private void eventLocationBox_TextChanged(object sender, EventArgs e)
        {
            anyEventBox_TextChanged(sender, e);
        }

        private void eventDescBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
