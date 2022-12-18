using pProjetSynthèse.Classes;
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

        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            //si le text ne match pas une chaine de caractère il refuse
            if (!Regex.Match(txbNom.Text.Trim(), "[a-zA-Z]{2,254}").Success)
            {
                lblErreurUsager.Text += "\nLe champ nom de l'usager n'est pas comforme";
                lblErreurUsager.ForeColor = Color.Red;
                return;
            }
            //si le text ne match pas une chaine de caractère il refuse
            if (!Regex.Match(txbPrenom.Text.Trim(), "[a-zA-Z]{2,254}").Success)
            {
                lblErreurUsager.Text += "\nLe champ prenom de l'usager n'est pas comforme";
                lblErreurUsager.ForeColor = Color.Red;
                return;
            }
            //si le text ne match pas une chaine de caractère il refuse
            if (!Regex.Match(txbDeptart.Text.Trim(), "[a-zA-Z]{2,254}").Success)
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
                    NumGerant = "G-" + DateTime.Now
                });
            }
            else
            {
                listecEmployer.Add(new cEmployer()
                {
                    Nom = pNom,
                    Prenom = pPrenom,
                    Datecreation = DateTime.Now,
                    NumEmployer = "E-" + DateTime.Now
                });
            }

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
        }
    }
}
