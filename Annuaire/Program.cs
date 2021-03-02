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
            Utilisateur utilisateur = new Utilisateur();
            utilisateur = utilisateur.CreerUtilisateur();

            string path = @"D:\csharp\Annuaire\Output\Annuaire1.xlsx";
            GestionExcel gestionExcel = new GestionExcel(path, utilisateur);
            gestionExcel.CreerExcelFile();

        }

        


    }




}
