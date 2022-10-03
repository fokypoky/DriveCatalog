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

namespace DriveCatalog.AdminWindows.Drive
{
    public partial class UpdateDriveWindow : Form
    {
        public UpdateDriveWindow()
        {
            InitializeComponent();
        }

        private void UpdateDriveWindow_Load(object sender, EventArgs e)
        {
            ControlsWorker.FillDataGrid(dataGridView1, $"SELECT * FROM DriveVIEW");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string serial = textBox1.Text;
            ControlsWorker.FillDataGrid(dataGridView1, $"SELECT * FROM DriveVIEW " +
                $"WHERE Serial LIKE '%{serial}%'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serial = textBox1.Text;
            string fsys = textBox2.Text;

            if(!String.IsNullOrEmpty(serial) && !String.IsNullOrEmpty(fsys))
                MessageBox.Show(DataWorker.Execute($"EXECUTE dbo.UpdateDriveFileSystem '{serial}', '{fsys}'"));

        }
    }
}
