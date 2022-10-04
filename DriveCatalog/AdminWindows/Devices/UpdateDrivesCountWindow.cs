using DriveCatalog.Data;
using System;
using System.Windows.Forms;

namespace DriveCatalog.AdminWindows.Devices
{
    public partial class UpdateDrivesCountWindow : Form
    {
        public UpdateDrivesCountWindow()
        {
            InitializeComponent();
        }

        private void UpdateDrivesCountWindow_Load(object sender, EventArgs e)
        {
            ControlsWorker.FillDataGrid(dataGridView1, "SELECT * FROM DeviceVIEW");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string serial = textBox1.Text;
            ControlsWorker.FillDataGrid(dataGridView1, $"SELECT * FROM DeviceVIEW " +
                $"WHERE [Device Serial] LIKE '%{serial}%'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serial = textBox1.Text;
            string count = numericUpDown1.Value.ToString();
            if (!String.IsNullOrEmpty(serial) && !String.IsNullOrEmpty(count))
            {
                string querry = $"EXECUTE dbo.UpdateDevice '{serial}', {count}";
                MessageBox.Show(DataWorker.Execute(querry));
            }
        }
    }
}
