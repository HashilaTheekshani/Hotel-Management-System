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
    public partial class UserMainMenu : Form
    {
        public UserMainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageReservationForm ManReserForm = new ManageReservationForm();
            ManReserForm.Show();
            this.Hide();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            
            ViewPackage viewpack = new ViewPackage();
            viewpack.Show();
            this.Hide();
        }
    }
}
