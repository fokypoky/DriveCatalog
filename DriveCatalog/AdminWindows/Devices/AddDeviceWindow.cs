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

namespace DriveCatalog.AdminWindows.Devices
{
    public partial class AddDeviceWindow : Form
    {
        public AddDeviceWindow()
        {
            InitializeComponent();
        }

        private void AddDeviceWindow_Load(object sender, EventArgs e)
        {
            string querry = "SELECT DISTINCT Manufacturer FROM DriveChars WHERE ID IN (SELECT CharsID FROM Drive) ORDER BY Manufacturer";
            ControlsWorker.FillComboBox(manufacturerComboBox, querry);
        }

        private void manufacturerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string manufacturer = manufacturerComboBox.SelectedItem.ToString();
            string querry = $"SELECT DISTINCT Model FROM DriveChars " +
                $"WHERE Manufacturer = '{manufacturer}' AND ID IN (SELECT CharsID FROM Drive)";
            ControlsWorker.FillComboBox(modelComboBox, querry);
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string manufacturer = manufacturerComboBox.SelectedItem.ToString();
            string model = modelComboBox.SelectedItem.ToString();
            string querry = $"SELECT DISTINCT [Type] FROM DriveChars WHERE Model = '{model}' " +
                $"AND Manufacturer = '{manufacturer}' AND ID IN (SELECT CharsID FROM Drive)";
            ControlsWorker.FillComboBox(typeComboBox, querry);
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string manuf = manufacturerComboBox.SelectedItem.ToString();
            string model = modelComboBox.SelectedItem.ToString();
            string type = typeComboBox.SelectedItem.ToString();

            string querry = $"SELECT Capacity FROM DriveChars WHERE Manufacturer = '{manuf}' " +
                $"AND Model = '{model}' AND [Type] = '{type}' AND ID IN (SELECT CharsID FROM Drive)";
            ControlsWorker.FillComboBox(capacityComboBox, querry);
        }

        private void capacityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string manuf = manufacturerComboBox.SelectedItem.ToString();
            string model = modelComboBox.SelectedItem.ToString();
            string type = typeComboBox.SelectedItem.ToString();
            string capacity = capacityComboBox.SelectedItem.ToString();

            string querry = $"SELECT Serial FROM Drive " +
                $"WHERE CharsID = (SELECT ID FROM DriveChars WHERE Manufacturer = '{manuf}' " +
                $"AND Model = '{model}' AND [Type] = '{type}' AND Capacity = {capacity})";
            ControlsWorker.FillComboBox(driveSerialComboBox, querry);
        }

        private void AddDriveButton_Click(object sender, EventArgs e)
        {
            string driveSerial = driveSerialComboBox.SelectedItem.ToString();
            string deviceSerial = deviceSerialTextBox.Text;
            string deviceName = deviceNameTextBox.Text;
            string drvCount = numericUpDown1.Value.ToString();

            string querry = $"EXECUTE dbo.AddDevice '{deviceName}', '{deviceSerial}', " +
                $"'{driveSerial}', {drvCount}";

            MessageBox.Show(DataWorker.Execute(querry));

        }
    }
}
