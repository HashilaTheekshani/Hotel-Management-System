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

namespace Hotel_management_system
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Admin_MainPage adminpage = new Admin_MainPage();
            adminpage.Show();
            this.Hide();

            string connectionString = "Data Source=LAPTOP-AMHB72M8;Initial Catalog=HotelDB;Integrated Security=True";

            string username = login_username.Text;
            string Password = login_password.Text;


            string query = "SELECT COUNT(*) FROM login WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", Password);


                    connection.Open();


                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        Console.WriteLine("Login successful!");

                    }
                    else
                    {
                        Console.WriteLine("Login failed. Incorrect username or password.");

                    }
                }
            }

        }
    }
}
