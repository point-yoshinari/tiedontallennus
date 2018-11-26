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
            int lämpötila = 0; //koska konsolisovellus pyydetään käyttäjää kirjoittamaan haluttu lämpötila
            Console.Write("Anna uusi lämpötila: "); //staattisia metodeja
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte); //muuttuja

            //tiedostoon kirjoittaminen
            string tiedosto = @"C:\Temp\Lämpötila.txt";
            //tiedostopolut HUOM laita @ niin tarkoittaa että escape merkit eivät käytössä, ja VS tunnistaa ne tiedostopoluksi
            //Tallentaa muuttujan tiedostoon, File. jälkeen paina lamppua ja ota System.IO käyttöön
            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu.");

            Console.ReadLine();
        }
    }
}
