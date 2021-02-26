using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
namespace Annuaire
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Utilisateur utilisateur = new Utilisateur();
            utilisateur = utilisateur.CreerUtilisateur();




            // Creation d'un tableau excel
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var excel = new ExcelPackage(new FileInfo(@"D:\csharp\Annuaire\Output\Annuaire.xlsx")))
            {
                // Load the worksheet
                //excel.Workbook.Worksheets.Add("Worksheet1");
                var excelWorksheet = excel.Workbook.Worksheets["Worksheet1"];


                int countRows = excelWorksheet.Dimension.End.Row;

                // Add Row 3
                //Add some items...

                excelWorksheet.Cells[countRows+1, 1].Value = utilisateur.Login;
                excelWorksheet.Cells[countRows+1, 2].Value = utilisateur.Nom;
                excelWorksheet.Cells[countRows+1, 3].Value = utilisateur.Prenom;
                excelWorksheet.Cells[countRows+1, 4].Value = utilisateur.Tel;
                excelWorksheet.Cells[countRows+1, 5].Value = utilisateur.Adresse.NumeroDeRue;
                excelWorksheet.Cells[countRows+1, 6].Value = utilisateur.Adresse.NomDeRue;
                excelWorksheet.Cells[countRows+1, 7].Value = utilisateur.Adresse.CodePostal;
                excelWorksheet.Cells[countRows+1, 8].Value = utilisateur.Adresse.Ville;
                excelWorksheet.Cells[countRows+1, 9].Value = utilisateur.Adresse.Pays;



                //List<string[]> headerRow = new List<string[]>()
                // {
                //    new string[] { "LOGIN", "NOM", "PRENOM", "TELEPHONE", "NUM_RUE" , "NOM_RUE", "CODE_POSTAL", "VILLE", "PAYS" }
                // };


                FileInfo excelFile = new FileInfo(@"D:\csharp\Annuaire\Output\Annuaire.xlsx");
                excel.SaveAs(excelFile);

                //// Determine the header range (e.g. A1:E1)

                //    string headerRange = "A1:" + Char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";
                //    // Popular header row data
                //    excelWorksheet.Cells[headerRange].LoadFromArrays(headerRow);

                //    List<string[]> cellData = new List<string[]>()
                //    {
                //       new string[] {utilisateur.Login, utilisateur.Nom, utilisateur.Prenom, utilisateur.Tel, utilisateur.Adresse.NumeroDeRue,
                //       utilisateur.Adresse.NomDeRue, utilisateur.Adresse.CodePostal, utilisateur.Adresse.Ville, utilisateur.Adresse.Pays}


                //};
                //excelWorksheet.Cells[2, 1].LoadFromArrays(cellData);

                // Find the last real row
                //nInLastRow = oSheet.Cells.Find("*", System.Reflection.Missing.Value,
                //System.Reflection.Missing.Value, System.Reflection.Missing.Value, Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;


                //FileInfo excelFile = new FileInfo(@"D:\csharp\Annuaire\Output\Annuaire.xlsx");
                //excel.SaveAs(excelFile);

                //bool isExcelInstalled = Type.GetTypeFromProgID("Excel.Application") != null ? true : false;
                //if (isExcelInstalled)
                //{
                //    System.Diagnostics.Process.Start(excelFile.ToString());
                //}






            }








        }




    }
}
