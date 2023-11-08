using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuelltBoksystem
{
    public class Bok
    {
        // Egenskaper
        public string Titel { get; set; }
        public string Författare { get; set; }
        public string ISBN { get; set; }

        // Konstruktor för att skapa en ny bokinstans
        public Bok(string titel, string författare, string isbn)
        {
            Titel = titel;
            Författare = författare;
            ISBN = isbn;
        }

        // Metod för att skriva ut bokens detaljer
        public virtual void SkrivUtInfo()
        {
            Console.WriteLine("Bokdetaljer:");
            Console.WriteLine("Titel: " + Titel);
            Console.WriteLine("Författare: " + Författare);
            Console.WriteLine("ISBN: " + ISBN);
        }
    }
}
