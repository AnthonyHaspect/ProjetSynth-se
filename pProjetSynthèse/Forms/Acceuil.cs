using pProjetSynthèse.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Anthony Haspect 2027425

namespace pProjetSynthèse
{
    public partial class Acceuil : Form
    {
            
        public Acceuil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Pour la connection a l'école
            //"Data Source=localhost;Initial Catalog=AnthonyHaspect;User ID=sa;Password=sql"


        }


        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //référence  note de cours MenuStrip_FormulaireMDI.docx

            Connection formulaire = new Connection(); // Création d'une instance 
            formulaire.MdiParent = this; // définir le formulaire parent
            formulaire.Show(); // affichage du formulaire enfant
            //Afficher le formulaire des création
            Creations formulaire2= new Creations();
            formulaire2.MdiParent = this;
            formulaire2.Show();
            //Affiche le formulaire des objets
            Objets formulaire3= new Objets();
            formulaire3.MdiParent = this;
            formulaire3.Show();
        }
    }
}
