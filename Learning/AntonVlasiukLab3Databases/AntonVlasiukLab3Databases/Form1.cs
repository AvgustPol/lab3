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

namespace AntonVlasiukLab3Databases
{
    public partial class Form1 : Form
    {

        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;

        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=MSI; database=ZOO; Trusted_Connection=yes");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animals.ShowAnimals(sqlConnection, dataGridViewZoo);
            //dataGridViewZoo.Columns[0].Visible = false;
        }

        private void ShowAllSloths_Click(object sender, EventArgs e)
        {
            Sloths.ShowAnimals(sqlConnection, dataGridViewZoo);
        }

        private void buttonAddAnimal_Click(object sender, EventArgs e)
        {
            Animals.AddAnimal(sqlConnection, dataGridViewZoo, textBoxName.Text, textBoxAmount.Text);
        }

    }
}
