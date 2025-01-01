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

namespace Hotel_management_system
{
    public partial class ManageReservationForm : Form
    {
        public ManageReservationForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Selected date: " + dateTimePicker1.Value.ToShortDateString());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-AMHB72M8;Initial Catalog=HotelDB;Integrated Security=True"; 

            
            string id = login_username.Text;
            string name = login_password.Text;
            string email = textBox1.Text;
            int mobile = Convert.ToInt32(textBox2.Text);
            DateTime resDate = dateTimePicker1.Value;
            int noOfPax = Convert.ToInt32(numericUpDown1.Text);
            int totalCost = Convert.ToInt32(textBox5.Text);

            
            string query = @"INSERT INTO Reservations (id, name, email, mobile, resdate, no_of_pax, total_cost)
                         VALUES (@Id, @Name, @Email, @Mobile, @ResDate, @NoOfPax, @TotalCost)";

           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Mobile", mobile);
                    command.Parameters.AddWithValue("@ResDate", resDate);
                    command.Parameters.AddWithValue("@NoOfPax", noOfPax);
                    command.Parameters.AddWithValue("@TotalCost", totalCost);
                    
                    connection.Open();

                    
                    int rowsAffected = command.ExecuteNonQuery();

                    
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Insertion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}

