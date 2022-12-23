using pProjetSynthèse.Classes;
using System;
using System.Collections;
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

namespace pProjetSynthèse.Forms
{
    public partial class Objets : Form
    {
        SqlConnection cnx=new SqlConnection();
        SqlCommand command;
        string Query;
        SqlDataReader resultat;
        int position = -1;
        List<cObjet> ListeObjets = new List<cObjet>();
        public Objets(string datapass)
        {
            InitializeComponent();
            lbldatapassed.Text =  datapass;

        }

        private void Objets_Load(object sender, EventArgs e)
        {
            //Référence laboratoire : Laboratoire_Mode_connecte.docx
            //Configurer la connection avec la base de données
            String connectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;

            //cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            //instancie un objet sqlcommande qui prend en parametre la requete et la connexion SQL
            Query = "SELECT * from objets";
            command = new SqlCommand(Query, cnx);

            //ouvrir la connexion avec la base de données
            cnx.Open();

            resultat = command.ExecuteReader();
            //résultat est une table avec des lignes et des colonnes
            //On va boucler sur cette table
            if (resultat.HasRows) //On vérifie si la table n'est pas vide
            {
                while (resultat.Read()) // Tant qu'il y a des lignes à lire
                {
                    //On ajouter les trois colonnes de la ligne lue
                    datagridObj.Rows.Add(resultat[0], resultat[1], resultat[2], resultat[3], resultat[4]);
                }
                cnx.Close();
                resultat.Close();

            }
            else
                MessageBox.Show("La table objets est vide.");
        }

        private void btnAjouterObj_Click(object sender, EventArgs e)
        {
            //Effeace la liste d'erreur
            lblErreurObj.Text = "Les erreurs :";


            //https://www.c-sharpcorner.com/UploadFile/87b416/validating-user-input-with-regular-expressions/ référence utiliser un Regex pour valider un input
            //si le text ne match pas une chaine de caractère il refuse
            if (!Regex.Match(txbNomItem.Text, "[a-zA-Z]{2,254}").Success)
            {
                lblErreurObj.Text += "\nLe champ Nom de l'item n'est pas comforme";
                lblErreurObj.ForeColor= Color.Red;
                return;
            }
            //si le text ne match pas un entier il est rejeter
            if (!Regex.Match(txbNbParH.Text, "^[1-9][0-9]*").Success)
            {
                lblErreurObj.Text += "\nLe champ Nombre par heure n'est pas conforme!";
                lblErreurObj.ForeColor = Color.Red;
                return;
            }
            //si le text ne match pas un nombre entier ou un nombre avec 2 décimal maxium il est rejeter
            if (!Regex.Match(txbCout.Text, @"(^(\d+)((\.\d{1,2})?))$").Success)
            {
                lblErreurObj.Text += "\nLe champ Cout n'est pas conforme!\n exemple : 10, 10.1, 1, 10,99";
                lblErreurObj.ForeColor = Color.Red;
                return;

            }
            //meme chose que le précédent
            if (!Regex.Match(txbPrix.Text, @"(^(\d+)((\.\d{1,2})?))$").Success)
            {
                lblErreurObj.Text += "\nLe champ Prix n'est pas conforme!\n exemple : 20, 20.1, 2, 21,99";
                lblErreurObj.ForeColor = Color.Red;
                return;
            }

            float tPrix = (float)Convert.ToDecimal(txbPrix.Text.Trim());
            float tCout = (float)Convert.ToDecimal(txbCout.Text.Trim());
            int tHeure = Convert.ToInt32(txbNbParH.Text.Trim());
            string tNomObj = txbNomItem.Text.Trim();
            string IdObj = "I-" + DateTime.Now;

            
            ListeObjets.Add(new cObjet()
            {
                NomObjet = tNomObj,
                NbParHeure = tHeure,
                Cout = tCout,
                Prix = tPrix,
                IdObjet = IdObj
            });


            //Référence Exercie lab mode connecter
            //Préparer la commande INSERT dans la variable Query 
            Query = "INSERT INTO objets (Nom, NbParHeure, cout, prix, code) VALUES ('" + tNomObj + "'," + tHeure + "," + tCout + "," + tPrix + ", '" + IdObj + "');";
            

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
            { MessageBox.Show(ex.Message,"Erreur"); }

            lblErreurObj.ForeColor = Color.Green;
            lblErreurObj.Text = "Réussite ajout voici la liste des obj disponible";
            


        }


