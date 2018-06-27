using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageClasses
{
    class CompteEpargne : Compte
    {
        private double tauxInteret = 1.5;

        // Si jamais le taux d'intérêt change
        public double TauxInteret
        {
            get { return this.tauxInteret; }
        }

        public CompteEpargne(double solde, double tauxInteret) : base(solde)
        {
            this.tauxInteret = tauxInteret;
        }

        public override void Deposer(double solde, double montant)
        {
            base.Deposer(solde, montant);
 
        }
        public override void Retirer(double solde, double montant)
        {
            base.Retirer(solde, montant);
        }

        // Met à jour le solde en prenant en compte les intérêts
        //public double calculInteret()
        //{
        //    return (tauxInteret * 100) / solde; 
        //}
    }
}
