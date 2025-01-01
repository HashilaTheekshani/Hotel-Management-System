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
    public partial class ManagePackageForm : Form
    {
        public ManagePackageForm()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-AMHB72M8;Initial Catalog=HotelDB;Integrated Security=True"; // Replace "Your_Connection_String" with your actual connection string


            string id = login_username.Text;
            string name = login_password.Text;
            int costPerPerson = Convert.ToInt32(textBox1.Text);
            string description = textBox2.Text;
            string complementary = textBox5.Text;


            string query = @"INSERT INTO Packages (Id, Name, Cost_per_person, Description, Complementary)
                         VALUES (@Id, @Name, @CostPerPerson, @Description, @Complementary)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@CostPerPerson", costPerPerson);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Complementary", complementary);


                    connection.Open();


                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Insertion failed.");
                    }
                }
            }
        }

        private void textBoxdes_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

