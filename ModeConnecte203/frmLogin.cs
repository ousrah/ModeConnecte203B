using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Newtonsoft.Json;


using System.Security.Cryptography;



namespace ModeConnecte203
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


         public string hash(string chaine)
        {
            byte[] textAsByte = Encoding.Default.GetBytes(chaine);

            SHA512 sha512 = SHA512Cng.Create();

            byte[] hash = sha512.ComputeHash(textAsByte);

            return Convert.ToBase64String(hash);

        }


        private void btnConnection_Click(object sender, EventArgs e)
        {


            /*problème injection sql
             * req = "  select * from utilisateur where 
                        login like 'rtyerytzer' 
                        and 
                        password like '0' or '1'='1'     "
             * 
             * */


            //       string cs = ConfigurationManager.ConnectionStrings["LibrairieConnectionString"].ConnectionString;

            StreamReader sr = new StreamReader("config.cfg");
            string c = sr.ReadToEnd();
            config p = Newtonsoft.Json.JsonConvert.DeserializeObject<config>(c);
            sr.Close();


            string cs = "data source=" + p.dataSource + ";initial catalog=" + p.initialCatalog + ";user id =" + p.userId + ";password=" + p.password;

            string newCs = db.decrypterChaineConnection(cs);


            SqlConnection cn = new SqlConnection(newCs);
            
            cn.Open();
            SqlCommand com = new SqlCommand("select * from utilisateur where login like '"+txtLogin.Text+"'", cn);
            SqlDataReader dr = com.ExecuteReader();
            bool passport = false;
            if (dr.Read())
                if (dr["password"].ToString() == hash(txtPwd.Text))
                        passport = true;

            dr.Close();
            dr = null;
            com = null;
            cn.Close();
            cn = null;

            if (passport)
            {
                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("login ou mot de passe incorrect");
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
