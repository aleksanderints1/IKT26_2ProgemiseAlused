using System.Xml.Linq;

namespace IfAndElseColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Teha if ja else konsoolirakendus, kus" +
                "kontrollitakse stringi abil värvi vastavust");

            Console.WriteLine("Värvide valikus on: red, blue, green ja white");
            Console.WriteLine("Peab käsitlema juhust, kus vastaja ei sisesta" +
                "eelpool sisestatud värvi");

            Console.WriteLine("Sisesta värv (valikus on: red, blue, green, white):");

            // Loeme sisendi ja teeme selle väiketähtedeks, et vigu vältida
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Valisid punase värvi (red).");
            }
            else if (input == "blue")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Valisid sinise värvi (blue).");
            }
            else if (input == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Valisid rohelise värvi (roheline).");
            }
            else if (input == "white")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Valisid valge värvi (white).");
            }
            else
            {
                Console.WriteLine("Tundmatu värv! Sa ei sisestanud ühtegi lubatud värvi (red, blue, green, white).");
            }
        }
    }
}
