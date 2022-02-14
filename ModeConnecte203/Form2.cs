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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"data source=.\sqlserver2017;initial catalog=librairie;user id=sa;Password=P@ssw0rd");
            cn.Open();
            SqlCommand com = new SqlCommand("select * from ouvrage", cn);
            SqlDataReader dr = com.ExecuteReader();

            DataTable tbl = new DataTable();
            /*          DataColumn numouvr = new DataColumn("numouvr",typeof(int));
                        DataColumn nomouvr = new DataColumn("nomouvr", typeof(string));
                        tbl.Columns.Add(numouvr);
                        tbl.Columns.Add(nomouvr);


                        while (dr.Read())
                        {
                            DataRow r = tbl.NewRow();
                            r[0] = dr["numouvr"];
                            r[1] = dr["nomouvr"];
                            tbl.Rows.Add(r);
                       }
            */
            tbl.Load(dr);
  
            listBox1.DisplayMember = "nomouvr";
            listBox1.ValueMember = "numouvr";
            listBox1.DataSource = tbl;

            dr.Close();

            dr = null;
            com = null;
            cn.Close();
            cn = null;
        }
    }
}
