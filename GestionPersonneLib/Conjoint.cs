using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionPersonneLib
{
    public class Conjoint:IPersonne
    {
        public Conjoint()
        {
        }

        private int _id;
        private string _nom;
        private string _postnom;
        private string _prenom;
        private Sexe _sex;
        private List<ITelephone> _telephonePersonnes;

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
            throw new NotImplementedException();
        }

        public void Enregistrer(IPersonne p)
        {
            throw new NotImplementedException();
        }

        public void EnregistrerTransaction(IPersonne p)
        {
            throw new NotImplementedException();
        }

        public void Modifier(IPersonne p)
        {
            throw new NotImplementedException();
        }

        public void Supprimer(int id)
        {
            throw new NotImplementedException();
        }

        public List<IPersonne> Personnes()
        {
            throw new NotImplementedException();
        }

        public IPersonne OnePersonne(int id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
