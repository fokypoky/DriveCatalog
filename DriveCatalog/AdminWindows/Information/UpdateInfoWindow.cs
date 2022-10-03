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

namespace DriveCatalog.AdminWindows.Information
{
    public partial class UpdateInfoWindow : Form
    {
        public UpdateInfoWindow()
        {
            InitializeComponent();
        }

        private void UpdateInfoWindow_Load(object sender, EventArgs e)
        {
            ControlsWorker.FillDataGrid(dataGridView1, "SELECT * FROM InfoVIEW");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ControlsWorker.FillDataGrid(dataGridView1, "SELECT * FROM InfoVIEW WHERE [Drive Serial] " +
                $"LIKE '%{textBox1.Text}%'");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ControlsWorker.FillDataGrid(dataGridView1, $"SELECT * FROM InfoVIEW " +
                $"WHERE [Drive Serial] LIKE '%{textBox1.Text}%' AND [Info path] LIKE '%{textBox2.Text}%'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serial = textBox1.Text;
            string path = textBox2.Text;
            string volume = textBox3.Text;

            MessageBox.Show(DataWorker.Execute($"EXECUTE dbo.UpdateInformation '{serial}', " +
                $"'{path}', {volume}"));

        }
    }
}
