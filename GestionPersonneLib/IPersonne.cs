using System;
using System.Collections.Generic;

namespace GestionPersonneLib
{
    public interface IPersonne
    {
        int Id { get; set; }
        string Nom { get; set; }
        string Postnom { get; set; }
        string Prenom { get; set; }
        Sexe sex { get; set; }
        List<ITelephone> TelephonePersonne { get; }
        int Nouveau();
        void Enregistrer(IPersonne p);
        void EnregistrerTransaction(IPersonne p);
        void Modifier(IPersonne p);
        void Supprimer(int id);
        List<IPersonne> Personnes();
        IPersonne OnePersonne(int id);
    }
}
