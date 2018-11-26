using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedonTallennus
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = @"C:\Temp\Lämpötila.txt";

            //luetaan tiedostosta aiemmin asetettu lämpötila
            //sovelluksen pitää pystyä hallitsemaan myös se ettei tiedostoa ole olemassa
            if (File.Exists(tiedosto))
            {
                string aiempiArvo = File.ReadAllText(tiedosto);
                Console.WriteLine("Aiemmin asetettu lämpötila on: " + aiempiArvo + " astetta.");

            }
            else
            {
                Console.WriteLine("Tervetuloa!"); //WriteLine tekee myös rivinvaihdon
            }


            int lämpötila = 0; //koska konsolisovellus pyydetään käyttäjää kirjoittamaan haluttu lämpötila
            Console.Write("Anna uusi lämpötila: "); //staattisia metodeja, Write pyytää 
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte); //muuttuja

            //tiedostoon kirjoittaminen
            //tiedostopolut HUOM laita @ niin tarkoittaa että escape merkit eivät käytössä, ja VS tunnistaa ne tiedostopoluksi
            //Tallentaa muuttujan tiedostoon, File. jälkeen paina lamppua ja ota System.IO käyttöön
            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu. ");

            Console.ReadLine();
        }
    }
}
