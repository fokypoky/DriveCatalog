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
    public partial class DeleteDeviceWindow : Form
    {
        public DeleteDeviceWindow()
        {
            InitializeComponent();
        }

        private void DeleteDeviceWindow_Load(object sender, EventArgs e)
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
            if (!String.IsNullOrEmpty(serial))
            {
                string querry = $"EXECUTE dbo.DeleteDevice '{serial}'";
                MessageBox.Show(DataWorker.Execute(querry));
            }
            else
            {
                MessageBox.Show("Serial is empty");
            }
        }
    }
}
