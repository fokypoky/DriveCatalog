using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using DriveCatalog.Data;
using DriveCatalog.AdminWindows;
using DriveCatalog.UserWindows;

namespace DriveCatalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            string connectionString = @"Data Source=DESKTOP-LQJSV1E;Initial Catalog=DriveCatalog;
            User Id="+login+";Password="+password+";";
            DataBase.ConnectionString = connectionString;
            DataBase.Connection = new SqlConnection(connectionString);

            try
            {
                DataBase.Open();
                if(DataWorker.GetValue("SELECT IS_ROLEMEMBER('Admin')") == "1")
                {
                    AdminWindow window = new AdminWindow();
                    window.Show();
                }
                if(DataWorker.GetValue("SELECT IS_ROLEMEMBER('User')") == "1")
                {
                    UserWindow window = new UserWindow();
                    window.Show();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.Close();
        }
    }
}
