namespace IfElseFlowChart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If ja else. Sisesta 1, 2 või midagi muud:");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("You entered 1");
            }
            else if (input == "2")
            {
                Console.WriteLine("You entered 2");
            }
            else
            {
                Console.WriteLine("You entered something else");
            }
        }
    }
}
