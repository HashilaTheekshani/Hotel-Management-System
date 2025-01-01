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
    public partial class ViewPackage : Form
    {
        public ViewPackage()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Retrieve the Id of the selected package
            string selectedId = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();

            // Query to retrieve the selected package's details
            string query = "SELECT * FROM Packages WHERE Id = @Id";

            // Create a new SqlConnection
            using (SqlConnection connection = new SqlConnection())
            {
                // Create a new SqlCommand
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameter for the Id
                    command.Parameters.AddWithValue("@Id", selectedId);

                    // Create a new SqlDataAdapter
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Create a new DataTable to store the result
                        DataTable dataTable = new DataTable();

                        // Open the connection
                        connection.Open();

                        // Fill the DataTable with data from the query
                        adapter.Fill(dataTable);

                        // Close the connection
                        connection.Close();

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void hotelDBDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
    }

