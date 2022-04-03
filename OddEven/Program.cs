using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int x= Convert.ToInt32(Console.ReadLine());

            if (x%2==0)
            {
                Console.WriteLine("This is an even number");
            }
            else
            {
                Console.WriteLine("This is an odd number");

            }
            Console.ReadLine();
        }
    }
}
