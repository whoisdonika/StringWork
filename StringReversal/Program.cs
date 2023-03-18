using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string to reverse : ");
            string startingString = Console.ReadLine();

            char[] elements = startingString.ToCharArray();
            int reversedCh = 0;
            int chars = elements.Length - 1;

            while (reversedCh < chars)
            {
                char ch = elements[reversedCh];
                elements[reversedCh] = elements[chars];
                elements[chars] = ch;

                reversedCh++;
                chars--;

            }

            string newString = new string(elements);
            Console.WriteLine(newString);
        }
    }
}
