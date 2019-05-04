using System;
using System.Collections.Generic;
using System.Data;
using GestionPersonneUtilitiesLib;
using ManageSingleConnexion;

namespace GestionPersonneLib
{
    public class Telephone:ITelephone
    {
        public Telephone()
        {
        }

        private int _id;
        private int _id_proprietaire;
        private string _initial;
        private string _numero;

        #region ITelephone Members

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public int Id_proprietaire
        {
            get
            {
                return _id_proprietaire;
            }
            set
            {
                _id_proprietaire = value;
            }
        }

        public string Initial
        {
            get
            {
                return _initial;
            }
            set
            {
                _initial = value;
            }
        }

        public string Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
            }
        }

        public string NumeroComplet
        {
            get 
            {
                return this._initial + this._numero;
            }
        }

        public int Nouveau()
        {
            int identifiant = 0;
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"select MAX(id) as lastId from telephone";
                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    if (rd["lastId"] == DBNull.Value)
                        identifiant = 1;
                    else
                        identifiant = int.Parse(rd["lastId"].ToString()) + 1;
                }

                rd.Dispose();
            }

            return identifiant;
        }

        public void Enregistrer(ITelephone t)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"if not exists (select * from telephone where id=@id)
                insert into telephone(id,id_personne,initial,numero) 
                values(@id,@id_personne,@initial,@numero)
                else update telephone set id_personne=@id_personne,initial=@initial,numero=@numero where id=@id";

                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, t.Id));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id_personne", 4, DbType.Int32, t.Id_proprietaire));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@initial", 4, DbType.String, t.Initial));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@numero", 9, DbType.String, t.Numero));

                cmd.ExecuteNonQuery();
            }
        }

        public void Modifier(ITelephone t)
        {
            throw new NotImplementedException();
        }

        public void Supprimer(int id)
        {
            if (ImplementeConnexion.Instance.Conn.State != ConnectionState.Open)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"if exists (select * from telephone where id=@id)
                                  delete from telephone where id=@id";
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, this._id));

                int record = cmd.ExecuteNonQuery();

                if (record <= 0)
                    throw new Exception("L'enregistrement que vous tentez de supprimer n'existe pas");
            }
        }

        public List<ITelephone> Telephones()
        {
            List<ITelephone> telephones = new List<ITelephone>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"select id,id_personne,initial,numero from telephone";

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    ITelephone t = new Telephone();

                    t.Id = int.Parse(rd["id"].ToString());
                    t.Id_proprietaire = int.Parse(rd["id_personne"].ToString());
                    t.Initial = rd["initial"].ToString();
                    t.Numero = rd["numero"].ToString();

                    telephones.Add(t);
                }

                rd.Dispose();
            }

            return telephones;
        }

        public ITelephone OneTelephone(int id)
        {
            ITelephone t = new Telephone();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"select id,id_personne,initial,numero from telephone where id=@id";

                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    t.Id = int.Parse(rd["id"].ToString());
                    t.Id_proprietaire = int.Parse(rd["id_personne"].ToString());
                    t.Initial = rd["initial"].ToString();
                    t.Numero = rd["numero"].ToString();
                }

                rd.Dispose();
            }

            return t;
        }

        public List<ITelephone> TelephonesPersonne(int id_personne)
        {
            List<ITelephone> telephonesPersonne = new List<ITelephone>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"select id,id_personne,initial,numero from telephone 
                    where id_personne=@id_personne";

                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id_personne", 4, DbType.Int32, id_personne));

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    ITelephone t = new Telephone();

                    t.Id = int.Parse(rd["id"].ToString());
                    t.Id_proprietaire = int.Parse(rd["id_personne"].ToString());
                    t.Initial = rd["initial"].ToString();
                    t.Numero = rd["numero"].ToString();

                    telephonesPersonne.Add(t);
                }

                rd.Dispose();
            }

            return telephonesPersonne;
        }

        #endregion
    }
}
