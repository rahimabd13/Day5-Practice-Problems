using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Assingment
{
    class FlippingCoinPercentage
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of times flipping coin :");
            int n = int.Parse(Console.ReadLine());  //n = no.of times

            int head = 0, tail = 0;
            double headpercentage, tailpercentage;
           

            for (int i = 0; i < n; i++)
            {
                Random random = new Random();
                int flip = random.Next(0, 2); //Range (0-1)

                if (flip == 1)
                {
                    Console.WriteLine("Head");
                   
                    head ++;

                }
                else 
                {
                    Console.WriteLine("Tail");
                   
                    tail ++;
                }

            }
            headpercentage = (head * 100) / n;
            tailpercentage = (tail * 100) / n;
            Console.WriteLine("percentage of head " + headpercentage + "%");
            Console.WriteLine("percentage of tail " + tailpercentage + "%");
            Console.ReadLine();
        }
    }
}
