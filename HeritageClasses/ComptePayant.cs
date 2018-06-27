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
        private double versement = 0.025;

        public ComptePayant() : base()
        {
        }
        public ComptePayant(double solde) : base(solde)
        {
        }
   
        public override void Deposer(double solde)
        {
            base.Deposer(solde);
            solde -= this.versement;
            // ou base.Retirer(this.versement);
        }
        public override void Retirer(double solde)
        {
            base.Retirer(solde);
            solde -= this.versement;
            // ou base.Retirer(this.versement);
        }

        public override string ToString()
        {
            return base.ToString() + " [Compte Payant] ";
        }

    }
}
