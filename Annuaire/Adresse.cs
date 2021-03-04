using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire
{
    public class Adresse 
    {
        #region Attributs

        private string _NumeroDeLaRue { get; set; }
        private string _NomDeLaRue { get; set; }
        private string _CodePostal { get; set; }
        private string _Ville { get; set; }
        private string _Pays { get; set; }

        #endregion

        #region Propriétés

        public string NumeroDeRue
        {
            get
            {
                return this._NumeroDeLaRue;
            }
            set
            {
                this._NumeroDeLaRue = value;
            }
        }


        public string NomDeRue
        {
            get
            {
                return this.AfficherPremiereLettreMajuscule(_NomDeLaRue);
            }
            set
            {
                this._NomDeLaRue = value;
            }
        }

        public string CodePostal
        {
            get
            {
                return this._CodePostal;
            }
            set
            {
                this._CodePostal = value;
            }
        }


        public string Ville
        {
            get
            {
                return this.AfficherPremiereLettreMajuscule(_Ville);
            }
            set
            {
                this._Ville = value;
            }
        }

        public string Pays
        {
            get
            {
                return this.AfficherPremiereLettreMajuscule(_Pays);
            }
            set
            {
               this._Pays = value;
            }
        }

        #endregion

        

        #region Constructeur

        public Adresse()
        {
            this._NumeroDeLaRue = string.Empty;
            this._NomDeLaRue = string.Empty;
            this._CodePostal = string.Empty;
            this._Ville = string.Empty;
            this._Pays = string.Empty;
        }

        public Adresse(string numeroderue, string nomderue, string codepostal, string ville, string pays)
        {
            this._NumeroDeLaRue = numeroderue;
            this._NomDeLaRue = nomderue;
            this._CodePostal = codepostal;
            this._Ville = ville;
            this._Pays = pays; 
        }

        #endregion

        #region Méthodes

        public Adresse CreerAdresse()
        {
            Console.WriteLine("Numéro de la rue: ");
            string numeroRue = Console.ReadLine();
            Verifer(numeroRue);
           if (numeroRue.Length > 2)
            {
                throw new ArgumentException( "Le numéro de la rue doit avoir maximum 2 chiffres.");
            }
            VerifierNumber(numeroRue);



            Console.WriteLine("Nom de la rue: ");
            string nomDeRue = Console.ReadLine();
            Verifer(nomDeRue);


            Console.WriteLine("Code postal: ");
            string codePostal = Console.ReadLine();
             Verifer(codePostal);            
            FormaterStringNumeros(5, codePostal);
            VerifierNumber(codePostal);

            Console.WriteLine("Nom de la ville: ");
            string ville = Console.ReadLine();
            Verifer(ville);

            Console.WriteLine("Nom du pays: ");
            string pays = Console.ReadLine();
            Verifer(pays);

           var adresse = new Adresse( numeroRue, nomDeRue, codePostal, ville, pays);
            return adresse;
        }
        public string AfficherAdresse()
        {

          return  String.Format("son adresse est " + this.NumeroDeRue + " ," + this.NomDeRue + " ," + this.CodePostal + "," + this.Ville 
                + "," + this.Pays + ".");
           
        }

        public string AfficherPremiereLettreMajuscule(string element)
        {
            return string.Format(element.Substring(0, 1).ToUpper(new CultureInfo("fr-FR", false)) + element.Substring(1).ToLower(new CultureInfo("fr-FR", false)));

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
               throw new ArgumentFormatException(element + " doit avoir " + length + " chiffres.");
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

        public void VerifierNumber(string nombreTexte)
        {

            if (!this.IsDigitsOnly(nombreTexte))

            {
                throw new ArgumentFormatException(nombreTexte + " doit avoir que des chiffres.");
            }
        }

        #endregion

    }
}
