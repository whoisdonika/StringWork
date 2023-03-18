using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ndo10_ichna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter base and number to convert : ");
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int baseNum = nums[0];
            string stringNum = nums[1].ToString();

            int num = 0;
            for (int i = 0; i < stringNum.Length; i++)
            {
                int digit = stringNum[i] - '0';
                num = num * baseNum + digit;
            }

            Console.WriteLine(num);
        }
    }
}
