using System;
using System.Collections.Generic;
using System.Globalization;
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
                return this.AfficherMajuscule(_Nom);
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
                return this.AfficherPremiereLettreMajuscule(_Prenom);
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
             Verifer(nom);

            Console.WriteLine("Prénom d' utilisateur: ");
            string prenom = Console.ReadLine();
            Verifer(prenom);

            Console.WriteLine("Numéro de téléphone d' utilisateur: ");
            string tel = Console.ReadLine();
            Verifer(tel);
            FormaterStringNumeros(10, tel);
            VerifierNumbers(tel);

            Console.WriteLine("Login d' utilisateur: ");
            string login = Console.ReadLine();
            Verifer(login);

           var  adresse = new Adresse();
           adresse = adresse.CreerAdresse();
            
            var utilisateur = new Utilisateur(nom, prenom, tel, login, adresse);
            return utilisateur;
        }

        public void AfficherInformationUtilisateur()

        { 

            Console.WriteLine("L'utilisateur " +  this.Nom + " " + this.Prenom + ", avec numéro de téléphone " +
                   this.Tel + ", login " + this.Login + " " +  this.Adresse.AfficherAdresse());
            Console.ReadLine();
             
           
        }

        public string AfficherMajuscule ( string element)
        {
            return string.Format(element.ToUpper(new CultureInfo("fr-FR", false)));
        }

        public string AfficherPremiereLettreMajuscule ( string element)
        {
            return string.Format(element.Substring(0,1).ToUpper(new CultureInfo("fr-FR", false)) + element.Substring(1).ToLower(new CultureInfo("fr-FR", false)));
            
        }

        public void Verifer(string element)
        {
            if (string.IsNullOrEmpty(element))
            {
                throw new ArgumentNullException("element");
            }

        else if (string.IsNullOrWhiteSpace(element))
            {
                throw new ArgumentException("element");
            }

        }

        public void FormaterStringNumeros(int length, string element)
        {
            if (element.Length != length)
            {
                throw new ArgumentException(element + " doit avoir " + length + " chiffres.");
            }
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }


        public void VerifierNumbers(string element)
        {

            if (!this.IsDigitsOnly(element))
            {
                throw new ArgumentException(element + " doit avoir que des chiffres.");
            }
        }
        

        #endregion



    }
}
