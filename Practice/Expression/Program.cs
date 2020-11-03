using System;

namespace Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print numbers from 100 to 1.
            for (int number = 100; number >= 1; number--)
            {
                Console.WriteLine(number);
            }

            //Print numbers from 1 to 100.
            int counter = 1;
            while (counter <= 100)
            {
                Console.WriteLine(counter);
                counter++;
            }
        }
    }
}
