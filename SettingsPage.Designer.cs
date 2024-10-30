namespace CSCI363Project
{
    partial class SettingsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPage));
            panel1 = new Panel();
            pictureBox13 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox11 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            updateAppBox = new PictureBox();
            nightTimeBox = new PictureBox();
            dayTimeBox = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            label11 = new Label();
            label12 = new Label();
            checkedListBox1 = new CheckedListBox();
            settingsBox = new Button();
            controlsBox = new Button();
            carInfoBox = new Button();
            mainBox = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updateAppBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nightTimeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dayTimeBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(-1, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 2);
            panel1.TabIndex = 24;
            // 
            // pictureBox13
            // 
            pictureBox13.Location = new Point(404, 1);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(28, 21);
            pictureBox13.TabIndex = 23;
            pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Location = new Point(333, 1);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(28, 21);
            pictureBox12.TabIndex = 22;
            pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Location = new Point(370, 1);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(28, 21);
            pictureBox11.TabIndex = 21;
            pictureBox11.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 7F);
            dateTimePicker1.Location = new Point(-1, 1);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(175, 20);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.Value = new DateTime(2024, 10, 23, 14, 0, 25, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(218, 32);
            label1.TabIndex = 28;
            label1.Text = "Update Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(8, 293);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 29;
            label2.Text = "Application Modes";
            // 
            // panel2
            // 
            panel2.Location = new Point(-1, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 2);
            panel2.TabIndex = 25;
            // 
            // updateAppBox
            // 
            updateAppBox.Image = (Image)resources.GetObject("updateAppBox.Image");
            updateAppBox.Location = new Point(98, 87);
            updateAppBox.Name = "updateAppBox";
            updateAppBox.Size = new Size(211, 151);
            updateAppBox.SizeMode = PictureBoxSizeMode.StretchImage;
            updateAppBox.TabIndex = 30;
            updateAppBox.TabStop = false;
            updateAppBox.Click += updateAppBox_Click;
            // 
            // nightTimeBox
            // 
            nightTimeBox.Location = new Point(333, 325);
            nightTimeBox.Name = "nightTimeBox";
            nightTimeBox.Size = new Size(42, 37);
            nightTimeBox.TabIndex = 32;
            nightTimeBox.TabStop = false;
            nightTimeBox.Click += nightTimeBox_Click;
            // 
            // dayTimeBox
            // 
            dayTimeBox.Location = new Point(141, 329);
            dayTimeBox.Name = "dayTimeBox";
            dayTimeBox.Size = new Size(50, 33);
            dayTimeBox.TabIndex = 33;
            dayTimeBox.TabStop = false;
            dayTimeBox.Click += dayTimeBox_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(-1, 373);
            panel3.Name = "panel3";
            panel3.Size = new Size(444, 2);
            panel3.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 378);
            label3.Name = "label3";
            label3.Size = new Size(179, 21);
            label3.TabIndex = 34;
            label3.Text = "Enable/Disable Features:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(31, 329);
            label11.Name = "label11";
            label11.Size = new Size(71, 21);
            label11.TabIndex = 42;
            label11.Text = "Daytime:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(240, 329);
            label12.Name = "label12";
            label12.Size = new Size(87, 21);
            label12.TabIndex = 43;
            label12.Text = "Night time:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.White;
            checkedListBox1.Font = new Font("Segoe UI", 11F);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Start/Stop Engine", "Lock/Unlock Doors", "Windows", "Alarm", "GPS", "Add Driver", "Add Vehicle" });
            checkedListBox1.Location = new Point(12, 410);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(420, 158);
            checkedListBox1.TabIndex = 44;
            // 
            // settingsBox
            // 
            settingsBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingsBox.Location = new Point(331, 588);
            settingsBox.Name = "settingsBox";
            settingsBox.Size = new Size(100, 54);
            settingsBox.TabIndex = 56;
            settingsBox.Text = "Settings";
            settingsBox.UseVisualStyleBackColor = true;
            settingsBox.Click += settingsBox_Click;
            // 
            // controlsBox
            // 
            controlsBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            controlsBox.Location = new Point(225, 588);
            controlsBox.Name = "controlsBox";
            controlsBox.Size = new Size(100, 54);
            controlsBox.TabIndex = 55;
            controlsBox.Text = "Controls";
            controlsBox.UseVisualStyleBackColor = true;
            controlsBox.Click += controlsBox_Click;
            // 
            // carInfoBox
            // 
            carInfoBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carInfoBox.Location = new Point(119, 588);
            carInfoBox.Name = "carInfoBox";
            carInfoBox.Size = new Size(100, 54);
            carInfoBox.TabIndex = 54;
            carInfoBox.Text = "Car Info";
            carInfoBox.UseVisualStyleBackColor = true;
            carInfoBox.Click += carInfoBox_Click;
            // 
            // mainBox
            // 
            mainBox.BackColor = Color.Transparent;
            mainBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainBox.Location = new Point(14, 588);
            mainBox.Name = "mainBox";
            mainBox.Size = new Size(100, 54);
            mainBox.TabIndex = 53;
            mainBox.Text = "Main";
            mainBox.UseVisualStyleBackColor = false;
            mainBox.Click += mainBox_Click;
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(443, 654);
            Controls.Add(settingsBox);
            Controls.Add(controlsBox);
            Controls.Add(carInfoBox);
            Controls.Add(mainBox);
            Controls.Add(checkedListBox1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(dayTimeBox);
            Controls.Add(nightTimeBox);
            Controls.Add(updateAppBox);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(dateTimePicker1);
            Name = "SettingsPage";
            Text = "SettingsPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)updateAppBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)nightTimeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dayTimeBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private PictureBox updateAppBox;
        private PictureBox nightTimeBox;
        private PictureBox dayTimeBox;
        private Panel panel3;
        private Label label3;
        private Label label11;
        private Label label12;
        private CheckedListBox checkedListBox1;
        private Button settingsBox;
        private Button controlsBox;
        private Button carInfoBox;
        private Button mainBox;
    }
}
