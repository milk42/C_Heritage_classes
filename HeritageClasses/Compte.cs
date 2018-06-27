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
        private double montant;
        private int code;
        private static int comptes;
        // private double montant;

        // Je vais pouvoir modifier la valeur depuis ces propriétés
        // pas besoin de SET car on veut juste récupérer la valeur
        public double Montant { get { return this.montant; }}

        public int Code { get { return this.code; }}

        public static int Comptes { get { return comptes; }}



        // Constructeurs de base
        public Compte()
        {
            comptes++;
            this.code = comptes;
        }

        public Compte(double solde)
        {
            comptes++;
            this.code = comptes;
            this.montant = solde;
        }

        // méthodes de base
        // Virtual donne le droite de redéfinir la méthode dans sa classe fille
        public virtual void Deposer(double solde)
        {
            // Console.WriteLine("Je dépose sur mon compte");
            this.montant += solde;
        }
        public virtual void Retirer(double solde)
        {
            // Console.WriteLine("Je retire sur mon compte");
            this.montant -= solde;
        }

        public override string ToString()
        {
            // return "Le solde actuel du compte n° " + this.code + " est de : " + this.solde;
            return "Le solde actuel du compte n° " + this.code + " est de : " + this.montant;
        }
    }
}
