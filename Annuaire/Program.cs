using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
namespace Annuaire
{
    class Program
    {


        static void Main(string[] args)
        {
            Utilisateur utilisateur = new Utilisateur();
            //utilisateur = utilisateur.CreerUtilisateur();




            // Creation d'un tableau excel
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var excel = new ExcelPackage(new FileInfo(@"D:\csharp\Annuaire\Output\Annuaire.xlsx")))
            {
                // Load the worksheet
                //excel.Workbook.Worksheets.Add("Worksheet1");
                var excelWorksheet = excel.Workbook.Worksheets["Worksheet1"];



                //int countRows = excelWorksheet.Dimension.End.Row;

                //// Add Row 3
                ////Add some items...

                //excelWorksheet.Cells[countRows + 1, 1].Value = utilisateur.Login;
                //excelWorksheet.Cells[countRows + 1, 2].Value = utilisateur.Nom;
                //excelWorksheet.Cells[countRows + 1, 3].Value = utilisateur.Prenom;
                //excelWorksheet.Cells[countRows + 1, 4].Value = utilisateur.Tel;
                //excelWorksheet.Cells[countRows + 1, 5].Value = utilisateur.Adresse.NumeroDeRue;
                //excelWorksheet.Cells[countRows + 1, 6].Value = utilisateur.Adresse.NomDeRue;
                //excelWorksheet.Cells[countRows + 1, 7].Value = utilisateur.Adresse.CodePostal;
                //excelWorksheet.Cells[countRows + 1, 8].Value = utilisateur.Adresse.Ville;
                //excelWorksheet.Cells[countRows + 1, 9].Value = utilisateur.Adresse.Pays;

                //try
                //{
                //    utilisateur.Tel;

                //}


                int colCount = excelWorksheet.Dimension.End.Column;  //get Column Count
                int rowCount = excelWorksheet.Dimension.End.Row;     //get row count

                Console.WriteLine(" Cet tableau a " + rowCount + " lignes.");

                //for (int row = 1; row <= rowCount - 1; row++)
                //{
                //Console.WriteLine("L'utilisateur : " + excelWorksheet.Cells[row + 1, 1].Value + ", son nom est " + excelWorksheet.Cells[row + 1, 2].Value
                //    + " " + excelWorksheet.Cells[row + 1, 3].Value + ", son numéro de téléphone est " + excelWorksheet.Cells[row + 1, 4].Value
                //    + ", son adresse est " + excelWorksheet.Cells[row + 1, 5].Value + "," + excelWorksheet.Cells[row + 1, 6].Value
                //    + "," + excelWorksheet.Cells[row + 1, 7].Value + "," + excelWorksheet.Cells[row + 1, 8].Value + "," + excelWorksheet.Cells[row + 1, 9].Value
                //    + ".");

                ////Console.WriteLine("L'utilisateur : " + excelWorksheet.Cells[row + 1, col].Value + ", son nom est " + excelWorksheet.Cells[row + 1, col].Value
                ////   + " " + excelWorksheet.Cells[row + 1, col].Value + ", son numéro de téléphone est " + excelWorksheet.Cells[row + 1, col].Value
                ////   + ", son adresse est " + excelWorksheet.Cells[row + 1, col].Value + "," + excelWorksheet.Cells[row + 1, col].Value
                ////   + "," + excelWorksheet.Cells[row + 1, col].Value + "," + excelWorksheet.Cells[row + 1, col].Value + "," + excelWorksheet.Cells[row + 1, col].Value
                ////   + ".");

                ////for (int col = 1; col <= colCount; col++)
                ////    {

                ////        Console.WriteLine("Le " + (row) + " utilisateur est " + excelWorksheet.Cells[row + 1, col].Value.ToString());
                ////        Console.ReadLine();
                ////    }

                //}

                //Console.ReadLine();


               


                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {
                        //new line
                        if (j == 1)
                            Console.Write("\r\n");

                        //write the value to the console
                        if (excelWorksheet.Cells[i, j] != null && excelWorksheet.Cells[i, j].Value != null)
                            Console.Write(excelWorksheet.Cells[i, j].Value.ToString() + "\t");

                        //add useful things here!   
                    }
                    Console.ReadLine();
                }
                FileInfo excelFile = new FileInfo(@"D:\csharp\Annuaire\Output\Annuaire.xlsx");
                excel.SaveAs(excelFile);

            }











        }








    }




}
