using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string : ");
            string str = Console.ReadLine();

            bool isItPalindrome = IsItPalindrome(str);

            Console.WriteLine(isItPalindrome);
        }

        private static bool IsItPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
