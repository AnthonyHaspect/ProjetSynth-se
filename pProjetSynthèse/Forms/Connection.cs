using pProjetSynthèse.Classes;
using pProjetSynthèse.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pProjetSynthèse
{
    public partial class Connection : Form
    {
        
        List<cGerant> listecGerant = new List<cGerant>();
        List<cEmployer> listecEmployer = new List<cEmployer>();
        public Connection()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //si le text ne match pas une chaine de caractère il refuse
            lblErreurUsager.Text = "les Erreur:";
            if (!Regex.Match(cmbListeUsager.Text.Trim(), ".{2,254}").Success)
            {
                lblErreurUsager.Text += "\nLe champ Connection n'est pas comforme\nChoissisez un utilisateur!";
                lblErreurUsager.ForeColor = Color.Red;
                return;
            }

            Objets formulaire2 = new Objets(cmbListeUsager.SelectedItem.ToString());
            formulaire2.Show();

        }
        /// <summary>
        /// Ajout la liste de gérant et de employer a la combo box 
        /// </summary>
        private void cmbAff()
        {
            cmbListeUsager.Items.Clear();
            foreach (cGerant element in listecGerant)
            {
                cmbListeUsager.Items.Add(element.NumGerant);
            }

            foreach (cEmployer element in listecEmployer)
            {
                cmbListeUsager.Items.Add(element.NumEmployer);
            }

        }
        //Expression Lambdas
        Func<string, string> StringId = x => x +DateTime.Now.ToString();

        private void btnCreer_Click(object sender, EventArgs e)
        {
            lblErreurUsager.Text = "Les erreurs: ";
            //si le text ne match pas une chaine de caractère il refuse
            if (!Regex.Match(txbNom.Text.Trim(), "^[a-zA-Z]{2,254}$").Success)
            {
                lblErreurUsager.Text += "\nLe champ nom de l'usager n'est pas comforme";
                lblErreurUsager.ForeColor = Color.Red;
                return;
            }
            //si le text ne match pas une chaine de caractère il refuse
            if (!Regex.Match(txbPrenom.Text.Trim(), "^[a-zA-Z]{2,254}$").Success)
            {
                lblErreurUsager.Text += "\nLe champ prenom de l'usager n'est pas comforme";
                lblErreurUsager.ForeColor = Color.Red;
                return;
            }
            //si le text ne match pas une chaine de caractère il refuse
            if (!Regex.Match(txbDeptart.Text.Trim(), "^[a-zA-Z]{2,254}$").Success)
            {
                lblErreurUsager.Text += "\nLe champ departement de l'usager n'est pas comforme";
                lblErreurUsager.ForeColor = Color.Red;
                return;
            }

            string pNom = txbNom.Text.Trim();
            string pPrenom = txbPrenom.Text.Trim();
            string pDepartement = txbDeptart.Text.Trim();




            if (chkbGreant.Checked == true)
            {
                listecGerant.Add(new cGerant()
                {
                    Nom = pNom,
                    Prenom = pPrenom,
                    Datecreation = DateTime.Now,
                    NumGerant = StringId("E-")
                });
                lblErreurUsager.ForeColor = Color.Green;
                lblErreurUsager.Text = StringId("G-");
            }
            else
            {
                listecEmployer.Add(new cEmployer()
                {
                    Nom = pNom,
                    Prenom = pPrenom,
                    Datecreation = DateTime.Now,
                    NumEmployer = StringId("E-")
                });
                lblErreurUsager.ForeColor = Color.Green;
                lblErreurUsager.Text = StringId("E-");
            }

            cmbAff();

        }

        private void Connection_Load(object sender, EventArgs e)
        {
            listecEmployer.Add(new cEmployer()
            {
                Nom = "Anthony",
                Prenom = "Haspect",
                Datecreation = DateTime.Now,
                NumEmployer = "E-2000-5-5"

            });

            listecGerant.Add(new cGerant()
            {
                Nom = "Anthony",
                Prenom = "Haspect",
                Datecreation = DateTime.Now,
                NumGerant = "G-2000-5-5"
            });

            cmbAff();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            lblErreurUsager.Text = "";
            lblErreurUsager.ForeColor = Color.Blue;
            lblErreurUsager.Text = "Les gérants: ";
            foreach (cGerant objUsager in listecGerant)
            {

                lblErreurUsager.Text += objUsager.ToString();
            }
            lblErreurUsager.Text += "\nLes employers: ";
            foreach (cEmployer objUsager in listecEmployer)
            {

                lblErreurUsager.Text += objUsager.ToString();
            }

            lblErreurUsager.Text += "\nNombre d'usager créer: "+ cUsager.nb_usager;

        }
    }
}