        private void btnRaffairchir_Click(object sender, EventArgs e)
        {
            
            // Changer la requête dans l’objet command
            command.CommandText = "SELECT * from objets";
            if (cnx.State == ConnectionState.Closed) //ConnectionState dans System.Data
            {
                cnx.Open();
            }
            resultat = command.ExecuteReader();
            
            //Affichage DataGridView

            if (resultat.HasRows)
            {
                datagridObj.Rows.Clear();
                while (resultat.Read())
                {
                    datagridObj.Rows.Add(resultat[0], resultat[1], resultat[2], resultat[3], resultat[4]); ;
                }
                cnx.Close();

            }
            else
            //Fermeture du DataReader
            resultat.Close();

        }
        private void datagridObj_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Récupérer la position dans le DataGrid
            position = datagridObj.CurrentRow.Index;
            //Récup
            string code = datagridObj.Rows[position].Cells[4].Value.ToString();
            //Récupérer les données dans les textBox à partir du clic sur le DataGridView 
            txbNomItem.Text = datagridObj.Rows[position].Cells[0].Value.ToString();
            txbNbParH.Text = datagridObj.Rows[position].Cells[1].Value.ToString();
            txbCout.Text = datagridObj.Rows[position].Cells[2].Value.ToString();
            txbPrix.Text = datagridObj.Rows[position].Cells[3].Value.ToString();
            txbCode.Text = datagridObj.Rows[position].Cells[4].Value.ToString();
            btnSupp.Enabled = true;
            btnModif.Enabled = true;

        }
        //Référence Laboratoire_Mode_connecte.docx
        private void btnSupp_Click(object sender, EventArgs e)
        {
            SqlCommand commande = new SqlCommand();
            commande.CommandText = "Delete From objets where code='@Code'";
            commande.Parameters.AddWithValue("@Num", Code);
            //Rétablir la connexion avec le serveur si elle est fermée   
            if (cnx.State == ConnectionState.Open) //ConnectionState dans System.Data
                cnx.Close();
            cnx.Open();
            command.ExecuteNonQuery();
            datagridObj.Rows.RemoveAt(position);
            cnx.Close();

            //command = new SqlCommand(Query, cnx);

            //Query = "Delete From objets where code='@Code'";
            //using (SqlCommand command = new SqlCommand(Query, cnx))
            //{
            //    command.Parameters.AddWithValue("@Code", txbCode.Text);

            //    //Rétablir la connexion avec le serveur si elle est fermée   
            //    if (cnx.State == ConnectionState.Open) //ConnectionState dans System.Data
            //        cnx.Close();
            //    cnx.Open();
            //    command.ExecuteNonQuery();
            //    datagridObj.Rows.RemoveAt(position);
            //    cnx.Close();
            //}

            //command.CommandText = Query;

            btnModif.Enabled = false;
            btnSupp.Enabled = false;


        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (!Regex.Match(txbNomItem.Text, "^[a-zA-Z]{2,254}$").Success)
            {
                lblErreurObj.Text += "\nLe champ Nom de l'item n'est pas comforme";
                lblErreurObj.ForeColor = Color.Red;
                return;
            }
            //si le text ne match pas un entier il est rejeter
            if (!Regex.Match(txbNbParH.Text, "^[1-9][0-9]*").Success)
            {
                lblErreurObj.Text += "\nLe champ Nombre par heure n'est pas conforme!";
                lblErreurObj.ForeColor = Color.Red;
                return;
            }
            //si le text ne match pas un nombre entier ou un nombre avec 2 décimal maxium il est rejeter
            if (!Regex.Match(txbCout.Text, @"(^(\d+)((\.\d{1,2})?))$").Success)
            {
                lblErreurObj.Text += "\nLe champ Cout n'est pas conforme!\n exemple : 10, 10.1, 1, 10,99";
                lblErreurObj.ForeColor = Color.Red;
                return;

            }
            //meme chose que le précédent
            if (!Regex.Match(txbPrix.Text, @"(^(\d+)((\.\d{1,2})?))$").Success)
            {
                lblErreurObj.Text += "\nLe champ Prix n'est pas conforme!\n exemple : 20, 20.1, 2, 21,99";
                lblErreurObj.ForeColor = Color.Red;
                return;
            }

            float tPrix = (float)Convert.ToDecimal(txbPrix.Text.Trim());
            float tCout = (float)Convert.ToDecimal(txbCout.Text.Trim());
            int tHeure = Convert.ToInt32(txbNbParH.Text.Trim());
            string tNomObj = txbNomItem.Text.Trim();
            command = new SqlCommand(Query, cnx);
            //Query = "UPDATE objets SET Nom = 'allo' WHERE code='" + txbCode + "';"; //Test , NbParHeure=1,cout=1,prix=1
            Query = "UPDATE objets SET Nom = '" +tNomObj+"',NbParHeure="+ tHeure+",cout="+ tCout+ ",prix "+tPrix+" WHERE code='" + txbCode + "';";
            command.CommandText = Query;
            //Rétablir la connexion avec le serveur si elle est fermée   
            if (cnx.State == ConnectionState.Open) //ConnectionState dans System.Data
                cnx.Close();
            cnx.Open();
            command.ExecuteNonQuery();
            cnx.Close();
            btnRaffairchir_Click(sender, e);
        }

        private void btnCreation_Click(object sender, EventArgs e)
        {
            //Passe les valeur et liste nécessaire vers la page création
            Creations formulaire2 = new Creations(lbldatapassed.Text, ListeObjets);
            formulaire2.Show();
        }
    }
}
