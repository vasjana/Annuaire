using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire
{
    public class Utilisateur
    {
        #region Attributs

        private string _Nom {get;set;}
        private string _Prenom { get; set; }
        private int _NumeroDeTelephone{ get; set; }
        private string _Login { get; set; }

        #endregion

        #region Méthodes

        public void AfficherInformationUtilisateur(string nom, string prenom, int tel, string login)
        {
            _Nom = nom;
            _Prenom = prenom;
            _NumeroDeTelephone = tel;
            _Login = login;

            Console.WriteLine("Le nom d'utilisateur est " + _Nom);
            Console.WriteLine("Le prenom d'utilisateur est " + _Prenom);
            Console.WriteLine("Le numéro de téléphone d'utilisateur est " + _NumeroDeTelephone);
            Console.WriteLine("Login: " + _Login);

        }

        #endregion
    }
}
