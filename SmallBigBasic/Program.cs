using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBigBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 12, y = 12;

            if (x > y)
            {
                Console.WriteLine("X is big");
            }
            else if (y == x)
            {

                Console.WriteLine("Both are same");

            }
            else
            {

                Console.WriteLine("Y is big");

            }
            Console.ReadLine();

        }

    }
}
