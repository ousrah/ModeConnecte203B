using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace ModeConnecte203
{
    public partial class LireJson : Form
    {
        public LireJson()
        {
            InitializeComponent();
        }

        private void LireJson_Load(object sender, EventArgs e)
        {
            //StreamWriter sw = new StreamWriter((@Project.path + @"\" + Project.name + @"\" + Project.name + @".sb"));
            //sw.Write(Newtonsoft.Json.JsonConvert.SerializeObject(p));
            //sw.Close();

            //StreamReader sr = new StreamReader(fileName);
            //string project = sr.ReadToEnd();
            //ProjectSer p = Newtonsoft.Json.JsonConvert.DeserializeObject<ProjectSer>(project);
            //sr.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            config c = new config();


            c.dataSource = @".\sqlexpress2008";
            c.initialCatalog = "librairie";
            c.userId = "sa";
            c.password = "6nd1H3mfmG6u/2JjCw+IOQ==";




            StreamWriter sw = new StreamWriter("config.cfg");
            sw.Write(Newtonsoft.Json.JsonConvert.SerializeObject(c));
            sw.Close();


        }
    }
}
