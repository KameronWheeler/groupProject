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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace groupProject
{

    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            //label2.Text = "";
            //label2.Text = "Username/Password incorrect.";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            string connStr =
            "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM groupjnk_user WHERE Name=@name";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql,
                conn);
                cmd.Parameters.AddWithValue("@name", username);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    CurrentUser.MySharedString = myReader["Name"].ToString();
                    if (password == myReader["Password"].ToString())
                    {
                        // Successful login
                        if (myReader["isManager"].ToString().Equals("1"))
                        {
                            CurrentUser.isManager = true;
                        } else
                        {
                            CurrentUser.isManager = false;
                        }

                        UserMenu userMenu = new UserMenu();
                        userMenu.Show();
                        this.Hide();
                    } else
                    {
                        // Failed login
                        label2.Text = "Username/Password incorrect.";
                    }
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");

        }
    }
}
