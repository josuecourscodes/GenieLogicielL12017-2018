using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManageSingleConnexion
{
    public class Connexion
    {
        public Connexion()
        {
        }

        private string _serveur = "localhost";

        public string Serveur
        {
            get { return _serveur; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Le nom du serveur ne doit pas être vide");
                else
                    _serveur = value;
            }
        }
        private string _database = "database";

        public string Database
        {
            get { return _database; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Le nom de la base de données ne doit pas être vide");
                else
                    _database = value;
            }
        }
        private string _user = "user";

        public string User
        {
            get { return _user; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Le nom de l'utilisateur ne doit pas être vide");
                else
                    _user = value;
            }
        }
        private string _password = "password";

        public string Password
        {
            get { return _password; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Le mot de passe ne doit pas être vide");
                else
                    _password = value;
            }
        }

        private int _port = 0;

        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }
    }
}
