using System;
using System.Data;

namespace ManageSingleConnexion
{
    public interface IConnexion
    {
        IDbConnection Initialise(Connexion connexion);
    }
}
