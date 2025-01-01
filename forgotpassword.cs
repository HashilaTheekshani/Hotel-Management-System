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
    public partial class forgot_password : Form
    {
        
        private string connectionString = "Data Source=DESKTOP-SO53MSR\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;Trust Server Certificate=True";

        public forgot_password()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
           
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void resetPassword_btn_Click(object sender, EventArgs e)
        {
            string newPassword = new_password.Text;
            string confirmPassword = Confirm_password.Text;

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please enter a new password.");
                return;
            }

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please confirm your new password.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.");
                return;
            }

            
            string query = "UPDATE Users SET Password = @NewPassword";

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@NewPassword", newPassword);

                    
                    connection.Open();

                    
                    int rowsAffected = command.ExecuteNonQuery();

                    
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password reset successful. Your new password is: " + newPassword);
                    }
                    else
                    {
                        MessageBox.Show("Password reset failed.");
                    }
                }
            }
        }

        private void forgot_password_Load(object sender, EventArgs e)
        {

        }
    }
}