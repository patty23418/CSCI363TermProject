using System;
using System.Windows.Forms;

namespace CSCI363Project
{
    public partial class MainPage : Form
    {
        private bool engineOn=false;
        private bool alarmOn = false;
        private bool doorsLocked = false;
        private bool sunroofOpen = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void engineBox_Click(object sender, EventArgs e)
        {
            engineOn = !engineOn;
            MessageBox.Show(engineOn ? "Engine is now ON" : "Engine is now OFF", "Engine Status");


        }

        private void doorBox_Click(object sender, EventArgs e)
        {
            doorsLocked = !doorsLocked;
            MessageBox.Show(doorsLocked ? "Doors are now Locked" : "Doors are now Unlocked","Door Status");

        }

        private void upWindowBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Window has been rolled up");

        }

        private void downWindowBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Window has been rolled down");

        }

        private void sunroofBox_Click(object sender, EventArgs e)
        {
            sunroofOpen = !sunroofOpen;
            MessageBox.Show(sunroofOpen ? "Sunroof has been opened" : "Sunroof has been closed", "Sunroof Status");

        }

        private void alarmBox_Click(object sender, EventArgs e)
        {
            alarmOn = !alarmOn;
            MessageBox.Show(alarmOn ? "Alarm has been turned on" : "Alarm has been turned off", "Alarm Status");

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

        private void settingsBox_Click(object sender, EventArgs e)
        {
            SettingsPage settingsForm = new SettingsPage();
            settingsForm.Show();
        }
    }
}
