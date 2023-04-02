using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Assingment
{
    class QuotientAndRemainderear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Number ");
            int firstnumber = int.Parse(Console.ReadLine());
            int secondnumber = int.Parse(Console.ReadLine());
            firstnumber = firstnumber + secondnumber;
            secondnumber = firstnumber - secondnumber;
            firstnumber = firstnumber - secondnumber;
            Console.WriteLine("After Swapping");
            Console.WriteLine(firstnumber);
            Console.WriteLine(secondnumber);
            Console.ReadLine();
        }
    }
}
