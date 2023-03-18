using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplySymbolCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] strings = Console.ReadLine().Split().ToArray(); 

            string string1 = strings[0];
            string string2 = strings[1];

            int result = MultiplyS1AndS2(string1, string2);
            Console.WriteLine(result);
        }

        private static int MultiplyS1AndS2(string string1, string string2)
        {
            int result = 0;

            for (int i = 0; i < Math.Max(string1.Length, string2.Length); i++)
            {
                int code = i < string1.Length ? (int)string1[i] : 1;
                int code2 = i < string2.Length ? (int)string2[i] : 1;

                result += + code * code2;
            }

            return result;
        }
    }
}
