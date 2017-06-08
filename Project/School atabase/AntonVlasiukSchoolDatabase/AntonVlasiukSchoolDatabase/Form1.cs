using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntonVlasiukSchoolDatabase
{
    public partial class FormMain : Form
    {
        private static int numberOfTable;
        SqlConnection sqlConnection;

        public FormMain()
        {
            numberOfTable = 1;
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=MSI; database=School; Trusted_Connection=yes");
        }

        /// <summary>
        /// button dla wyswietlania kolejnej tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNextTable_Click(object sender, EventArgs e)
        {
            ShowNextTable();
        }

        /// <summary>
        /// wyswietlanie kolejnej tabeli
        /// </summary>
        private void ShowNextTable()
        {
            switch (numberOfTable)
            {
                case 1: 
                    ShowClassTable(sqlConnection, dataGridViewTables, "SELECT * FROM Classes");
                    break; 
                case 2:
                    ShowClassTable(sqlConnection, dataGridViewTables, "SELECT * FROM Marks");
                    break;
                case 3:
                    ShowClassTable(sqlConnection, dataGridViewTables, "SELECT * FROM Students");
                    break;
                case 4:
                    ShowClassTable(sqlConnection, dataGridViewTables, "SELECT * FROM Subjects");
                    break;
                case 5:
                    ShowClassTable(sqlConnection, dataGridViewTables, "SELECT * FROM Teachers");
                    break;
                case 6:
                    ShowClassTable(sqlConnection, dataGridViewTables, "SELECT * FROM Teaches");
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// funkcja dla wyswietlania tabeli z BD o podanym QUERY
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="query"></param>
        public static void ShowClassTable(SqlConnection sqlConnection, DataGridView dataGridView, string query)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;

            numberOfTable++;
            if (numberOfTable == 7)
                numberOfTable = 1;
        }

        /// <summary>
        /// button dla dodania przedmiota
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Sybjects.AddSybjects(sqlConnection , dataGridViewTables, textBoxAdd.Text);
        }

        /// <summary>
        /// button dla usuwania przedmiota
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Sybjects.DeleteSybjects(sqlConnection, dataGridViewTables, textBoxDelete.Text);
        }

        /// <summary>
        /// button dla zmiany imienu przedmiota
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModify_Click(object sender, EventArgs e)
        {
            Sybjects.UpdateSybjects(sqlConnection, dataGridViewTables, textBoxOldName.Text , textBoxNewName.Text);
        }

        /// <summary>
        /// wyszukiwanie i wyswietlanie przedmiotu o podaneh nazwie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFindByName_TextChanged_1(object sender, EventArgs e)
        {
            Sybjects.FindByName(sqlConnection, dataGridViewTables, textBoxFindByName.Text);
        }

        /// <summary>
        /// button dla demonstracji wykonanego wymagania dla tabel z relacja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowStudents_Click(object sender, EventArgs e)
        {
            //ta metoda demonstruje wymaganie "Należy wykorzystać zapytanie JOIN...ON w przypadku tabel posiadających relacje! + wyświetlać polskie nazwy kolumn"
            ShowClassTable(sqlConnection, dataGridViewTables, "SELECT Students.IdStudent AS 'ID' , Students.Name AS 'Imie' , Students.Surname AS 'Nazwisko', Classes.Symbol AS 'Klasa' FROM Students INNER JOIN Classes ON Students.Class=Classes.Symbol");
        }

        /// <summary>
        /// button dla wyswietlania wszystkich przedmiotow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowAllSubjects_Click(object sender, EventArgs e)
        {
            ShowClassTable(sqlConnection, dataGridViewTables, "SELECT * FROM Subjects");
        }
    }
}
