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

        public CompteEpargne(double solde, int code, double montant) : base(solde, code, montant)
        {
        }

        public override void Deposer()
        {
            base.Deposer();
        }
        public override void Retirer()
        {
            base.Retirer();
        }

        // Met à jour le solde en prenant en compte les intérêts
        public double calculInteret()
        {
            return;
        }
    }
}
