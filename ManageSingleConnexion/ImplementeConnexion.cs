using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Oracle.DataAccess.Client;

namespace ManageSingleConnexion
{
    public class ImplementeConnexion:IConnexion
    {
        private ImplementeConnexion()
        {
        }

        private static ImplementeConnexion _instance;

        public static ImplementeConnexion Instance
        {
            get 
            {
                if (_instance == null)
                    _instance = new ImplementeConnexion();
                return _instance; 
            }
        }

        private IDbConnection conn;

        public IDbConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }
        private ConnexionType _conType;

        public ConnexionType ConType
        {
            get { return _conType; }
            set { _conType = value; }
        }

        #region IConnexion Members

        public IDbConnection Initialise(Connexion connexion)  
        {
            switch (_conType)
            {
                case ConnexionType.SQLServer:
                    Conn = new SqlConnection(String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}",
                        connexion.Serveur,connexion.Database,connexion.User,connexion.Password));
                    break;
                case ConnexionType.MySQL:
                    Conn = new MySqlConnection(String.Format("Server={0};Database={1};User id={2};Pwd={3};Port={4}",
                        connexion.Serveur, connexion.Database, connexion.User, connexion.Password,connexion.Port));
                    break;
                case ConnexionType.Oracle:
                    ////Conn = new OracleConnection(String.Format("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = {0})(PORT = {1}))(CONNECT_DATA = (SERVER=DEDICARED)(SERVICE_NAME = {2})));User ID={3};Password={4}",
                    ////    connexion.Serveur, connexion.Port, "TNSNames.ora", connexion.User, connexion.Password));

                    ////Conn = new OracleConnection(String.Format("Driver=(Oracle in XEClient);dbq={0}:1521/{1};Uid={2};Pwd={3};",
                    ////    connexion.Serveur, connexion.Port, connexion.Database, connexion.User, connexion.Password));

                    //Conn = new OracleConnection(String.Format("User ID={0};Password={1};Host={2};Pooling=true;Min Pool Size=0;Max Pool Size=100;Connection Lifetime=0;",
                    //    connexion.User, connexion.Password, "ora", connexion.User));

                    ////Conn = new OracleConnection(String.Format("User Id={0};Password={1};Data Source=(DESCRIPTION=" +
                    ////    "(ADDRESS=(PROTOCOL=TCP)(HOST={2})(PORT={3}))" +
                    ////    "(CONNECT_DATA=(SID=yourSID)));", connexion.Database, connexion.Password, connexion.Serveur, connexion.Port));
                    //(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = JOSAM)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = XE)))
                    Conn = null;
                    break;
                case ConnexionType.PostGreSQL:
                    Conn = null;
                    break;
                case ConnexionType.Access:
                    Conn = null;
                    break;
            }

            return Conn;
        }

        #endregion
    }
}
