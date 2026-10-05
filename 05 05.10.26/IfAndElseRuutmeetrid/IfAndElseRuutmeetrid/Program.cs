namespace IfAndElseRuutmeetrid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sisesta oma maja ruutude arv");
            string sisend = Console.ReadLine();
            int ruut;

            if (int.TryParse(sisend, out ruut))
            {
                if (ruut >= 0 && ruut <= 40)
                {
                    Console.WriteLine($"Sinu maja suurus on {ruut} ruutmeetrit");
                }
                else if (ruut >= 41 && ruut <= 90)
                {
                    Console.WriteLine($"Sinu maja suurus on {ruut} ruutmeetrit");
                }
                else if (ruut >= 91 && ruut <= 130)
                {
                    Console.WriteLine($"Sinu maja suurus on {ruut} ruutmeetrit");
                }
                else if (ruut >= 131)
                {
                    Console.WriteLine($"Sinu maja suurus on {ruut} ruutmeetrit");
                }
                else
                {
                    Console.WriteLine("Seda varianti ei ole valikus.");
                }
            }
            else
            {
                Console.WriteLine("Palun sisesta täisarv!");
            }
        }
    }
}