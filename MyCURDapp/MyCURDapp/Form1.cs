using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyCURDapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=TALHA;Initial Catalog=MyCURD;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string FirstName = tbFirstName.Text;
            string LasttName = tbLastName.Text;
            string Phone = tbphone.Text;
            string Age = tbAge.Text;
            string Query = "INSERT INTO MyCURD (FirstName, LasttName, Phone,Age) VALUES ('"+ FirstName + "','"+ LasttName + "', '"+Phone+"', '"+Age+"')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been saved");


        }
    }
}
