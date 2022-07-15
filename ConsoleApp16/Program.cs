using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialValue = 5;
            int maximumValue = 96;
            int step = 7;

            for (int i = initialValue; i <= maximumValue; i += step)
            {
                Console.WriteLine(i);
            }
        }
    }
}
