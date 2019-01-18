using System;
using System.Collections.Generic;
using System.Linq;

namespace TrueCodersCG2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Integers from 1 to 10
            Console.WriteLine("TOTAL: " + WriteNumbers(1, 10, "Integers from 1 to 10", ConsoleColor.Magenta).Sum());
            Console.WriteLine();
            //Integers from -10 to + 10
            Console.WriteLine("TOTAL: " + WriteNumbers(-10, 21, "Integers from -10 to +10", ConsoleColor.Yellow).Sum());
            Console.WriteLine();
            //Even integers from 1 to 50
            Console.WriteLine("TOTAL: " + WriteNumbers(1, 50, "Even Integers from 1 to 50", ConsoleColor.Green, 2).Sum());
            Console.WriteLine();
            //Multiples of 3 from 1 to 50
            Console.WriteLine("TOTAL: " + WriteNumbers(1, 50, "Multiples of 3 from 1 to 50", ConsoleColor.Red, 3).Sum());
            Console.WriteLine();
            //Multiples of 3 from 1 to 51
            Console.WriteLine("TOTAL: " + WriteNumbers(1, 51, "Multiples of 6 from 1 to 51", ConsoleColor.DarkYellow, 6).Sum());
            Console.WriteLine();

            Console.ResetColor();

            Console.ReadLine();
            //CreateWebHostBuilder(args).Build().Run();


        }
        public static IEnumerable<int> WriteNumbers(int start, int end, string message, ConsoleColor color = ConsoleColor.White, int modulus = 1)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            foreach (var item in (Enumerable.Range(start, end)))
            {
                if (item % modulus == 0)
                {
                    Console.WriteLine(item);
                }
            }

            return (Enumerable.Range(start, end).Where((number) => (number % modulus == 0)));
            //numbers.Where((number, index) => number <= index * 10);
        }
    }
}
