using System;
using System.Collections.Generic;
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
                return this._NomDeLaRue;
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
                return this._Ville;
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
                return this._Pays;
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

            Console.WriteLine("Nom de la rue: ");
            string nomDeRue = Console.ReadLine();

            Console.WriteLine("Code postal: ");
            string codePostal = Console.ReadLine();

            Console.WriteLine("Nom de la ville: ");
            string ville = Console.ReadLine();

            Console.WriteLine("Nom du pays: ");
            string pays = Console.ReadLine();

           var adresse = new Adresse( numeroRue, nomDeRue, codePostal, ville, pays);
            return adresse;
        }
        public string AfficherAdresse()
        {

          return  String.Format("son adresse est " + this.NumeroDeRue + " ," + this.NomDeRue + " ," + this.CodePostal + "," + this.Ville 
                + "," + this.Pays + ".");
           
        }

        #endregion

    }
}
