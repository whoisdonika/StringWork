using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two strings : ");
            string[] str = Console.ReadLine().Split(' ');

            string str1 = str[0];
            string str2 = str[1];

            bool replace = AreReplaceable(str1, str2);

            Console.WriteLine(replace);
        }

        private static bool AreReplaceable(string str1, string str2)
        {
            if (str1.Length != str2.Length && str2.Length > str1.Distinct().Count())
            {
                return false;
            }

            for (int i = 0; i < str1.Length; i++)
            {
                char ch1 = str1[i];
                char ch2 = str2[i];

                if (ch1 != ch2)
                {
                    if (str1.IndexOf(ch1) != str2.IndexOf(ch2))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
