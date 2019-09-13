using System;
using System.Collections.Generic;
using System.Linq;

namespace Playground
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public static class MultipleOfThreeOrFive
    {
        public static void GetMultiplesOfThreeOrFive()
        {
            GetMultiplesOfThree();

            GetMultiplesOfFive();
        }

        private static void GetMultiplesOfThree()
        {
            var results = new List<int>(); 

            for (var i = 0; i <= 1000; i++)
            {
                if (IsDivisibleBy(i, 3))
                {
                    results.Add(i);
                }
            }

            Console.WriteLine($" Sum of multiples of three : {results.Sum(x => x)}");
        }

        private static void GetMultiplesOfFive()
        {
            var results = new List<int>();

            for (var i = 0; i <= 1000; i++)
            {
                if (IsDivisibleBy(i, 5))
                {
                    results.Add(i);
                }
            }

            Console.WriteLine($" Sum of multiples of five : {results.Sum(x => x)}");
        }

        private static bool IsDivisibleBy(int value1, int value2)
        {
            return (value1 % value2) == 0;
        }
    }
}

