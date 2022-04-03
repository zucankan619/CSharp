using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number");
            int x= Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number");
            int y = Convert.ToInt32(Console.ReadLine());

            string s1 = String.Format("The summation is {0} + {1} = {2}", x, y, x + y);
            Console.WriteLine(s1);
            Console.WriteLine("The subtraction is {0} - {1} = {2}", x, y, x - y);
            Console.WriteLine("The multiplication is {0} * {1} = {2}", x, y, x * y);
            Console.WriteLine("The divison is {0} / {1} = {2}", x, y, x / y);
            Console.ReadLine();
        } 
       
    }
}
