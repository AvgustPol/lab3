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
    class Sloths
    {

        public static void ShowAnimals(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            
                                                             //@ - позволяет писать с пробелами код
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT Sloths.Name, Sloths.Age ,
                                            Zookeeper.Name, Zookeeper.Surname, Animals.Species FROM Sloths JOIN Animals ON 
                                            Animals.ID=Sloths.AnimalID JOIN Zookeeper ON Zookeeper.ID=Sloths.ZookeeperID", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }

    }
}
