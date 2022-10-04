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

namespace DriveCatalog.AdminWindows
{
    public partial class AddDriveCharsWindow : Form
    {
        public AddDriveCharsWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string manufacturer = $"'{textBox1.Text}'";
            string model = $"'{textBox2.Text}'";
            string type = $"'{textBox3.Text}'";
            string capacity = textBox4.Text;

            MessageBox.Show(DataWorker.Execute($"EXECUTE dbo.AddChars {manufacturer}, {model}," +
                $"{type}, {capacity}"));
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
