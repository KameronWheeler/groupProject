using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupProject
{
    public partial class UserAddEvent : Form
    {

        

        public UserAddEvent()
        {
            InitializeComponent();
           

        }

        private void UserAddEvent_Load(object sender, EventArgs e)
        {
            eventDateBox.Text = CurrentUser.selectedDate.ToString("MM/dd/yyyy");
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "hh:mm tt";
            dateTimePicker1.ShowUpDown = true;
            if (eventTitleBox.Text == "")
            {
                button3.Enabled = false;
            }
            else if (eventDateBox.Text == "")
            {
                button3.Enabled = false;
            }
            else if (dateTimePicker1.Value == null)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string title = (eventTitleBox.Text).Trim();
            string desc = (eventDescBox.Text).Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Event title cannot be empty or whitespace.");
            }

            


            DateTime datePart;
            if(!DateTime.TryParse(eventDateBox.Text, out datePart)){
                MessageBox.Show("Invalid date format. Please enter a valid date.");
            }
            DateTime date = datePart.Date + dateTimePicker1.Value.TimeOfDay;
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            try
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string insertionSQL = @"insert into groupjnk_event (title, dateTime, description, ) values (@title, @dateTime, @description);";

                            using (var command = new MySqlCommand(insertionSQL, conn, transaction))
                            {
                                command.Parameters.AddWithValue("@title", title);
                                command.Parameters.AddWithValue("@dateTime", date);
                                command.Parameters.AddWithValue("@description", desc);


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

        private void button4_Click(object sender, EventArgs e) //cancel selected
        {
            this.Hide();
            var menu = Application.OpenForms.OfType<UserMenu>().FirstOrDefault();
            menu.Show();
            menu.BringToFront();
            menu.Activate();
        }

       
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dateBox_TextChanged(object sender, EventArgs e)
        {
            if (eventTitleBox.Text == "")
            {
                button3.Enabled = false;
            }
            else if (eventDateBox.Text == "")
            {
                button3.Enabled = false;
            }
            else if (dateTimePicker1.Value == null)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (eventTitleBox.Text == "")
            {
                button3.Enabled = false;
            }
            else if (eventDateBox.Text == "")
            {
                button3.Enabled = false;
            }
            else if (dateTimePicker1.Value == null)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void eventTitleBox_TextChanged(object sender, EventArgs e)
        {
            if (eventTitleBox.Text == "")
            {
                button3.Enabled = false;
            }
            else if (eventDateBox.Text == "")
            {
                button3.Enabled = false;
            }
            else if (dateTimePicker1.Value == null)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }
    }
}