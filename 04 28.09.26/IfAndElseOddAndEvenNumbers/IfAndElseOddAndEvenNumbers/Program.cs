namespace IfAndElseOddAndEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number:");

            string sisend = Console.ReadLine();
            int number = int.Parse(sisend);

            if (number % 2 == 0)
            {
                EvenNumber();
            }
            else
            {
                OddNumber();
            }
        }

        static void EvenNumber()
        {
            Console.WriteLine("Number on paaris.");
        }
        static void OddNumber()
        {
            Console.WriteLine("Number on paaritu.");
        }
    }
}