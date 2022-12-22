using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    // Permet l'utilisation des classes SqlConnection, SqlCommand et SqlAdapter
using System.Data;              // Permet l'utilisation des classes DataSet et DataTable

namespace synthese.Class
{
    public static class Client
    {
        //Champs privés
        // la liste des usagers dont la clé est leur numéro d'identification.
        private static Dictionary<int, Client> listClients;
        private static SqlConnection connection;
        private static SqlCommand command;
        private static SqlDataReader reader;
        private static SqlDataAdapter adapter;
        private static string connectionString;
        private static DataTable dtProjetSynthese;
        private static DataSet dsClients;

        //Déclaration des propriétés
        public static Dictionary<string, Client> ListClients
        {
            get { return listClients; }
            set { listClients = value; }
        }
        public static SqlConnection Connection { get => connection; set => connection = value; }
        public static SqlCommand Command { get => command; set => command = value; }
        public static SqlDataReader Reader { get => reader; set => reader = value; }
        public static SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public static string ConnectionString { get => connectionString; }     // Pas de set afin de bloquer la possibilité de la modifier
        public static DataTable DtEtudiants { get => dtProjetSynthese; set => dtProjetSynthese = value; }
        public static DataSet DsClients { get => dsClients; set => dsClients = value; }

        //Constructeur par défaut
        static Client()
        {
            // Integrated Security = True;
            connectionString = "Data Source=1105R1PC1;Initial Catalog=ProjetSynthese;User ID=sa";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            adapter = new SqlDataAdapter();
            dsClients = new DataSet();
            dtProjetSynthese = new DataTable();
        }

        //Méthode
        /// <summary>
        /// Ajouter un client au dictionnaire de clients
        /// SINON afficher un message d'erreur
        /// </summary>
        /// <param name="cli"></param>
        public static void AjouterClient(Client cli)  // Ajoute un client au dictionnaire
        {
            //Vérifier que le numéro d'identification n'existe pas
            if (listClients.ContainsKey(cli.noIdentificaiton = null))
                ListeClients.Add(cli.noIdentification.ToString(), cli);
            else MessageBox.Show("Le numéro d'identification existe déjà", "Message"); // Sinon afficher message 
        }
        /// <summary>
        /// Supprimer un client du dictionnaire de clients si son numéro d'identification existe déjà
        /// SINON afficher un message d'erreur
        /// </summary>
        /// <param name="noIdentification"></param>
        public static void SupprimerClient(int noIdentification) // supprime l’article sélectionné de la liste.
        {
            //Vérifier que le client existe dans le dictionnaire en fonction de son numéro
            //d'identification avant de le supprimer
            if (listClients.ContainsKey(noIdentification))
            {
                listClients.Remove(noIdentification);
            }
            else MessageBox.Show("Le client n'existe pas", "Message"); //Sinon afficher un message
        }
        /// <summary>
        /// Modifier un client si son numéro d'identification existe déjà
        /// SINON afficher un message d'erreur
        /// </summary>
        /// <param name="client"></param>
        public static void ModifierClient(Client client) // modifier le client donné en paramètre.
        {
            //Vérifier que le client existe dans le diictionnaire
            if (listClients.ContainsKey(client.noIdentification))
            {
                ListClients.Remove(client.noIdentification); ;
                ListClients.Add(client.noIdentification, client);
            }
            else MessageBox.Show("Le client n'existe pas", "Message");//Sinon afficher message
        }
    }
}
