using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_management_system
{
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginbtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showPass.Checked ? '\0' : '*';
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-SO53MSR\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;Trust Server Certificate=True"; // Replace "Your_Connection_String" with your actual connection string

            
            string username = signup_username.Text;
            string Email = textBox1.Text;
            string Password = signup_password.Text;

           
            string query = "INSERT INTO login (Username, Password, Email) VALUES (@Username, @Password, @Email)";

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Email", Email);

                    
                    connection.Open();

                    
                    int rowsAffected = command.ExecuteNonQuery();

                    
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful.");
                    }
                    else
                    {
                        MessageBox.Show("Registration failed.");
                    }
                }
            }
             Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
