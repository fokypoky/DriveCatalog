using DriveCatalog.Data;
using System;
using System.Windows.Forms;

namespace DriveCatalog.AdminWindows.Drive
{
    public partial class DeleteDriveWindow : Form
    {
        public DeleteDriveWindow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string serial = textBox1.Text;
            ControlsWorker.FillDataGrid(dataGridView1, $"SELECT * FROM DriveVIEW WHERE Serial LIKE '%{serial}%'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serial = textBox1.Text;
            MessageBox.Show(DataWorker.Execute($"EXECUTE dbo.DeleteDevice '{serial}'"));
        }

        private void DeleteDriveWindow_Load(object sender, EventArgs e)
        {
            ControlsWorker.FillDataGrid(dataGridView1, "SELECT * FROM DriveVIEW");
        }
    }
}
