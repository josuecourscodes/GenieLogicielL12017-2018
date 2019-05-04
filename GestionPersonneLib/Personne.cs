using System;
using System.Collections.Generic;
using System.Data;
using GestionPersonneUtilitiesLib;
using ManageSingleConnexion;

namespace GestionPersonneLib
{
    public class Personne:IPersonne,IComparable
    {
        public Personne()
        {
        }

        private int _id;
        private string _nom;
        private string _postnom;
        private string _prenom;
        private Sexe _sex;
        private List<ITelephone> _telephonePersonnes;
        private Conjoint _personne_conjoint;

        public Conjoint Personne_conjoint
        {
            get { return _personne_conjoint; }
            set { _personne_conjoint = value; }
        }

        #region IPersonne Members

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

        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Le nom ne peut être vide");
                else
                    _nom = value;
            }
        }

        public string Postnom
        {
            get
            {
                return _postnom;
            }
            set
            {
                _postnom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }
            set
            {
                _prenom = value;
            }
        }

        public Sexe sex
        {
            get
            {
                return _sex;
            }
            set
            {
                _sex = value;
            }
        }

        public List<ITelephone> TelephonePersonne
        {
            get 
            {
                if (_telephonePersonnes == null)
                    _telephonePersonnes = new List<ITelephone>();

                _telephonePersonnes.Clear();
                    
                ITelephone telephone = new Telephone();

                _telephonePersonnes = telephone.TelephonesPersonne(this._id);

                return _telephonePersonnes; 
            }
        }

        public int Nouveau()
        {
            int identifiant = 0;
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"select MAX(id) as lastId from personne";
                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    if (rd["lastId"] == DBNull.Value)
                        identifiant = 1;
                    else 
                        identifiant = int.Parse(rd["lastId"].ToString()) + 1;
                }
                //else
                //    identifiant = 1;

                rd.Dispose();
            }

            return identifiant;
        }

        public void Enregistrer(IPersonne p)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"if not exists (select * from personne where id=@id)
                insert into personne(id,nom,postnom,prenom,sexe) 
                values(@id,@nom,@postnom,@prenom,@sexe)
                else update personne set nom=@nom,postnom=@postnom,prenom=@prenom,sexe=@sexe where id=@id";

                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, p.Id));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@nom", 50, DbType.String, p.Nom));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@postnom", 50, DbType.String, p.Postnom));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@prenom", 50, DbType.String, p.Prenom));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@sexe", 1, DbType.String, p.sex == Sexe.Masculin ? "M" : "F"));

                cmd.ExecuteNonQuery();
            }
        }

        public void EnregistrerTransaction(IPersonne p)
        {
            IDbTransaction transaction = null;
            IDbCommand cmd = null;

            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();

                transaction = ImplementeConnexion.Instance.Conn.BeginTransaction(IsolationLevel.Serializable);

                cmd = ImplementeConnexion.Instance.Conn.CreateCommand();

                cmd.CommandText = @"if not exists (select1 * from personne where id=@id)
                insert into personne(id,nom,postnom,prenom,sexe) 
                values(@id,@nom,@postnom,@prenom,@sexe)
                else update personne set nom=@nom,postnom=@postnom,prenom=@prenom,sexe=@sexe where id=@id";

                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, p.Id));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@nom", 50, DbType.String, p.Nom));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@postnom", 50, DbType.String, p.Postnom));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@prenom", 50, DbType.String, p.Prenom));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@sexe", 1, DbType.String, p.sex == Sexe.Masculin ? "M" : "F"));

                //Integration du commande a la transaction
                cmd.Transaction = transaction;

                //if (p.Id == 6)
                //    transaction.Rollback();
                //else
                    

                cmd.ExecuteNonQuery();
                transaction.Commit();

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                    transaction.Dispose();
                    cmd.Dispose();

                    throw new Exception(ex.Message);
                }
            }
        }

        public void Modifier(IPersonne p)
        {
            throw new NotImplementedException();
        }

        public void Supprimer(int id)
        {
            if (ImplementeConnexion.Instance.Conn.State != ConnectionState.Open)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"if exists (select * from personne where id=@id)
                                  delete from personne where id=@id";
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd,"@id",4,DbType.Int32,this._id));

                int record = cmd.ExecuteNonQuery();

                if (record <= 0)
                    throw new Exception("L'enregistrement que vous tentez de supprimer n'existe pas");
            }
        }

        public List<IPersonne> Personnes()
        {
            List<IPersonne> personnes = new List<IPersonne>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open(); 

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"select id,nom,postnom,prenom,sexe from personne";

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    IPersonne p = new Personne();
                    
                    p.Id = int.Parse(rd["id"].ToString());
                    p.Nom = rd["nom"].ToString();
                    p.Postnom = Convert.ToString(rd["postnom"]);
                    p.Prenom = rd["prenom"].ToString();
                    p.sex = rd["sexe"].ToString().Equals("M") ? Sexe.Masculin : Sexe.Féminin;

                    personnes.Add(p); 
                }

                rd.Dispose();
            }

            return personnes;
        }

        //Recherche Personne
        //Array.Sort(personnes.ToArray());
        //Array.BinarySearch(personnes.ToArray(), "v");Recherche dichotomique

        public IPersonne OnePersonne(int id)
        {
            IPersonne p = new Personne();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"select id,nom,postnom,prenom,sexe from personne where id=@id";

                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    p.Id = int.Parse(rd["id"].ToString());
                    p.Nom = rd["nom"].ToString();
                    p.Postnom = Convert.ToString(rd["postnom"]);
                    p.Prenom = rd["prenom"].ToString();
                    p.sex = rd["sexe"].ToString().Equals("M") ? Sexe.Masculin : Sexe.Féminin;
                }

                rd.Dispose();
            }

            return p;
        }

        public override string ToString()
        {
            return this._nom + " " + this._prenom + " " + this._postnom.Trim();
        }

        #endregion

        #region IComparable Members

        public int CompareTo(object obj)
        {
            IPersonne p = (IPersonne)obj;
            int resultNom = Nom.CompareTo(p.Nom);
            int resultPNom = Postnom.CompareTo(p.Postnom);
            int resultPreNom = Prenom.CompareTo(p.Prenom);
            int goodResult = -1;

            if (resultNom == 0 && resultPNom == 0 && resultPreNom == 0)
                goodResult = 0;

            return goodResult;
        }

        #endregion
    }
}
