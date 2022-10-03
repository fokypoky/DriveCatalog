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
    public partial class DeleteInfoWindow : Form
    {
        public DeleteInfoWindow()
        {
            InitializeComponent();
        }

        private void DeleteInfoWindow_Load(object sender, EventArgs e)
        {
            ControlsWorker.FillDataGrid(dataGridView1, "SELECT * FROM InfoVIEW");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serial = textBox1.Text;
            string path = textBox2.Text;

            string querry = $"EXECUTE dbo.DeleteInformation '{serial}', '{path}'";

            MessageBox.Show(DataWorker.Execute(querry));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string serial = textBox1.Text;
            ControlsWorker.FillDataGrid(dataGridView1, $"SELECT * FROM InfoVIEW " +
                $"WHERE [Drive Serial] LIKE '%{serial}%'");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string path = textBox2.Text;
            string serial = textBox1.Text;
            ControlsWorker.FillDataGrid(dataGridView1, $"SELECT * FROM InfoVIEW " +
                $"WHERE [Drive Serial] LIKE '%{serial}%' AND [Info path] LIKE '%{path}%'");
        }
    }
}
