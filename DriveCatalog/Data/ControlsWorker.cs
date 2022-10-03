using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DriveCatalog.Data
{
    public static class ControlsWorker
    {
        public static void FillDataGrid(DataGridView grid, string querry)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(querry, DataBase.Connection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i = 0; i < table.Columns.Count; i++)
            {
                string header = table.Columns[i].ColumnName;
                grid.Columns.Add(header, header);
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                List<string> values = new List<string>();

                for (int j = 0; j < table.Columns.Count; j++)
                {
                    values.Add(table.Rows[i][j].ToString());
                }
                grid.Rows.Add(values.ToArray());
            }
        }
        public static void FillComboBox(ComboBox comboBox, string querry)
        {
            comboBox.Items.Clear();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(querry, DataBase.Connection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                comboBox.Items.Add(table.Rows[i][0].ToString());
            }

        }
    }
}
