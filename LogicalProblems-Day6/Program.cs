using System;

namespace Logical_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, r, sum = 0;
            Console.Write("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int t = num; t != 0; t = t / 10)
            {
                r = t % 10;
                sum = sum * 10 + r;
            }
            Console.Write("The number in reverse order is ", sum);
        }

    }
}