namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to binary!");

            Console.Write("Sisesta number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int originalNumber = number;
            string binary = "";

            while (number > 0)
            {
                int remainder = number % 2;
                binary = remainder + binary;
                number = number / 2;
            }

            Console.WriteLine($"{originalNumber} binaarsüsteemis on {binary}");
        }
    }
}