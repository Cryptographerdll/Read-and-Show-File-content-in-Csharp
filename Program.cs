using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq;

namespace ReadFile_Fichiers_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // How to Read Files . C#
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Folder has Allready exist .
            string fichier = path + Path.DirectorySeparatorChar + "Fichier" + Path.DirectorySeparatorChar + "khalil.txt";

            if (!File.Exists(fichier))
            {
                string txt = "Welcome to khalil world " + Environment.NewLine;
                File.WriteAllText(fichier, txt);
            }
            else
            {
                string txt = "New Line" + Environment.NewLine;
                File.AppendAllText(fichier, txt);
            }

          //  string Content = File.ReadAllText(fichier);
           // Console.WriteLine(Content);

            // Sous Forme d'un Tableau
            string[] Content = File.ReadAllLines(fichier);

           // Console.WriteLine(Content.Length);

            foreach (string s in Content)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
