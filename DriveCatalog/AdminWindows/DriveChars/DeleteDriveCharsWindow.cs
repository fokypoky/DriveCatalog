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

namespace DriveCatalog.AdminWindows.DriveChars
{
    public partial class DeleteDriveCharsWindow : Form
    {
        public DeleteDriveCharsWindow()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string manufacturer = $"'{comboBox1.SelectedItem.ToString()}'";
            ControlsWorker.FillComboBox(comboBox2, $"SELECT DISTINCT Model FROM DriveChars " +
                $"WHERE Manufacturer = {manufacturer}");
        }

        private void DeleteDriveCharsWindow_Load(object sender, EventArgs e)
        {
            ControlsWorker.FillComboBox(comboBox1, "SELECT DISTINCT Manufacturer " +
                "FROM DriveChars");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string model = $"'{comboBox2.SelectedItem.ToString()}'";
            string manuf = $"'{comboBox1.SelectedItem.ToString()}'";

            ControlsWorker.FillComboBox(comboBox3, $"SELECT DISTINCT [Type] FROM DriveChars " +
                $"WHERE Manufacturer = {manuf} AND Model = {model}");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = $"'{comboBox3.SelectedItem.ToString()}'";
            string model = $"'{comboBox2.SelectedItem.ToString()}'";
            string manuf = $"'{comboBox1.SelectedItem.ToString()}'";

            ControlsWorker.FillComboBox(comboBox4, $"SELECT Capacity FROM DriveChars " +
                $"WHERE Manufacturer = {manuf} AND Model = {model} AND [Type] = {type}");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string manuf = comboBox1.SelectedItem.ToString();
            string model = comboBox2.SelectedItem.ToString();
            string type = comboBox3.SelectedItem.ToString();
            string cap = comboBox4.SelectedItem.ToString();

            MessageBox.Show(DataWorker.Execute($"EXECUTE dbo.DeleteChars '{manuf}', " +
                $"'{model}', '{type}', {cap}"));
        }
    }
}
