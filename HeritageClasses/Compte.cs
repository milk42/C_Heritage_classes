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
        private double solde;
        private int code;
        private double montant;

        // Je vais pouvoir modifier la valeur depuis ces propriétés
        public double Solde { get { return this.solde; } }

        public int Code { get { return this.code; } }

        // Constructeur de base
        public Compte(double solde, int code, double montant)
        {
            this.solde = solde;
            this.code = code;
            this.montant = montant;
        }

        // méthodes de base
        public virtual void Deposer()
        {
            Console.WriteLine("Je dépose sur mon compte, la somme de " + montant);
        }
        public virtual void Retirer()
        {
            Console.WriteLine("Je retire sur mon compte, la somme de " + montant);
        }

        public override string ToString()
        {
            return "Le solde actuel de mon compte est de : " + this.solde;
        }
    }
}
