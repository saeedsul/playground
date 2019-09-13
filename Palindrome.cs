using System;
using System.Collections.Generic;
using System.Linq;

namespace Playground
{
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public static class Palindrome
    {
        public static void FindPalindromeOfThreeDigits()
        {
            var items = new List<int>();
            for (var i = 999; i > 100; i--)
            {
                for (var j = 999; j > 100; j--)
                {
                    var value = j * i;
                    if (IsPalindrome(value.ToString()))
                    {
                        items.Add(j * i);
                    }
                }
            }
            Console.WriteLine($" Highest Palindrome Of 3 digits is : { (items.Count > 0 ? items.Max() : 0)}");
        }

        private static bool IsPalindrome(string input)
        {
            var arr = input.ToCharArray();

            Array.Reverse(arr);

            var reverseString = new string(arr);

            return string.Equals(input, reverseString, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
