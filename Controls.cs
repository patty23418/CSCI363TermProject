using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI363Project
{
    public partial class Controls : Form
    {
        public Controls()
        {
            InitializeComponent();
        }

        private void Controls_Load(object sender, EventArgs e)
        {

        }


        private void driver1Box_Click(object sender, EventArgs e)
        {
            DriverInfo driver = new DriverInfo();
            driver.Show();
        }

        private void driver2Box_Click(object sender, EventArgs e)
        {
            DriverInfo driver = new DriverInfo();
            driver.Show();
        }

        private void addDriverBox_Click(object sender, EventArgs e)
        {
            DriverInfo driver = new DriverInfo();
            driver.Show();
        }

        private void vehicle1Box_Click(object sender, EventArgs e)
        {

        }

        private void vehicle2Box_Click(object sender, EventArgs e)
        {

        }

        private void addVehicleBox_Click(object sender, EventArgs e)
        {

        }

        private void mainBox_Click(object sender, EventArgs e)
        {

        }

        private void carInfoBox_Click(object sender, EventArgs e)
        {
            CarInfo carInfoForm = new CarInfo();
            carInfoForm.Show();
        }

        private void settingsBox_Click(object sender, EventArgs e)
        {
            SettingsPage settingsForm = new SettingsPage();
            settingsForm.Show();
        }
    }
}
