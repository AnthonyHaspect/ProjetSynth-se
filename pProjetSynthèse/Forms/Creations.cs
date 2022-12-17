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

namespace pProjetSynthèse.Forms
{
    public partial class Creations : Form
    {
        SqlConnection cnx;
        SqlCommand command;
        public Creations()
        {
            InitializeComponent();
        }

        private void Creations_Load(object sender, EventArgs e)
        {
            //Référence laboratoire : Laboratoire_Mode_connecte.docx
            //Configurer la connection avec la base de données
            String connectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;

            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            //instancie un objet sqlcommande qui prend en parametre la requete et la connexion SQL
            string Query = "SELECT * from Commande";
            SqlCommand command = new SqlCommand(Query, cnx);

            //ouvrir la connexion avec la base de données
            cnx.Open();

            SqlDataReader resultat = command.ExecuteReader();
            //résultat est une table avec des lignes et des colonnes
            //On va boucler sur cette table
            if (resultat.HasRows) //On vérifie si la table n'est pas vide
            {
                while (resultat.Read()) // Tant qu'il y a des lignes à lire
                {
                    //On ajouter les trois colonnes de la ligne lue
                    dataGridView1.Rows.Add(resultat[0], resultat[1], resultat[2], resultat[3], resultat[4], resultat[5]);
                }


            }
            else
                MessageBox.Show("La table objets est vide.");
        }

        private void btnModif_Click(object sender, EventArgs e)
        {

        }
    }
}
