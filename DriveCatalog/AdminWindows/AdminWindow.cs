using DriveCatalog.AdminWindows.Drive;
using DriveCatalog.AdminWindows.DriveChars;
using DriveCatalog.AdminWindows.Information;
using DriveCatalog.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriveCatalog.AdminWindows
{
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {
            ControlsWorker.FillDataGrid(dataGridView1, "SELECT * FROM DeviceVIEW");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlsWorker.FillDataGrid(dataGridView1, "SELECT * FROM DeviceVIEW");
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDriveCharsWindow window = new AddDriveCharsWindow();
            window.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDriveCharsWindow window = new DeleteDriveCharsWindow();
            window.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCapacityWindow window = new UpdateCapacityWindow();
            window.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddDrive addDrive = new AddDrive();
            addDrive.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteDriveWindow window = new DeleteDriveWindow();
            window.Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateDriveWindow window = new UpdateDriveWindow();
            window.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddInfoWindow window = new AddInfoWindow();
            window.Show();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteInfoWindow window = new DeleteInfoWindow();
            window.Show();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateInfoWindow window = new UpdateInfoWindow();
            window.Show();
        }
    }
}
