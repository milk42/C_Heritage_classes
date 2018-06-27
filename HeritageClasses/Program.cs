using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Compte> comptes = new List<Compte>();

            // Créer une instance de chaque type de compte
            Compte compteBase = new Compte(10000);
            CompteEpargne compteEpargne = new CompteEpargne(5000, 1.5);
            ComptePayant comptePayant = new ComptePayant(-300);

            comptes.Add(compteBase);
            comptes.Add(compteEpargne);
            comptes.Add(comptePayant);

            //double depot = compteBase.Deposer();

            // affiche le solde des 3 comptes
            foreach (var c in comptes)
            {
                c.ToString();
            }

            Console.WriteLine(compteBase.Code);
            Console.WriteLine(compteEpargne.Code);
            Console.ReadLine();

            // Faire appel à la méthode CalculInteret()
            // Faire appel à la méthode Retirer() de chaque instance pour retirer une somme quelquonque
            // Faire appel à la méthode Deposer() de chaque instance pour déposer une somme quelconque dans ces comptes 
        }
    }
}
