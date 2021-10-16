using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter a number");
            program.coupons();
        }

        public static void coupons()
        {
            HashSet<int> odd = new HashSet<int>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                int rand = new Random().Next(10000, 99999);
                odd.Add(rand);
            }
            foreach (int i in odd)
            {
                Console.WriteLine(i);
            }
        }


    }
}