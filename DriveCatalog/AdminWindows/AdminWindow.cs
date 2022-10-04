using DriveCatalog.AdminWindows.Devices;
using DriveCatalog.AdminWindows.Drive;
using DriveCatalog.AdminWindows.DriveChars;
using DriveCatalog.AdminWindows.Information;
using DriveCatalog.Data;
using System;
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

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddDeviceWindow window = new AddDeviceWindow();
            window.Show();
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DeleteDeviceWindow window = new DeleteDeviceWindow();
            window.Show();
        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UpdateDrivesCountWindow window = new UpdateDrivesCountWindow();
            window.Show();
        }

        private void hAVINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string querry = $"SELECT Manufacturer AS [Brand], COUNT(*) AS [Drives count] " +
                $"FROM DriveChars GROUP BY Manufacturer HAVING COUNT(*) > 1 " +
                $"ORDER BY Manufacturer";
            ControlsWorker.FillDataGrid(dataGridView1, querry);
        }

        private void cASEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string querry = "SELECT [Device Title], [Device Serial] FROM DeviceVIEW dv " +
                "WHERE dv.[File System] IN " +
                "(SELECT CASE " +
                "WHEN dv.[File System] = 'NTFS' " +
                "THEN dv.[File System] " +
                "ELSE " +
                "NULL " +
                "END " +
                "FROM DeviceVIEW)";
            ControlsWorker.FillDataGrid(dataGridView1, querry);
        }

        private void nestedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string querry = "SELECT (SELECT Manufacturer FROM DriveChars WHERE ID = d.CharsID) AS [Brand], " +
                "(SELECT Model FROM DriveChars WHERE ID = d.CharsID) AS [Model], " +
                "(SELECT [Type] FROM DriveChars WHERE ID = d.CharsID) AS [DriveType], " +
                "d.Serial AS [Serial], d.PYear AS [Purchase year] FROM (SELECT * FROM Drive WHERE PYear >= 2020) d " +
                "WHERE d.FreeSpace = (SELECT Capacity FROM DriveChars WHERE ID = d.CharsID)";
            ControlsWorker.FillDataGrid(dataGridView1, querry);
        }

        private void whereFreeSpaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string querry = "SELECT Manufacturer, Model, [Type], Capacity FROM DriveChars dc WHERE ID IN (SELECT CharsID FROM Drive d WHERE d.FreeSpace >= (dc.Capacity / 2))";
            ControlsWorker.FillDataGrid(dataGridView1, querry);
        }

        private void whereFreeSpaceIsMoreThan500GBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM Information inf WHERE DriveID IN (SELECT ID FROM Drive d WHERE d.FreeSpace < inf.Volume);";
            ControlsWorker.FillDataGrid(dataGridView1, querry);
        }

        private void sAMSUNGDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string querry = "SELECT Title, Serial FROM Device d " +
                "WHERE (SELECT Manufacturer FROM DriveChars dc WHERE dc.ID = (SELECT CharsID FROM Drive drv WHERE drv.ID = d.DriveID)) = 'SAMSUNG';";
            ControlsWorker.FillDataGrid(dataGridView1, querry);
        }

        private void showBrandsByDriveTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM dbo.ShowBrands('SSD')";
            ControlsWorker.FillDataGrid(dataGridView1, querry);
        }
    }
}
