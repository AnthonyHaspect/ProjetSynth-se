using pProjetSynthèse.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace pProjetSynthèse.Forms
{
    public partial class Creations : Form
    {
        //initialisation global pour les commande de sql
        SqlConnection cnx;
        SqlCommand command;
        string Query;
        SqlDataReader resultat;
        int position = -1;
        //
        List<cObjet> listeObjet = new List<cObjet>();
        List<cGerant> listecGerant = new List<cGerant>();
        List<cCreation> listeCreation = new List<cCreation>();
        public Creations(string datapass)//, List<cObjet> liste)
        {
            InitializeComponent();
            //Prend l'usager qui est choisit et le met dans la classe
            txbEmployer.Text = datapass;




        }

        private void afficherListe()
        {
            comboBox1.Items.Clear();
            foreach (cObjet element in listeObjet)
            {
                comboBox1.Items.Add(element.NomObjet);
            }
        }
        private void Creations_Load(object sender, EventArgs e)
        {
            //Instanciation d'un gérant par défault
            listecGerant.Add(new cGerant()
            {
                Nom = "Anthony",
                Prenom = "Haspect",
                Datecreation = DateTime.Now,
                NumGerant = "G-2000-5-5"
            });

            //Instanciation d'un Objet par défault
            listeObjet.Add(new cObjet()
            {
                NomObjet = "Cannette",
                NbParHeure = 1000,
                Cout = 10,
                Prix = 20,
                IdObjet = "I-235867"
            });
            afficherListe();
            //Référence laboratoire : Laboratoire_Mode_connecte.docx
            //Configurer la connection avec la base de données
            String connectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;

            cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            //instancie un objet sqlcommande qui prend en parametre la requete et la connexion SQL
            Query = "SELECT * from Commande";
            command = new SqlCommand(Query, cnx);

            //ouvrir la connexion avec la base de données
            cnx.Open();

            int totalnbItem = 0;
            float totalPrix = 0;
            resultat = command.ExecuteReader();
            //résultat est une table avec des lignes et des colonnes
            //On va boucler sur cette table
            if (resultat.HasRows) //On vérifie si la table n'est pas vide
            {
                while (resultat.Read()) // Tant qu'il y a des lignes à lire
                {
                    //On ajouter les trois colonnes de la ligne lue
                    dgtCreations.Rows.Add(resultat[0], resultat[1], resultat[2], resultat[3], resultat[4], resultat[5]);
                    totalnbItem = totalnbItem + Convert.ToInt32(resultat[1]);
                    totalPrix = totalPrix + Convert.ToSingle(resultat[3]);
                    txbItemTotal.Text = totalnbItem.ToString();
                    txbArgentTot.Text = totalPrix.ToString();
                }
                cnx.Close();
                resultat.Close();

            }
            else
                MessageBox.Show("La table objets est vide.");
            comboBox1.Items.Clear();

            //Devrai prendre tout les objet de la classe objet et les ajouter ici

            //foreach(cObjet element in listeObjets)
            //{
            //    comboBox1.Items.Add(element.NomObjet);
            //}
            
        }
        
        private void btnModif_Click(object sender, EventArgs e)
        {

        }


        private void btnRaffairchirs_Click(object sender, EventArgs e)
        {
            int totalnbItem = 0;
            float totalPrix = 0;
            afficherListe();

            //Référence laboratoire : Laboratoire_Mode_connecte.docx
            // Changer la requête dans l’objet command
            Query = "SELECT * from Commande";
            command = new SqlCommand(Query, cnx);
            if (cnx.State == ConnectionState.Closed) //ConnectionState dans System.Data
            {
                cnx.Open();
            }
            resultat = command.ExecuteReader();

            //Affichage DataGridView

            if (resultat.HasRows)
            {
                dgtCreations.Rows.Clear();
                while (resultat.Read())
                {
                    dgtCreations.Rows.Add(resultat[0], resultat[1], resultat[2], resultat[3], resultat[4], resultat[5]);
                    totalnbItem = totalnbItem + Convert.ToInt32(resultat[1]);
                    totalPrix = totalPrix + Convert.ToSingle(resultat[3]);
                    txbItemTotal.Text = totalnbItem.ToString();
                    txbArgentTot.Text = totalPrix.ToString();
                }
            
                cnx.Close();

            }
            else
                //Fermeture du DataReader
                resultat.Close();
            lblErreurObj.Text = "Les Creation";
            foreach (cCreation creation in listeCreation)
            {
                lblErreurObj.Text +=  creation.ToString();

            }


        }
        //bouton qui permet d'ajouter une création
        private void btnCommande_Click(object sender, EventArgs e)
        {
            //déclaration des valeurs
            int ValNbItem = 0;
            float ValPrix = 0;
            string ValNumCmd = "C-" + DateTime.Now;
            cGerant ValGerant = null;
            lblErreurObj.Text = "Les Erreurs:";

            //si le text ne match pas une chaine de caractère il refuse
            if (!Regex.Match(comboBox1.Text, "[a-zA-Z]{2,254}").Success)
            {
                lblErreurObj.Text += "\nLe champ Nom de l'item n'est pas comforme";
                lblErreurObj.ForeColor = Color.Red;
                return;
            }

            if (!Regex.Match(txbNbHeure.Text, "^[1-9][0-9]*").Success)
            {
                lblErreurObj.Text += "\nLe champ Nombre d'heure n'est pas conforme!";
                lblErreurObj.ForeColor = Color.Red;
                return;
            }

            foreach(cObjet element in listeObjet)
            {
                if (element.NomObjet == comboBox1.SelectedItem.ToString())
                {
                    ValNbItem = element.NbParHeure * Convert.ToInt32(txbNbHeure.Text.Trim());
                    ValPrix = element.Prix;
                }
            }


            //Chere pour un match de gérant pour dans le futur l'instancier dans la classe cCreation
            foreach(cGerant gerant in listecGerant)
            {
                if (gerant.NumGerant == txbEmployer.Text)
                {
                    ValGerant = gerant;
                }
                else
                    return;
            }

            //Référence Exercie lab mode connecter
            //Préparer la commande INSERT dans la variable Query 
            Query = "INSERT INTO Commande(Item, NbItem, Heures, Prix, Usager, NumeroCmd) VALUES('"+comboBox1.SelectedItem.ToString()+"', "+ ValNbItem +", "+ txbNbHeure.Text +", "+ValPrix+", '"+txbEmployer.Text+"', '"+ ValNumCmd +"');";


            //Mettre La requête dans la propriété CommanText de l’objet command
            command.CommandText = Query;

            //Rétablir la connexion avec le serveur si elle a été fermée
            if (cnx.State == ConnectionState.Open) //ConnectionState dans System.Data
                cnx.Close();
            cnx.Open();
            //Executer la commande INSERT
            int nombreLignes = command.ExecuteNonQuery();
            MessageBox.Show(nombreLignes + "ligne(s) affectée(s)");
            cnx.Close();


            try
            {

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Erreur"); }
            comboBox1.SelectedItem.ToString();

            //Instanciation de la classe commande
            
            listeCreation.Add(new cCreation()
            {
                nbHeure = Convert.ToInt32(txbNbHeure.Text.Trim()),
                Objet = comboBox1.SelectedItem.ToString(),
                ItemTotal = ValNbItem,
                CUsager = ValGerant,
                NumCommandeId = ValNumCmd
            });

        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            Query = "Delete From objets where NumeroCmd='@Code'";
            using (SqlCommand command = new SqlCommand(Query, cnx))
            {
                command.Parameters.AddWithValue("@Code", txbCodeCmd.Text);

                //Rétablir la connexion avec le serveur si elle est fermée   
                if (cnx.State == ConnectionState.Open) //ConnectionState dans System.Data
                    cnx.Close();
                cnx.Open();
                command.ExecuteNonQuery();
                dgtCreations.Rows.RemoveAt(position);
                cnx.Close();
            }

            command.CommandText = Query;
        }

        private void dgtCreations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Récupérer la position dans le DataGrid
            position = dgtCreations.CurrentRow.Index;
            //Récupérer les données dans les textBox à partir du clic sur le DataGridView
            txbCodeCmd.Text = dgtCreations.Rows[position].Cells[5].Value.ToString();
            btnSupp.Enabled = true;


        }
    }
}
