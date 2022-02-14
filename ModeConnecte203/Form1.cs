using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ModeConnecte203
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"data source=.\sqlserver2017;initial catalog=librairie;user id=sa;Password=P@ssw0rd");
            cn.Open();
            SqlCommand com = new SqlCommand("select * from ouvrage",cn);
            SqlDataReader dr = com.ExecuteReader();
            listBox1.Items.Clear();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["nomouvr"]);
                listBox3.Items.Add(dr["numouvr"]);
            }
             dr.Close();
            com.CommandText = "select * from editeur";

            dr = com.ExecuteReader();
            listBox2.Items.Clear();
            while (dr.Read())
            {
                listBox2.Items.Add(dr["nomed"]);
            }


       
            dr = null;
            com = null;
            cn.Close();
            cn = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"data source=.\sqlserver2017;initial catalog=librairie;user id=sa;Password=P@ssw0rd");
            cn.Open();
            SqlCommand com = new SqlCommand("select count(*) from ouvrage", cn);
            int nb = Convert.ToInt32(com.ExecuteScalar());
            textBox1.Text = nb.ToString() ;
            com = null;
            cn.Close();
            cn = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"data source=.\sqlserver2017;initial catalog=librairie;user id=sa;Password=P@ssw0rd");
            cn.Open();
            SqlCommand com = new SqlCommand("insert into ouvrage (numouvr,nomed, nomouvr,numrub, anneeparu) values (54216521,'CLET','test mode connecte',1,2022)", cn);
            com.ExecuteNonQuery();
            MessageBox.Show("ouvrage ajouté avec success");
            cn.Close();
            cn = null;

        }
    }
}
