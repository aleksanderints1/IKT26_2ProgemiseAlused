namespace IfAndElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha üks if ja else nestimine iseseisvalt");
            Console.WriteLine("Teise else if-i sisse panna if ja else");

            string number = Console.ReadLine();
            int nr = int.Parse(number);

            if (nr == 12)
            {

            }
            else if (nr > 20)
            {
                //nestimine e pesastamine
                if (nr == 25)
                {
                    Console.WriteLine("Number 25");
                }
                else
                {
                    Console.WriteLine("Kõik numbrid peale 25-test");
                }
            }
            else
            {
                Console.WriteLine("Kahtlane number");
            }
                
        }
    }
}
