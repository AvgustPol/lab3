using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    class Zookeepers
    {

        static SqlCommand sqlCommand;

        /// <summary>
        /// Wyswietlanie wszystkich opiekunow
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowAllZookeepers(SqlConnection sqlConnection, DataGridView dataGridView)
        {
           SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(
                @"SELECT Name AS 'Imię', Surname AS 'Nazwisko' FROM Zookeeper",
                sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }
        /// <summary>
        /// Dodawanie nowego opienkuna
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        public static void AddZookeeper(SqlConnection sqlConnection, DataGridView dataGridView, string name, string surname)
        {
            try
            {
                sqlConnection.Open();
                string command = $"INSERT INTO Zookeeper (Name,Surname) values ('{name}','{surname}')";
                sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Dodano");
                ShowAllZookeepers(sqlConnection, dataGridView);
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Błąd");
            }
        }

        public static void DeleteZookeeper(SqlConnection sqlConnection, DataGridView dataGridView, string name, string surname)
        {
            try
            {
                sqlConnection.Open();
                string command = $"DELETE FROM Zookeeper WHERE Name = '{name}' AND Surname = '{surname}'";
                sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                ShowAllZookeepers(sqlConnection, dataGridView);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

    }
}
