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

        private string _Nom { get; set; }
        private string _Prenom { get; set; }
        private string _NumeroDeTelephone { get; set; }
        private string _Login { get; set; }
        private Adresse _Adresse { get; set; }

        #endregion

        #region Propriétés 

        public string Nom
        {
            get
            {
                return this._Nom;
            }
            set
            {
                this._Nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return this._Prenom;
            }
            set
            {
                this._Prenom = value;
            }
        }

        public string Tel
        {
            get
            {
                return this._NumeroDeTelephone;
            }
            set
            {
                this._NumeroDeTelephone = value;
            }
        }

        public string Login
        {
            get
            {
                return this._Login;
            }
            set
            {
                this._Login = value;
            }
        }

        public Adresse Adresse
        {
            get
            {
                return this._Adresse;
            }
            set
            {
                this._Adresse = value;
            }
        }

        #endregion

        #region Constructeur

        public Utilisateur()
        {
            this._Nom = string.Empty;
            this._Prenom = string.Empty;
            this._NumeroDeTelephone = string.Empty;
            this._Login = string.Empty;
            this._Adresse = new Adresse();
        }

        public Utilisateur(string nom, string prenom, string tel, string login, Adresse adresse) 
            {
               this._Nom = nom;
               this._Prenom = prenom;
               this._NumeroDeTelephone = tel;
               this._Login = login;
               this._Adresse = adresse;
            }

        #endregion

        #region Méthodes


        public Utilisateur  CreerUtilisateur()
        {
            Console.WriteLine("Bienvenue! Veuillez rentrer vos informations: ");
            Console.WriteLine("Nom d' utilisateur: ");
             string nom = Console.ReadLine();

            Console.WriteLine("Prénom d' utilisateur: ");
            string prenom = Console.ReadLine();

            Console.WriteLine("Numéro de téléphone d' utilisateur: ");
            string tel = Console.ReadLine();

            Console.WriteLine("Login d' utilisateur: ");
            string login = Console.ReadLine();

           var  adresse = new Adresse();
           adresse = adresse.CreerAdresse();
            
            var utilisateur = new Utilisateur(nom, prenom, tel, login, adresse);
            return utilisateur;
        }

        public void AfficherInformationUtilisateur()

        { 

            Console.WriteLine("L'utilisateur " + this.Nom + " " + this.Prenom + ", avec numéro de téléphone " +
                   this.Tel + ", login " + this.Login + " " +  this.Adresse.AfficherAdresse());
            Console.ReadLine();
             
           
        }


    #endregion
}
}
