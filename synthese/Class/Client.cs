﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace synthese.Class
{
    public static class Client
    {
        //Champs privés
        private static string nom;
        private static string prenom;
        private static string courriel;
        private static string noTelephone;
        private static int noIdentification;
        private static string typeUsager;
        // la liste des usagers dont la clé est leur numéro d'identification.
        private static Dictionary<int, Client> listClients;

        //Déclaration des propriétés
        public static string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public static string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public static string Courriel
        {
            get { return courriel; }
            set { courriel = value; }
        }
        public static string Telephone
        {
            get { return noTelephone; }
            set { noTelephone = value; }
        }
        public static int NoIdentification
        {
            get { return noIdentification; }
            set { noIdentification = value; }
        }
        public static string TypeUsager
        {
            get { return typeUsager; }
            set { typeUsager = value; }
        }
        public static Dictionary<string, Client> ListClients
        {
            get { return listClients; }
            set { listClients = value; }
        }

        //Constructeur par défaut
        static Client()
        {
            prenom = "";
            nom = "";
            courriel = "";
            noTelephone = "";
            noIdentification = 0;
            typeUsager = "";
            listClients = null;
            listClients = new Dictionary<string, Client>();
        }

        //Méthode
        public static void AjouterClient(Client cli)  // Ajoute un client au dictionnaire
        {
            //Vérifier que le numéro d'identification n'existe pas
            if (listClients.ContainsKey(cli.noIdentificaiton = null))
                ListeClients.Add(cli.noIdentification.ToString(), cli);
            else MessageBox.Show("Le numéro d'identification existe déjà", "Message"); // Sinon afficher message 
        }
        public static void SupprimerClient(int noIdentification) // supprime l’article sélectionné de la liste.
        {
            //Vérifier que le client existe dans le dictionnaire avant de le supprimer
            if (listClients.ContainsKey(noIdentification))
            {
                listClients.Remove(noIdentification);
            }
            else MessageBox.Show("Le client n'existe pas", "Message"); //Sinon afficher un message
        }
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
