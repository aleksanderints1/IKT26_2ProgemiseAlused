namespace TriangleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tärnidest kolmnurk, täisnurkne kolmnurk");
            Console.WriteLine("---------------------------------------");
            //\n teeb tühja rea
            Console.WriteLine("\n\n");

            Console.WriteLine("Sisesta ridade arv: ");
            int i, j, rows;
            rows = Convert.ToInt32(Console.ReadLine());

            //kasutame kahte for loopi
            //for loop for loopi sees

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}