using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageClasses
{
    class Compte
    {
        // attributs dont la valeur ne peut pas changer
        // solde et code => accèssible en lecture seule ?
        private double solde = 0;
        private int code = 1234;
        private double montant;

        // Je vais pouvoir modifier la valeur depuis ces propriétés
        public double Solde { get { return this.solde; } set { solde = value; } }

        public int Code { get { return this.code; } set { code = value; } }

        // Constructeur de base
        public Compte(double solde)
        {
            this.code += 1;
            this.solde = solde;
        }

        // méthodes de base
        public virtual void Deposer(double solde, double  montant)
        {
            // Console.WriteLine("Je dépose sur mon compte");
            this.montant += solde;
        }
        public virtual void Retirer(double solde, double montant)
        {
            // Console.WriteLine("Je retire sur mon compte");
            this.montant -= solde;
        }

        public override string ToString()
        {
            return "Le solde actuel de mon compte est de : " + this.solde;
        }
    }
}
