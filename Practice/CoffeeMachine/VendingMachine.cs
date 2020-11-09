using System;
using System.Reflection.Metadata;

namespace CoffeeMachine
{
    class VendingMachine
    {
        static void Main(string[] args)
        {
            const decimal coffeePrice = 5;
            const decimal cappuchinoPrice = 3;
            const decimal lattePrice = 3;

            Console.WriteLine($"\tHello!\n\rEnter\n1 for coffee - {coffeePrice:C}\n2 for capuchino - {cappuchinoPrice:C}\n3 for latte - {lattePrice:C}");
            Console.Write("please select a drink:");
            string input = Console.ReadLine();

            decimal billTotal = 0;
            while (input != "exit")
            {
                switch (input)
                {
                    case "1":
                        Console.WriteLine("You ordered coffee");
                        billTotal += coffeePrice;
                        break;
                    case "2":
                        Console.WriteLine("You ordered capuchino");
                        billTotal += cappuchinoPrice;
                        break;
                    case "3":
                        Console.WriteLine("You ordered latte");
                        billTotal += lattePrice;
                        break;
                    default:
                        Console.WriteLine("We do not have that in the menu");
                        break;
                }

                Console.WriteLine($"Your current total: {billTotal:C}");
                Console.WriteLine();
                Console.Write("please select a drink or exit:");
                input = Console.ReadLine();
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine($"TOTAL: {billTotal:C}");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("-------------------------");
        }
    }
}
