using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Spreadsheet;
using OfficeOpenXml;


namespace Annuaire
{
    class Program
    {


        static void Main(string[] args)
        {
            Utilisateur utilisateur = new Utilisateur();
            utilisateur = utilisateur.CreerUtilisateur();

           

            // Creation d'un file .txt
            //string UserName = System.Environment.UserName;
            //DirectoryInfo di = Directory.CreateDirectory(@"D:\csharp\Annuaire\Output");
            //string fileName = @"D:\csharp\Annuaire\Output\Annuaire.txt";
            //FileStream ostrm;
            //StreamWriter writer;
            //TextWriter oldOut = Console.Out;
            //    try
            //    {
            //        ostrm = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            //        writer = new StreamWriter(ostrm);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("Cannot open Redirect.txt for writing");
            //        Console.WriteLine(e.Message);
            //        return;
            //    }
            //  Console.SetOut(writer);                      
            //  utilisateur.AfficherInformationUtilisateur();
            //  Console.SetOut(oldOut);
            //  writer.Close();
            //  ostrm.Close();
            //  var files = File.ReadAllLines(fileName);
            //  files.ToList().ForEach(s => Console.WriteLine(s));
            //  Console.WriteLine("Done");




            // Creation d'un tableau excel
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var excel = new ExcelPackage(new FileInfo(@"D:\csharp\Annuaire\Output\Annuaire.xlsx")))
            {

                excel.Workbook.Worksheets.Add("Worksheet1");
                var excelWorksheet = excel.Workbook.Worksheets["Worksheet1"];

                List<string[]> headerRow = new List<string[]>()
                 {
                    new string[] { "LOGIN", "NOM", "PRENOM", "TELEPHONE", "NUM_RUE" , "NOM_RUE", "CODE_POSTAL", "VILLE", "PAYS" }
                 };

                // Determine the header range (e.g. A1:E1)

                string headerRange = "A1:" + Char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";
                // Popular header row data
                excelWorksheet.Cells[headerRange].LoadFromArrays(headerRow);

                List<string[]> cellData = new List<string[]>()
                {
                   new string[] {utilisateur.Login, utilisateur.Nom, utilisateur.Prenom, utilisateur.Tel, utilisateur.Adresse.NumeroDeRue,
                   utilisateur.Adresse.NomDeRue, utilisateur.Adresse.CodePostal, utilisateur.Adresse.Ville, utilisateur.Adresse.Pays}
                   

                 };
                excelWorksheet.Cells[2, 1].LoadFromArrays(cellData);


                FileInfo excelFile = new FileInfo(@"D:\csharp\Annuaire\Output\Annuaire.xlsx");
                excel.SaveAs(excelFile);

                bool isExcelInstalled = Type.GetTypeFromProgID("Excel.Application") != null ? true : false;
                if (isExcelInstalled)
                {
                    System.Diagnostics.Process.Start(excelFile.ToString());
                }






            }

    }




    }
}
