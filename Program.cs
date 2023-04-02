using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Assingment
{
    class CheckvowelorConstrant
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Three Numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine("A is a Largest Number");
            }
            else if (num2 > num3)
            {
                Console.WriteLine("B is a Largest Number");
            }
            else
            {
                Console.WriteLine("C is a Largest Number");
            }
            Console.ReadLine();
        }
    }
}
