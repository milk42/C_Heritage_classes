using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageClasses
{
    // Chapue opération sur ce compte est débité de 0.025 euros
    class ComptePayant : Compte
    {
        public ComptePayant(double solde) : base(solde)
        {
        }
   
        public override void Deposer(double solde, double montant)
        {
            base.Deposer(solde, montant);
            solde -= 0.025;
            // + 0.025
        }
        public override void Retirer(double solde, double montant)
        {
            base.Retirer(solde, montant);
            solde -= 0.025;
            // + 0.025
        }

    }
}
