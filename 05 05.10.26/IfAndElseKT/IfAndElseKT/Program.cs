namespace IfAndElseKT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sisesta oma auto hj");
            string sisend = Console.ReadLine();
            int hj;

            if (int.TryParse(sisend, out hj))
            {
                if (hj >= 30 && hj <= 33)
                {
                    Console.WriteLine($"Sinu auto mootori võimsus on {hj} hj");
                }
                else if (hj >= 0 && hj <= 100)
                {
                    Console.WriteLine($"Sinu auto mootori võimsus on {hj} hj");
                }
                else if (hj >= 101 && hj <= 150)
                {
                    Console.WriteLine($"Sinu auto mootori võimsus on {hj} hj");
                }
                else if (hj >= 151 && hj <= 250)
                {
                    Console.WriteLine($"Sinu auto mootori võimsus on {hj} hj");
                }
                else if (hj >= 250)
                {
                    Console.WriteLine($"Sinu auto mootori võimsus on {hj} hj");
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