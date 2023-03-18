using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string : ");
            string str = Console.ReadLine();
            string newStr = string.Empty;

            foreach (char c in str)
            {
                newStr += string.Format($"\\u{(int)c:X4}");
            }

            Console.WriteLine(newStr);
        }
    }
}
