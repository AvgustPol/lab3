using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntonVlasiukSchoolDatabase
{
    class Sybjects
    {
        static SqlCommand sqlCommand;

        /// <summary>
        /// Dodawanie przedmionu
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="name"></param>
        public static void AddSybjects(SqlConnection sqlConnection, DataGridView dataGridView, string name)
        {
            try
            {
                sqlConnection.Open();
                string command = $"INSERT INTO Subjects (SubjectName) values ('{name}')";
                sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added");
                FormMain.ShowClassTable(sqlConnection, dataGridView, "SELECT * FROM Subjects");
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Error 404 (or not 404) :/ ");
            }
        }

        /// <summary>
        /// usuwanie przedmiotu o danej nazwie 
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="name"></param>
        public static void DeleteSybjects(SqlConnection sqlConnection, DataGridView dataGridView, string name)
        {
            try
            {
                sqlConnection.Open();
                string command = $"DELETE FROM Subjects WHERE SubjectName = '{name}' ";
                sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted");
                FormMain.ShowClassTable(sqlConnection, dataGridView, "SELECT * FROM Subjects");
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Error 404 (or not 404) :/ ");
            }
        }

        /// <summary>
        /// edycja imieniu przedmiotu
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="oldName"></param>
        /// <param name="newName"></param>
        public static void UpdateSybjects(SqlConnection sqlConnection, DataGridView dataGridView, string oldName, string newName)
        {
            try
            {
                sqlConnection.Open();
                string command = $"UPDATE Subjects SET SubjectName = '{newName}' WHERE SubjectName = '{ oldName }'";
                sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted");
                FormMain.ShowClassTable(sqlConnection, dataGridView, "SELECT * FROM Subjects");
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Error 404 (or not 404) :/ ");
            }
        }

        /// <summary>
        /// Wyszukiwanie przedmiota o podanej nazwie
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="name"></param>
        public static void FindByName(SqlConnection sqlConnection, DataGridView dataGridView, string name)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM Subjects WHERE SubjectName LIKE '%{name}%'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }

    }
}
