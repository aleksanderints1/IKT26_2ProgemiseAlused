namespace WhileNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //tuleb kasutada while ja omakorda while sisse panna while
            //while nesting
            //while kordab ennast 5 korda
            //vooskeem teha

            Console.WriteLine("While nesting");

            int a = 1;

            while (a <= 5)
            {

                int b = 1;
                while (b <= 5)

                {
                    Console.Write(b + " ");
                    b++;
                }
                Console.WriteLine();
                a++;
            }
        }
    }
}
