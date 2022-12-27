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
    internal class Articles
    {
        //Attributs
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private string connectionString;
        private DataTable dtProjetSynthese;
        private DataSet dsArticles;


        //Propriétés

        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public string ConnectionString { get => connectionString; }     // Pas de set afin de bloquer la possibilité de la modifier
        public DataTable DtProjetSynthese { get => dtProjetSynthese; set => dtProjetSynthese = value; }
        public DataSet DsArticles { get => dsArticles; set => dsArticles = value; }

        //Constructeur par paramètres
        public Articles()
        {
            // Integrated Security = True;
            connectionString = "Data Source=1105R1PC1;Initial Catalog=ProjetSynthese;User ID=sa";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            adapter = new SqlDataAdapter();
            dsArticles = new DataSet();
            dtProjetSynthese = new DataTable();
        }

        // ** Exercices Interface_ClassesMeres avec les animaux **
        // Méthode abstraite Consommer().
        // Cette méthode doit être surchagée (Override) dans les classes filles. 
        public abstract void Consommer();
    }
}
