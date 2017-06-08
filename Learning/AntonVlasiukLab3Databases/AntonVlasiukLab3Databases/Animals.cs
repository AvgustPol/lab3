using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntonVlasiukLab3Databases
{
    class Animals
    {
        public static void ShowAnimals(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Animals", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Species AS Gatunek , Amount AS Ilosc FROM Animals", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }

        public static void AddAnimal(SqlConnection sqlConnection, DataGridView dataGridView, string species, string amount)
        {
            sqlConnection.Open();
            string command = $"INSERT INTO Animals (Species, Amount) values ('{species}', '{amount}')";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("We did it!!!");
            ShowAnimals(sqlConnection, dataGridView);
            sqlConnection.Close();
        }
    }
}
