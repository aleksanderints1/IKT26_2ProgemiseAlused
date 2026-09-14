namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta enda vanus");

            //peate kasutama if and else lauseid,
            //et kontrollida, kas kasutaja vanus
            //on suurem kui 18 või väiksem kui 18

            //saab kasutada converti ja parse-t
            //int userAge = Convert.ToInt32(Console.ReadLine()));
            string userInput = Console.ReadLine();
            int userAge = int.Parse(userInput);

            if (userAge >= 18)
            {
                Console.WriteLine("Sa oled täisealine");
            }
            else
            {
                Console.WriteLine("Sa oled alaealine");
            }

        }
    }
}