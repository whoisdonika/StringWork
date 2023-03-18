using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10doN_ichna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter base and number : ");
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int baseNum = nums[0];
            int num = nums[1];

            string result = "";
            while (num > 0)
            {
                int num2 = num % baseNum;
                result = num2.ToString() + result;
                num = num/ baseNum;
            }

            Console.WriteLine(result);
        }
    }
}
