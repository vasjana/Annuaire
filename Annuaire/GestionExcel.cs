using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;


using System.IO;

using static System.Net.Mime.MediaTypeNames;

namespace Annuaire
{
  public  class GestionExcel
    {
        #region Attributs

        private string _Path { get; set; }
        private Utilisateur _Utilisateur { get; set; }

        #endregion


        #region Propriétés

        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                this._Path = value;
            }
        }

        public Utilisateur Utilisateur
        {
            get
            {
                return this._Utilisateur;
            }
            set
            {
                this._Utilisateur = value;
            }
        }

        #endregion


        #region Constructeur
        /// <summary>
        /// Constructeur sans arguments
        /// </summary>
        public GestionExcel()
        {
            this._Path = string.Empty;
            this._Utilisateur = new Utilisateur();    
        }

        /// <summary>
        /// Constructeur avec arguments
        /// </summary>
        /// <param name="path">Le chemin du fichier</param>
        /// <param name="utilisateur">Un utilisateur</param>
        public GestionExcel( string path, Utilisateur utilisateur)
        {
            this._Path = path;
            this._Utilisateur = utilisateur;
        }

        #endregion 

        #region Méthodes

        /// <summary>
        /// Créer un fichier excel et remplir les informations d'utilisateur
        /// </summary>
        public void CreerExcelFile()
        {

            // Creation d'un tableau excel
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var excel = new ExcelPackage(new FileInfo(this.Path)))
            {
                var excelWorksheet = excel.Workbook.Worksheets["Worksheet1"];

                // Load the worksheet
                if (excelWorksheet == null)
                {
                    excelWorksheet = excel.Workbook.Worksheets.Add("Worksheet1");


                    List<string[]> headerRow = new List<string[]>()
                 {
                    new string[] { "LOGIN", "NOM", "PRENOM", "TELEPHONE", "NUM_RUE" , "NOM_RUE", "CODE_POSTAL", "VILLE", "PAYS" }
                 };

                    // Determine the header range (e.g. A1:E1)

                    string headerRange = "A1:" + Char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";
                    // Popular header row data
                    excelWorksheet.Cells[headerRange].LoadFromArrays(headerRow);

                }

                int countRows = excelWorksheet.Dimension.End.Row;

                //// Add Row 3
                ////Add some items...

                excelWorksheet.Cells[countRows + 1, 1].Value = this.Utilisateur.Login;
                excelWorksheet.Cells[countRows + 1, 2].Value = this.Utilisateur.Nom;
                excelWorksheet.Cells[countRows + 1, 3].Value = this.Utilisateur.Prenom;
                excelWorksheet.Cells[countRows + 1, 4].Value = this.Utilisateur.Tel;
                excelWorksheet.Cells[countRows + 1, 5].Value = this.Utilisateur.Adresse.NumeroDeRue;
                excelWorksheet.Cells[countRows + 1, 6].Value = this.Utilisateur.Adresse.NomDeRue;
                excelWorksheet.Cells[countRows + 1, 7].Value = this.Utilisateur.Adresse.CodePostal;
                excelWorksheet.Cells[countRows + 1, 8].Value = this.Utilisateur.Adresse.Ville;
                excelWorksheet.Cells[countRows + 1, 9].Value = this.Utilisateur.Adresse.Pays;




                int colCount = excelWorksheet.Dimension.End.Column;  //get Column Count
                int rowCount = excelWorksheet.Dimension.End.Row;     //get row count

                Console.WriteLine(" Cet tableau a " + rowCount + " lignes.");

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

                FileInfo excelFile = new FileInfo(this.Path);
                excel.SaveAs(excelFile);
            }
        }


        #endregion

      
    }


} 

