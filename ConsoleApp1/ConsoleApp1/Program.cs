using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            getBiggerSumNumber(Convert.ToInt32(Console.ReadLine()));
            Console.ReadLine();
        }
        public static int getSum(int input)
        {
            int sum = input;
            int a;
            int count = 0;
            for (a = 1; a <= sum / 3; a++)
            {
                int b;
                for (b = a + 1; b <= sum / 2; b++)
                {
                    int c = sum - a - b;
                    if (a * a + b * b == c * c)
                    {
                        count++;
                        Console.WriteLine("a= " + a + ", b=" + b + ", c=" + c);
                    }
                }
            }
            return count;
        } //end method
        public static void getBiggerSumNumber(int range)
        {
            int biggestN = 0;
            int countS = 0;
            for (int i = 2; i <= range; i++)
            {
                if (getSum(i) > countS)
                {
                    biggestN = i;
                    countS = getSum(i);
                }
            }
            Console.WriteLine(biggestN);
            Console.WriteLine(countS);
        }
    }
}
