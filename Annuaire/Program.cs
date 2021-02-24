using System;
using System.Collections.Generic;
using System.IO;
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


                       
            string UserName = System.Environment.UserName;
            DirectoryInfo di = Directory.CreateDirectory(@"D:\csharp\Annuaire\Output");
            string fileName = @"D:\csharp\Annuaire\Output\Annuaire.txt";
            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
                try
                {
                    ostrm = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                    writer = new StreamWriter(ostrm);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Cannot open Redirect.txt for writing");
                    Console.WriteLine(e.Message);
                    return;
                }
              Console.SetOut(writer);                      
              utilisateur.AfficherInformationUtilisateur();
              Console.SetOut(oldOut);
              writer.Close();
              ostrm.Close();
              var files = File.ReadAllLines(fileName);
              files.ToList().ForEach(s => Console.WriteLine(s));
              Console.WriteLine("Done");
            

















        }




    }
}
