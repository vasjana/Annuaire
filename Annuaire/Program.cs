using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue! Veuillez rentrer vos informations: "); 
            Console.WriteLine("Nom d' utilisateur: ");
            string Nom = Console.ReadLine();
            Console.WriteLine("Prénom d' utilisateur: ");
            string Prenom = Console.ReadLine();
            Console.WriteLine("Numéro de téléphone d' utilisateur: ");
            int Tel = int.Parse(Console.ReadLine());
            Console.WriteLine("Login d' utilisateur: ");
            string Login = Console.ReadLine();
            Console.WriteLine("Numéro de la rue: ");
            int NumeroDeLaRue = int.Parse(Console.ReadLine());
            Console.WriteLine("Nom de la rue: ");
            string NomDeLaRue = Console.ReadLine();
            Console.WriteLine("Code postal: ");
            int CodePostal = int.Parse(Console.ReadLine());
            Console.WriteLine("Nom de la ville: ");
            string Ville = Console.ReadLine();
            Console.WriteLine("Nom du pays: ");
            string Pays = Console.ReadLine();

            Console.WriteLine(string.Empty);
            AfficherInformationUtilisateur(Nom, Prenom, Tel, Login);
            AfficherAdress(NumeroDeLaRue, NomDeLaRue, CodePostal, Ville, Pays);
            Console.ReadLine();
        }

        private static void AfficherInformationUtilisateur(string nom, string prenom, int tel, string login)
        {
            Console.WriteLine("Le nom d'utilisateur est " + nom);
            Console.WriteLine("Le prenom d'utilisateur est " + prenom);
            Console.WriteLine("Le numéro de téléphone d'utilisateur est " + tel);
            Console.WriteLine("Login: " + login);
        }

        public  static void AfficherAdress(int numeroderue, string nomdelarue, int codepostal, string ville, string pays)
        {
            
            Console.WriteLine("L'adresse est " + " " + numeroderue + " " + nomdelarue + ", " + codepostal + ", " 
                 + ville + ", "+ pays + ".");

        }
    }
}
