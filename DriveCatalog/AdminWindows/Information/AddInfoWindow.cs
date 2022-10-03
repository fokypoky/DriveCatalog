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
    public partial class AddInfoWindow : Form
    {
        public AddInfoWindow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ControlsWorker.FillDataGrid(dataGridView1, "SELECT * FROM InfoVIEW WHERE [Drive Serial] " +
                $"LIKE '%{textBox1.Text}%'");
        }

        private void AddInfoWindow_Load(object sender, EventArgs e)
        {
            ControlsWorker.FillDataGrid(dataGridView1, "SELECT * FROM InfoVIEW");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serial = textBox1.Text;
            string path = textBox2.Text;
            string volume = textBox3.Text;

            MessageBox.Show(DataWorker.Execute($"EXECUTE dbo.AddInfo '{path}', '{serial}', " +
                $"{volume}"));

        }
    }
}
