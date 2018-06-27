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
            Compte compteBase = new Compte();
            CompteEpargne compteEpargne = new CompteEpargne();
            ComptePayant comptePayant = new ComptePayant();

            comptes.Add(compteBase);
            comptes.Add(compteEpargne);
            comptes.Add(comptePayant);

            // Faire appel à la méthode Deposer() de chaque instance pour déposer une somme quelconque dans ces comptes 
            compteBase.Deposer(300);
            compteEpargne.Deposer(1525);
            comptePayant.Deposer(450);

            // Faire appel à la méthode Retirer() de chaque instance pour retirer une somme quelquonque
            compteBase.Retirer(20);
            compteEpargne.Retirer(30);
            comptePayant.Retirer(50);

            // Faire appel à la méthode CalculInteret()
            compteEpargne.CalculInteret();

            // affiche le solde des 3 comptes
            foreach (var c in comptes)
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine("-----------------------------------------------------------------------------------");

            Console.WriteLine(compteBase);
            Console.WriteLine(compteEpargne);
            Console.WriteLine(comptePayant);
            Console.ReadLine();

        }
    }
}
