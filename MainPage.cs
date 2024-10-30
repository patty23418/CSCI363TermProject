using System;
using System.Windows.Forms;

namespace CSCI363Project
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void engineBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Engine has turned on");
        }

        private void doorBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Doors have been unlocked");

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
            MessageBox.Show("Sunroof has been opened");

        }

        private void alarmBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alarm has been turned on");

        }

        private void mainBox_Click(object sender, EventArgs e)
        {

        }

        private void carInfoBox_Click(object sender, EventArgs e)
        {

        }

        private void controlsBox_Click(object sender, EventArgs e)
        {

        }

        private void settingsBox_Click(object sender, EventArgs e)
        {

        }
    }
}
