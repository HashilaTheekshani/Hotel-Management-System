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
    public partial class Admin_MainPage : Form
    {
        public Admin_MainPage()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            ManagePackageForm manPack = new ManagePackageForm();
            manPack.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageStaffForm manstaff = new ManageStaffForm();
            manstaff.Show();
            this.Hide();
        }
    }
}
