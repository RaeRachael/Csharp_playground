using System;

namespace playing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is " + DateTime.Now);
            Console.WriteLine(ADD(2,3));
        }

        public static int ADD(int x, int y)
        {
            return x + y;
        }
    }
}
