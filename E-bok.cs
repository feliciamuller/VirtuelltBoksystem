using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuelltBoksystem
{
    internal class E_bok : Bok
    {
        protected int Filstorlek { get; set; }
        protected string DownloadURL { get; set; }

        public E_bok(string titel, string författare, string isbn, int filstorlek, string downloadURL) : base(titel, författare, isbn)
        {
            Filstorlek = filstorlek;
            DownloadURL = downloadURL;
        }

        public override void SkrivUtInfo() 
        {
            base.SkrivUtInfo();
            Console.WriteLine($"Filstorlek: {Filstorlek} - URL: {DownloadURL}");
        } 
    }
}
