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
        private double solde = 0; // Pas besoin de mettre zéro par défaut
        private int code = 1234; // Attention, le code n'a pas de valeur par défaut, c'est le constructeur qui l'incrémente à partir de zéro.
        private double montant;

        // Je vais pouvoir modifier la valeur depuis ces propriétés
        public double Solde { get { return this.solde; } set { solde = value; } } // Attention, la propriété Solde permet uniquement de récupérer la valeur du solde(solde), ne pas faire de "set"        

        public int Code { get { return this.code; } set { code = value; } }  // Attention, pas de set dans la propriété Code

        // Constructeur de base
        public Compte(double solde)
        {
            this.code += 1;
            this.solde = solde;
        }
        
        // D'après l'exercice il doit y avoir 2 constructeurs. Créer un deuxième constructeur qui ne prend rien en entrée

        // méthodes de base
        public virtual void Deposer(double solde, double  montant) // Attention, on ne dépose pas un solde, mais plutôt un montant
        {
            // Console.WriteLine("Je dépose sur mon compte");
            this.montant += solde; // Attention, c'est le solde qui doit être augmenté du montant versé (this.solde += montant;)
        }
        public virtual void Retirer(double solde, double montant) // Attention, on ne dépose pas un solde, mais plutôt un montant
        {
            // Console.WriteLine("Je retire sur mon compte");
            this.montant -= solde; // Attention, c'est le solde qui doit être diminué du montant retiré (this.solde -= montant)
        }

        public override string ToString()
        {
            return "Le solde actuel de mon compte est de : " + this.solde;
        }
    }
}
