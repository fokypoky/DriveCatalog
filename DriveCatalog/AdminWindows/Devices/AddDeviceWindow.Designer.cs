namespace DriveCatalog.AdminWindows.Devices
{
    partial class AddDeviceWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.deviceNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deviceSerialTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.manufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.capacityComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.AddDriveButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.driveSerialComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device name";
            // 
            // deviceNameTextBox
            // 
            this.deviceNameTextBox.Location = new System.Drawing.Point(11, 46);
            this.deviceNameTextBox.Name = "deviceNameTextBox";
            this.deviceNameTextBox.Size = new System.Drawing.Size(234, 22);
            this.deviceNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Device serial";
            // 
            // deviceSerialTextBox
            // 
            this.deviceSerialTextBox.Location = new System.Drawing.Point(11, 94);
            this.deviceSerialTextBox.Name = "deviceSerialTextBox";
            this.deviceSerialTextBox.Size = new System.Drawing.Size(234, 22);
            this.deviceSerialTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Manufacturer";
            // 
            // manufacturerComboBox
            // 
            this.manufacturerComboBox.FormattingEnabled = true;
            this.manufacturerComboBox.Location = new System.Drawing.Point(13, 142);
            this.manufacturerComboBox.Name = "manufacturerComboBox";
            this.manufacturerComboBox.Size = new System.Drawing.Size(237, 24);
            this.manufacturerComboBox.TabIndex = 5;
            this.manufacturerComboBox.SelectedIndexChanged += new System.EventHandler(this.manufacturerComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Model";
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(11, 186);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(239, 24);
            this.modelComboBox.TabIndex = 7;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(11, 232);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(239, 24);
            this.typeComboBox.TabIndex = 9;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Capacity";
            // 
            // capacityComboBox
            // 
            this.capacityComboBox.FormattingEnabled = true;
            this.capacityComboBox.Location = new System.Drawing.Point(11, 277);
            this.capacityComboBox.Name = "capacityComboBox";
            this.capacityComboBox.Size = new System.Drawing.Size(239, 24);
            this.capacityComboBox.TabIndex = 11;
            this.capacityComboBox.SelectedIndexChanged += new System.EventHandler(this.capacityComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Drives count";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 369);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(239, 22);
            this.numericUpDown1.TabIndex = 13;
            // 
            // AddDriveButton
            // 
            this.AddDriveButton.Location = new System.Drawing.Point(13, 398);
            this.AddDriveButton.Name = "AddDriveButton";
            this.AddDriveButton.Size = new System.Drawing.Size(239, 59);
            this.AddDriveButton.TabIndex = 15;
            this.AddDriveButton.Text = "Add drive";
            this.AddDriveButton.UseVisualStyleBackColor = true;
            this.AddDriveButton.Click += new System.EventHandler(this.AddDriveButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Drive serial";
            // 
            // driveSerialComboBox
            // 
            this.driveSerialComboBox.FormattingEnabled = true;
            this.driveSerialComboBox.Location = new System.Drawing.Point(11, 321);
            this.driveSerialComboBox.Name = "driveSerialComboBox";
            this.driveSerialComboBox.Size = new System.Drawing.Size(239, 24);
            this.driveSerialComboBox.TabIndex = 17;
            // 
            // AddDeviceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 465);
            this.Controls.Add(this.driveSerialComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddDriveButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.capacityComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.manufacturerComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deviceSerialTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deviceNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddDeviceWindow";
            this.Text = "AddDeviceWindow";
            this.Load += new System.EventHandler(this.AddDeviceWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deviceNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deviceSerialTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox manufacturerComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox capacityComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button AddDriveButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox driveSerialComboBox;
    }
}