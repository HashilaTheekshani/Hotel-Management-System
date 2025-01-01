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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Signupbtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forgot_password forPass = new forgot_password();
            forPass.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            UserMainMenu userMain = new UserMainMenu();
            userMain.Show();
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
            

