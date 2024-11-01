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
    public partial class CarInfo : Form
    {
        public CarInfo()
        {
            InitializeComponent();
        }

        private void CarInfo_Load(object sender, EventArgs e)
        {

        }


        private void updateGPSBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GPS has been updated");
        }

        private void mainBox_Click(object sender, EventArgs e)
        {

        }


        private void controlsBox_Click(object sender, EventArgs e)
        {
            Controls controlsForm = new Controls();
            controlsForm.Show();
        }

        private void settingsBox_Click(object sender, EventArgs e)
        {
            SettingsPage settingsForm = new SettingsPage();
            settingsForm.Show();
        }

    }
}
