using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try

            {
                Console.Write("Enter a number: ");
                int x= Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: ");
                int y = Convert.ToInt32(Console.ReadLine());

                if (x < y)
                {
                    Console.WriteLine("X is small");

                }
                else if (x == y)
                {
                    Console.WriteLine("Both are same");

                }
                else
                {
                    Console.WriteLine("Y is big");

                }


            }
            catch (Exception ex1)
            {

                Console.WriteLine(ex1.ToString());

            }
            Console.ReadLine();

        }
    }
}
