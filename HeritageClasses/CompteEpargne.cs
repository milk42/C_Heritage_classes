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

        public CompteEpargne() : base()
        {
        }

        public CompteEpargne(double solde) : base(solde)
        {
        }

        public override void Deposer(double solde)
        {
            base.Deposer(solde);
 
        }
        public override void Retirer(double solde)
        {
            base.Retirer(solde);
        }

        // Met à jour le solde en prenant en compte les intérêts
        public void CalculInteret()
        {
            // pas besoin d'appeler la méthode Déposer avec Compte.Deposer
            Deposer((Solde * this.tauxInteret) / 100);
        }

        public override string ToString()
        {
            return base.ToString() + " et son taux d'interêt est de : " + this.tauxInteret + " [Compte Epargne] ";
        }
    }
}
