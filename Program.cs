using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Assingment
{
    class CheckEvenorOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("This is a even number");
            }
            else
            {
                Console.WriteLine("This is a odd number");
            }
            Console.ReadLine();
        }
    }
}
