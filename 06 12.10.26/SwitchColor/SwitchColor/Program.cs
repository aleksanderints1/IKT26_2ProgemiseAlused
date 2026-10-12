namespace SwitchColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta värv (Valikus on Red, Green, Blue, White, Orange");
            //kasutada switchi
            //Sisestab värvi nime
            //Red, Green, Blue, White, Orange
            //iga värvi puhul näitab vastava värviga konsooli + tekst
            //kui sisestatakse muu värv, siis näitab "Värv puudub"

            string värv = Console.ReadLine();

            switch (värv)
            {
                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sinu värv on Red");
                    break;
                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Sinu värv on Green");
                    break;
                case "Blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Sinu värv on Blue");
                    break;
                case "White":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Sinu värv on White");
                    break;
                case "Orange":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Sinu värv on Orange");
                    break;
                default:
                    Console.WriteLine("Värv puudub valikust");
                    break;
            }
        }
    }
}