using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    // Permet l'utilisation des classes SqlConnection, SqlCommand et SqlAdapter
using System.Data;              // Permet l'utilisation des classes DataSet et DataTable

namespace synthese.Class
    // **** Association avec les foreign key: Client peut voir ses propres Emprunts
{
    public class Client
    {
        //Champs privés
        // la liste des usagers dont la clé est leur numéro d'identification.
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private string connectionString;
        private DataTable dtProjetSynthese;
        private DataSet dsClients;

        //Déclaration des propriétés
        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public string ConnectionString { get => connectionString; }     // Pas de set afin de bloquer la possibilité de la modifier
        public DataTable DtEtudiants { get => dtProjetSynthese; set => dtProjetSynthese = value; }
        public DataSet DsClients { get => dsClients; set => dsClients = value; }

        //Constructeur par défaut
        public Client()
        {
            // Integrated Security = True;
            connectionString = "Data Source=1105R1PC1;Initial Catalog=ProjetSynthese;User ID=sa";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            adapter = new SqlDataAdapter();
            dsClients = new DataSet();
            dtProjetSynthese = new DataTable();
        }

        //Méthodes

        /// <summary>
        /// Ajouter un client au dictionnaire de clients
        /// SINON afficher un message d'erreur
        /// </summary>
        /// <param name="cli"></param>
        public void AjouterClient(Client cli)  // Ajoute un client au dictionnaire
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
        public void SupprimerClient(int noIdentification) // supprime l’article sélectionné de la liste.
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
        public void ModifierClient(Client client) // modifier le client donné en paramètre.
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
