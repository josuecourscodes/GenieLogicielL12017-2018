using System;
using System.Data;

namespace GestionPersonneUtilitiesLib
{
    public class Parametres
    {
        private Parametres()
        {
        }

        private static Parametres _instance;

        public static Parametres Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Parametres();
                return Parametres._instance; 
            }
        }

        public IDbDataParameter AjouterParametre(IDbCommand cmd, string nomParametre, int taille, DbType type, object valeur)
        {
            IDbDataParameter param = cmd.CreateParameter();
            param.ParameterName = nomParametre;
            param.Size = taille;
            param.DbType = type;
            param.Value = valeur;
            return param;
        }
    }
}
