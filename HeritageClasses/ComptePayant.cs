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
        public ComptePayant(double solde, int code, double montant) : base(solde, code, montant)
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

    }
}
