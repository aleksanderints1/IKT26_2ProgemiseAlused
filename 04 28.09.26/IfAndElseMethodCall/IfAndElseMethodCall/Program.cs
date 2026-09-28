namespace IfAndElseMethodCall
{
    internal class Program
    {
        // See on meetod Main
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Küsime kasutajalt sisendit
            Console.WriteLine("Kui soovid meetodit välja kutsuda, siis kirjuta 'ja':");
            string input = Console.ReadLine();

            // Kasutame if ja else tingimuslauset
            if (input != null && input.Trim().ToLower() == "ja")
            {
                HelloMethod(null); // Kutsume meetodi välja
            }
            else
            {
                Console.WriteLine("Meetodit ei kutsutud välja. Head aega!");
            }
        }

        // Uus meetod HelloMethod
        static void HelloMethod(string[] args)
        {
            Console.WriteLine("Hello Kitty");
        }
    }
}
