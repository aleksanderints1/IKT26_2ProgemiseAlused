namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Meil on münt, mille diameeter on 25.75 mm
            //Arvutada välja maa ümbermõõt ja mitu münti
            //Mahub järjestikku ümber Maa
            //Arvutudes tohib kasutada ainult mündi diameetrit ja Maa Raadiust 6371 km

            double coinDiameter = 0.02575; //m
            double earthRadius = 6371000; //m

            double aroundEarth = 2 * Math.PI * earthRadius; //m
            Console.WriteLine("Maa ümebrmõõt on " + aroundEarth);

            double howManyCoins = aroundEarth / coinDiameter;
            Console.WriteLine("Kahe euroseid läheb ümber maa {0:0}", howManyCoins);
        }
    }
}
