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
        public Creations(string datapass)//, List<cObjet> liste)
        {
            InitializeComponent();
            //Prend l'usager qui est choisit et le met dans la classe
            txbEmployer.Text = datapass;




        }

        private void Creations_Load(object sender, EventArgs e)
        {
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

            resultat = command.ExecuteReader();
            //résultat est une table avec des lignes et des colonnes
            //On va boucler sur cette table
            if (resultat.HasRows) //On vérifie si la table n'est pas vide
            {
                while (resultat.Read()) // Tant qu'il y a des lignes à lire
                {
                    //On ajouter les trois colonnes de la ligne lue
                    dgtCreations.Rows.Add(resultat[0], resultat[1], resultat[2], resultat[3], resultat[4], resultat[5]);
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
                }
            
                cnx.Close();

            }
            else
                //Fermeture du DataReader
                resultat.Close();


        }
        //bouton qui permet d'ajouter une création
        private void btnCommande_Click(object sender, EventArgs e)
        {




            int ValNbItem = 0;
            int ValNbHeure = 0;
            float ValPrix = 0;
            string ValNumCmd = "C-" + DateTime.Now;
            //Référence Exercie lab mode connecter
            //Préparer la commande INSERT dans la variable Query 
            Query = "INSERT INTO Commande(Item, NbItem, Heures, Prix, Usager, NumeroCmd) VALUES('"+comboBox1.SelectedItem.ToString()+"', "+ ValNbItem +", "+ ValNbHeure +", "+ValPrix+", '"+txbEmployer+"', '"+ ValNumCmd +"');";


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
