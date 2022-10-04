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
using DriveCatalog.AdminWindows.Information;


namespace DriveCatalog.UserWindows
{
    public partial class UserWindow : Form
    {
        public UserWindow()
        {
            InitializeComponent();
        }

        private void UserWindow_Load(object sender, EventArgs e)
        {
            ControlsWorker.FillDataGrid(dataGridView1, "SELECT * FROM InfoVIEW");
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlsWorker.FillDataGrid(dataGridView1, "SELECT * FROM InfoVIEW");
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInfoWindow window = new AddInfoWindow();
            window.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteInfoWindow window = new DeleteInfoWindow();
            window.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateInfoWindow window = new UpdateInfoWindow();
            window.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlsWorker.FillDataGrid(dataGridView1, "SELECT * FROM DriveVIEW");
        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ControlsWorker.FillDataGrid(dataGridView1, "SELECT * FROM DeviceVIEW");
        }
    }
}
