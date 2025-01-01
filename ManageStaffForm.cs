using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_management_system
{
    public partial class ManageStaffForm : Form
    {
        public ManageStaffForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set the filter to allow only image files
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            // Set the title of the dialog
            openFileDialog1.Title = "Select an Image File";

            // Show the dialog and check if the user selected a file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Set the PictureBox's Image property to the selected image
                    pictureBox1.Image = new System.Drawing.Bitmap(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    // Handle any potential exceptions
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
