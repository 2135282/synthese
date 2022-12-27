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
        private object textBoxNumero;

        //Déclaration des propriétés
        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public string ConnectionString { get => connectionString; }     // Pas de set afin de bloquer la possibilité de la modifier
        public DataTable DtProjetSynthese { get => dtProjetSynthese; set => dtProjetSynthese = value; }
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
    }
}
