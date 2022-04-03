using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x <= 100)
            {
                if (x%2!=0)
                {
                    Console.WriteLine("{0}\t", x);  
                }
                x++;  

            }
            Console.ReadLine();
        }
    }
}
