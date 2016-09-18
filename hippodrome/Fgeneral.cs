using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace hippodrome
{
    public partial class Fgeneral : Form
    {
        public Fgeneral()
        {
            InitializeComponent();
        }
        // on déclare un objet de la classe LienBdd
        internal LienBdd uneCn;
        private DataTable dt= new DataTable();
        private int i=0;
        private int noLigne;
        private void Fgeneral_Load(object sender, EventArgs e)
        {
            // connection à la bdd hippo sous sqlserver
            uneCn = new LienBdd();
        }
        // ***************************** onglet Cheval **************************************

             
     }       
    }

