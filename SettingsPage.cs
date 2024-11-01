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
    public partial class SettingsPage : Form
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void updateAppBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application has restarted");
        }

        private void dayTimeBox_Click(object sender, EventArgs e)
        {

        }

        private void nightTimeBox_Click(object sender, EventArgs e)
        {

        }

        private void mainBox_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void carInfoBox_Click(object sender, EventArgs e)
        {
            CarInfo carInfoForm = new CarInfo();
            carInfoForm.Show();
        }

        private void controlsBox_Click(object sender, EventArgs e)
        {
            Controls controlsForm = new Controls();
            controlsForm.Show();
        }

    }
}
