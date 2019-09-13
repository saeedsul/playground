using System;

namespace Playground
{
    /// <summary>
    /// n! means n × (n − 1) × ... × 3 × 2 × 1
    ///For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
    ///and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
    ///Find the sum of the digits in the number 100!
    /// </summary>
    public static class FactorialDigitSum
    {
        public static void GetFactorialOfOneHundred()
        { 
            double totalValue = 1;
            double totalSum = 0;

            for (var i = 1; i <= 100; i++)
            {
                totalValue *= i; 
            }

            while (totalValue != 0)
            {
                totalSum += totalValue % 10;
                totalValue /= 10;
            }

            Console.WriteLine($" The sum of the digits in the number 100 : {Convert.ToInt32(totalSum)}");
        }
    }
}
