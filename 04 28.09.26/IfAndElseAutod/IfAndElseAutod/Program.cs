namespace IfAndElseAutod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Kasudata if ja else
            //kirjuta automark
            //valikus on BMW, Audi, Porsche ja Škoda
            //Kui valitakse škoda, siis seal sees on uuesti küsimus, et
            //mis mudelit soovid valida. Mudeli valikus Kodiaq ja Ocavia
            Console.WriteLine("Autode valikus on: BMW, Audi, Porsche ja Škoda");

            string input = Console.ReadLine().ToLower();

            if (input == "bmw")
            {
                Console.WriteLine("Vali mudel (E38 või M2) ");
                string model3 = Console.ReadLine();

                if (model3 == "M2") Console.WriteLine("Valisid BMW M2");
                else if (model3 == "E38") Console.WriteLine("Valisid BMW E38");
            }
            else if (input == "audi")
            {
                Console.WriteLine("Vali mudel (A4 või A6)");
                string model2 = Console.ReadLine();

                if (model2 == "A4") Console.WriteLine("Valisid Audi A4");
                else if (model2 == "A6") Console.WriteLine("Valisid Audi A6");
            }
            else if (input == "porsche")
            {
                Console.WriteLine("Vali mudel (911 või Taycan)");
                string model1 = Console.ReadLine();

                if (model1 == "911") Console.WriteLine("Valisid Porsche 911");
                else if (model1 == "Taycan") Console.WriteLine("Valisid Porsche Taycan'i");
            }
            else if (input == "škoda")
            {
                Console.WriteLine("Vali mudel (Kodiaq või Octavia)");
                string model = Console.ReadLine();

                if (model == "kodiaq") Console.WriteLine("Valisid Škoda Kodiaq'i");
                else if (model == "octavia") Console.WriteLine("Valisid Škoda Octavia");
            }
            else
            {
                Console.WriteLine("Tundmatu auto! Sa ei sisestanud ühtegi lubatud autot (BMW, Audi, Porsche ja Škoda).");
            }
        }
    }
}
