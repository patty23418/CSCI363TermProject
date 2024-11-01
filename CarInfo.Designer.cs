namespace CSCI363Project
{
    partial class CarInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarInfo));
            panel1 = new Panel();
            pictureBox13 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox11 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            updateGPSBox = new PictureBox();
            label5 = new Label();
            settingsBox = new Button();
            controlsBox = new Button();
            carInfoBox = new Button();
            mainBox = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updateGPSBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(1, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 2);
            panel1.TabIndex = 24;
            // 
            // pictureBox13
            // 
            pictureBox13.Location = new Point(406, 0);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(28, 21);
            pictureBox13.TabIndex = 23;
            pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Location = new Point(335, 0);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(28, 21);
            pictureBox12.TabIndex = 22;
            pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Location = new Point(372, 0);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(28, 21);
            pictureBox11.TabIndex = 21;
            pictureBox11.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 7F);
            dateTimePicker1.Location = new Point(1, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(175, 20);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.Value = new DateTime(2024, 10, 23, 14, 0, 25, 0);
            // 
            // panel2
            // 
            panel2.Location = new Point(1, 374);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 2);
            panel2.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.Location = new Point(1, 484);
            panel3.Name = "panel3";
            panel3.Size = new Size(444, 2);
            panel3.TabIndex = 25;
            // 
            // panel5
            // 
            panel5.Location = new Point(1, 216);
            panel5.Name = "panel5";
            panel5.Size = new Size(444, 2);
            panel5.TabIndex = 25;
            // 
            // panel6
            // 
            panel6.Location = new Point(1, 165);
            panel6.Name = "panel6";
            panel6.Size = new Size(444, 2);
            panel6.TabIndex = 25;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(171, 27);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(5, 140);
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(28, 39);
            label1.Name = "label1";
            label1.Size = new Size(48, 28);
            label1.TabIndex = 27;
            label1.Text = "GPS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 180);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 28;
            label2.Text = "Driver Log:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 379);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 29;
            label3.Text = "Car Temperatures";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 489);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 30;
            label4.Text = "Battery Strength";
            // 
            // updateGPSBox
            // 
            updateGPSBox.BackColor = SystemColors.Control;
            updateGPSBox.Image = (Image)resources.GetObject("updateGPSBox.Image");
            updateGPSBox.Location = new Point(28, 70);
            updateGPSBox.Name = "updateGPSBox";
            updateGPSBox.Size = new Size(116, 61);
            updateGPSBox.SizeMode = PictureBoxSizeMode.StretchImage;
            updateGPSBox.TabIndex = 31;
            updateGPSBox.TabStop = false;
            updateGPSBox.Click += updateGPSBox_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(35, 134);
            label5.Name = "label5";
            label5.Size = new Size(93, 21);
            label5.TabIndex = 32;
            label5.Text = "Update GPS";
            // 
            // settingsBox
            // 
            settingsBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingsBox.Location = new Point(330, 584);
            settingsBox.Name = "settingsBox";
            settingsBox.Size = new Size(100, 54);
            settingsBox.TabIndex = 51;
            settingsBox.Text = "Settings";
            settingsBox.UseVisualStyleBackColor = true;
            settingsBox.Click += settingsBox_Click;
            // 
            // controlsBox
            // 
            controlsBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            controlsBox.Location = new Point(224, 584);
            controlsBox.Name = "controlsBox";
            controlsBox.Size = new Size(100, 54);
            controlsBox.TabIndex = 50;
            controlsBox.Text = "Controls";
            controlsBox.UseVisualStyleBackColor = true;
            controlsBox.Click += controlsBox_Click;
            // 
            // carInfoBox
            // 
            carInfoBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carInfoBox.Location = new Point(118, 584);
            carInfoBox.Name = "carInfoBox";
            carInfoBox.Size = new Size(100, 54);
            carInfoBox.TabIndex = 49;
            carInfoBox.Text = "Car Info";
            carInfoBox.UseVisualStyleBackColor = true;
            // 
            // mainBox
            // 
            mainBox.BackColor = Color.Transparent;
            mainBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainBox.Location = new Point(13, 584);
            mainBox.Name = "mainBox";
            mainBox.Size = new Size(100, 54);
            mainBox.TabIndex = 48;
            mainBox.Text = "Main";
            mainBox.UseVisualStyleBackColor = false;
            mainBox.Click += mainBox_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(150, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // CarInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(441, 650);
            Controls.Add(pictureBox1);
            Controls.Add(settingsBox);
            Controls.Add(controlsBox);
            Controls.Add(carInfoBox);
            Controls.Add(mainBox);
            Controls.Add(label5);
            Controls.Add(updateGPSBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(dateTimePicker1);
            Name = "CarInfo";
            Text = "CarInfo";
            Load += CarInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)updateGPSBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private PictureBox pictureBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox updateGPSBox;
        private Label label5;
        private Button settingsBox;
        private Button controlsBox;
        private Button carInfoBox;
        private Button mainBox;
        private PictureBox pictureBox1;
    }
}
