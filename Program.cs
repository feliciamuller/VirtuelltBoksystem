namespace VirtuelltBoksystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Media> media = new List<Media>() 
            { 
                new Bok ("Bibeln", "Jesus", "666"),
                new E_bok ("Du kan allt!", "Sten Hård", "999", 1000, "https://stenhard.se/Du-kan_allt!")
            };

            foreach (var i in media)
            {
                i.VisaInfo();
                Console.WriteLine();
            }
        }
    }
}