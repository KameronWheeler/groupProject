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

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void eventTitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string title = (eventTitleBox.Text).Trim();
            string desc = (eventDescBox.Text).Trim();
            string location = (eventLocationBox.Text).Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Event title cannot be empty or whitespace.");
            }




            DateTime datePart;
            if (!DateTime.TryParse(eventDateBox.Text, out datePart))
            {
                MessageBox.Show("Invalid date format. Please enter a valid date.");
            }
            DateTime date = datePart.Date + dateTimePicker1.Value.TimeOfDay;
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            try
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    long eventID = -1;
                    using (var transaction = conn.BeginTransaction())
                    {

                        try
                        {
                            string insertionSQL = @"insert into groupjnk_event (title, dateTime, description, location, companyEvent) values (@title, @dateTime, @description, @location, @companyEvent);";

                            using (var command = new MySqlCommand(insertionSQL, conn, transaction))
                            {
                                command.Parameters.AddWithValue("@title", title);
                                command.Parameters.AddWithValue("@dateTime", date);
                                command.Parameters.AddWithValue("@description", desc);
                                command.Parameters.AddWithValue("@location", location);
                                if (isMeetingBox.Checked)
                                {
                                    command.Parameters.AddWithValue("@companyEvent", 1); //Company event
                                }
                                else
                                {
                                    command.Parameters.AddWithValue("@companyEvent", 0); //user-created event
                                }


                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    transaction.Commit();
                                    MessageBox.Show("Event added successfully.");
                                    this.Hide();
                                    var menu = Application.OpenForms.OfType<UserMenu>().FirstOrDefault();
                                    menu.Show();

                                }
                                else
                                {
                                    MessageBox.Show("Failed to add event.");
                                }
                                eventID = command.LastInsertedId;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                            transaction.Rollback();
                        }
                    }

                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string insertionSQL = @"insert into groupjnk_created_event (eventID, userID) values (@eventID, @userID);";

                            using (var command = new MySqlCommand(insertionSQL, conn, transaction))
                            {
                                command.Parameters.AddWithValue("@eventID", (int)eventID);
                                command.Parameters.AddWithValue("@userID", CurrentUser.id);



                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    transaction.Commit();
                                    MessageBox.Show("Entry added successfully.");
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

    }
}
