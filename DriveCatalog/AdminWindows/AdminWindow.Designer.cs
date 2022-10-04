namespace DriveCatalog.AdminWindows
{
    partial class AdminWindow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.driveCharsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driveCharsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.devicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.querriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hAVINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cASEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nestedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correlatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whereFreeSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whereFreeSpaceIsMoreThan500GBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAMSUNGDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBrandsByDriveTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1211, 477);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driveCharsToolStripMenuItem,
            this.querriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1236, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // driveCharsToolStripMenuItem
            // 
            this.driveCharsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driveCharsToolStripMenuItem1,
            this.drivesToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.devicesToolStripMenuItem});
            this.driveCharsToolStripMenuItem.Name = "driveCharsToolStripMenuItem";
            this.driveCharsToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.driveCharsToolStripMenuItem.Text = "Data";
            // 
            // driveCharsToolStripMenuItem1
            // 
            this.driveCharsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.driveCharsToolStripMenuItem1.Name = "driveCharsToolStripMenuItem1";
            this.driveCharsToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.driveCharsToolStripMenuItem1.Text = "Drive chars";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // drivesToolStripMenuItem
            // 
            this.drivesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.deleteToolStripMenuItem1,
            this.updateToolStripMenuItem1});
            this.drivesToolStripMenuItem.Name = "drivesToolStripMenuItem";
            this.drivesToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.drivesToolStripMenuItem.Text = "Drives";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(141, 26);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(141, 26);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(141, 26);
            this.updateToolStripMenuItem1.Text = "Update";
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.updateToolStripMenuItem1_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2,
            this.deleteToolStripMenuItem2,
            this.updateToolStripMenuItem2});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(141, 26);
            this.addToolStripMenuItem2.Text = "Add";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.addToolStripMenuItem2_Click);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(141, 26);
            this.deleteToolStripMenuItem2.Text = "Delete";
            this.deleteToolStripMenuItem2.Click += new System.EventHandler(this.deleteToolStripMenuItem2_Click);
            // 
            // updateToolStripMenuItem2
            // 
            this.updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
            this.updateToolStripMenuItem2.Size = new System.Drawing.Size(141, 26);
            this.updateToolStripMenuItem2.Text = "Update";
            this.updateToolStripMenuItem2.Click += new System.EventHandler(this.updateToolStripMenuItem2_Click);
            // 
            // devicesToolStripMenuItem
            // 
            this.devicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem3,
            this.deleteToolStripMenuItem3,
            this.updateToolStripMenuItem3});
            this.devicesToolStripMenuItem.Name = "devicesToolStripMenuItem";
            this.devicesToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.devicesToolStripMenuItem.Text = "Devices";
            // 
            // addToolStripMenuItem3
            // 
            this.addToolStripMenuItem3.Name = "addToolStripMenuItem3";
            this.addToolStripMenuItem3.Size = new System.Drawing.Size(141, 26);
            this.addToolStripMenuItem3.Text = "Add";
            this.addToolStripMenuItem3.Click += new System.EventHandler(this.addToolStripMenuItem3_Click);
            // 
            // deleteToolStripMenuItem3
            // 
            this.deleteToolStripMenuItem3.Name = "deleteToolStripMenuItem3";
            this.deleteToolStripMenuItem3.Size = new System.Drawing.Size(141, 26);
            this.deleteToolStripMenuItem3.Text = "Delete";
            this.deleteToolStripMenuItem3.Click += new System.EventHandler(this.deleteToolStripMenuItem3_Click);
            // 
            // updateToolStripMenuItem3
            // 
            this.updateToolStripMenuItem3.Name = "updateToolStripMenuItem3";
            this.updateToolStripMenuItem3.Size = new System.Drawing.Size(141, 26);
            this.updateToolStripMenuItem3.Text = "Update";
            this.updateToolStripMenuItem3.Click += new System.EventHandler(this.updateToolStripMenuItem3_Click);
            // 
            // querriesToolStripMenuItem
            // 
            this.querriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hAVINGToolStripMenuItem,
            this.cASEToolStripMenuItem,
            this.nestedToolStripMenuItem,
            this.correlatedToolStripMenuItem});
            this.querriesToolStripMenuItem.Name = "querriesToolStripMenuItem";
            this.querriesToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.querriesToolStripMenuItem.Text = "Querries";
            // 
            // hAVINGToolStripMenuItem
            // 
            this.hAVINGToolStripMenuItem.Name = "hAVINGToolStripMenuItem";
            this.hAVINGToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hAVINGToolStripMenuItem.Text = "HAVING";
            this.hAVINGToolStripMenuItem.Click += new System.EventHandler(this.hAVINGToolStripMenuItem_Click);
            // 
            // cASEToolStripMenuItem
            // 
            this.cASEToolStripMenuItem.Name = "cASEToolStripMenuItem";
            this.cASEToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cASEToolStripMenuItem.Text = "CASE";
            this.cASEToolStripMenuItem.Click += new System.EventHandler(this.cASEToolStripMenuItem_Click);
            // 
            // nestedToolStripMenuItem
            // 
            this.nestedToolStripMenuItem.Name = "nestedToolStripMenuItem";
            this.nestedToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nestedToolStripMenuItem.Text = "Nested";
            this.nestedToolStripMenuItem.Click += new System.EventHandler(this.nestedToolStripMenuItem_Click);
            // 
            // correlatedToolStripMenuItem
            // 
            this.correlatedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whereFreeSpaceToolStripMenuItem,
            this.whereFreeSpaceIsMoreThan500GBToolStripMenuItem,
            this.sAMSUNGDevicesToolStripMenuItem,
            this.showBrandsByDriveTypeToolStripMenuItem});
            this.correlatedToolStripMenuItem.Name = "correlatedToolStripMenuItem";
            this.correlatedToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.correlatedToolStripMenuItem.Text = "Correlated";
            // 
            // whereFreeSpaceToolStripMenuItem
            // 
            this.whereFreeSpaceToolStripMenuItem.Name = "whereFreeSpaceToolStripMenuItem";
            this.whereFreeSpaceToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.whereFreeSpaceToolStripMenuItem.Text = "Where free space is more than half";
            this.whereFreeSpaceToolStripMenuItem.Click += new System.EventHandler(this.whereFreeSpaceToolStripMenuItem_Click);
            // 
            // whereFreeSpaceIsMoreThan500GBToolStripMenuItem
            // 
            this.whereFreeSpaceIsMoreThan500GBToolStripMenuItem.Name = "whereFreeSpaceIsMoreThan500GBToolStripMenuItem";
            this.whereFreeSpaceIsMoreThan500GBToolStripMenuItem.Size = new System.Drawing.Size(376, 26);
            this.whereFreeSpaceIsMoreThan500GBToolStripMenuItem.Text = "Where info volume is more than free space";
            this.whereFreeSpaceIsMoreThan500GBToolStripMenuItem.Click += new System.EventHandler(this.whereFreeSpaceIsMoreThan500GBToolStripMenuItem_Click);
            // 
            // sAMSUNGDevicesToolStripMenuItem
            // 
            this.sAMSUNGDevicesToolStripMenuItem.Name = "sAMSUNGDevicesToolStripMenuItem";
            this.sAMSUNGDevicesToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.sAMSUNGDevicesToolStripMenuItem.Text = "SAMSUNG devices";
            this.sAMSUNGDevicesToolStripMenuItem.Click += new System.EventHandler(this.sAMSUNGDevicesToolStripMenuItem_Click);
            // 
            // showBrandsByDriveTypeToolStripMenuItem
            // 
            this.showBrandsByDriveTypeToolStripMenuItem.Name = "showBrandsByDriveTypeToolStripMenuItem";
            this.showBrandsByDriveTypeToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.showBrandsByDriveTypeToolStripMenuItem.Text = "Show brands";
            this.showBrandsByDriveTypeToolStripMenuItem.Click += new System.EventHandler(this.showBrandsByDriveTypeToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminWindow";
            this.Text = "AdminWindow";
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem driveCharsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driveCharsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem devicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem querriesToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem hAVINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cASEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nestedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correlatedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whereFreeSpaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whereFreeSpaceIsMoreThan500GBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAMSUNGDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBrandsByDriveTypeToolStripMenuItem;
    }
}