using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_1111
{
    class Program
    {
        static void Main(string[] args)
        {
        int x,y, z;

            Console.Write("\nInput the First Number :");
            x = int.Parse(Console.ReadLine());
            Console.Write("\nInput the second number :");
            y = int.Parse(Console.ReadLine());
            z = x;
            x = y;
            y = z;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " +  x);
            Console.Write("\nSecond Number : " +y);
            Console.Read();



        }
    }
}
