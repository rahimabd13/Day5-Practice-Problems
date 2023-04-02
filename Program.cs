using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Assingment
{
    class LeapYear
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the year");
            int year = int.Parse(Console.ReadLine());

            if ((year % 400) == 0)
            {
                Console.WriteLine("Is a leap year" + " " + year);
            }
           
            else if ((year % 4) == 0)
            {
                Console.WriteLine(" Is a leap year" + " " + year);
            }
            else
            {
                Console.WriteLine(" Is not a leap year" + " " + year);
            }
            Console.ReadLine();
        }
    }
}
