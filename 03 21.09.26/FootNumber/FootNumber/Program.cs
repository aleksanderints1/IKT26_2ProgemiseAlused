namespace FootNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teha jalanumbri suurusest üks if ja else harjutus
            //Esimene tingimus on jalanumbri 30 - 33 (siin on tekst roheline,
            //teine jalanumbri 34 - 38 (siin on tagataust valge),
            //kolmas jalanumbri 39 - 44 (siin on tekst sinine ja tagataust kollane)
            //neljas jalanumbri 45 - 48 (siin teeb arvuti häält beep)
            //Kindlasti tuleb ära lahendada olukord,
            //kus kasutatakse mõnda teist jalanumbrit

            Console.Write("Sisesta oma jalanumber: ");
            string sisend = Console.ReadLine();
            int jalanumber;

            if (int.TryParse(sisend, out jalanumber))
            {
                Console.ResetColor();

                if (jalanumber >= 30 && jalanumber <= 33)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Jalanumber {jalanumber}");
                }
                else if (jalanumber >= 34 && jalanumber <= 38)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"Jalanumber {jalanumber}");
                }
                else if (jalanumber >= 39 && jalanumber <= 44)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Jalanumber {jalanumber}");
                }
                else if (jalanumber >= 45 && jalanumber <= 48)
                {
                    Console.Beep();
                    Console.WriteLine($"Jalanumber {jalanumber}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seda jalanumbrit ei ole valikus.");
                }

                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Palun sisesta täisarv!");
            }
        }
    }
}