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

        private int _NumeroDeLaRue { get; set; }
        private string _NomDeLaRue { get; set; }
        private int _CodePostal { get; set; }
        private string _Ville { get; set; }
        private string _Pays { get; set; }

        #endregion


        #region Méthodes

        public void AfficherAdress(int numeroderue, string nomdelarue, int codepostal, string ville, string pays)
        {
            _NumeroDeLaRue = numeroderue;
            _NomDeLaRue = nomdelarue;
            _CodePostal = codepostal;
            _Ville = ville;
            _Pays = pays;

            Console.WriteLine("L'adresse est " + _NumeroDeLaRue + " "  + _NomDeLaRue + " , "  + _CodePostal + " ,"
                + _Ville + ", "  + _Pays + ".");
           
        }

        #endregion

    }
}
