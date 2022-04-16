using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Linecomp3
    {
        public static void compareTo()
        {
            Console.WriteLine("enter x1,x2,y1,y2 values");
            double x1 = int.Parse(Console.ReadLine());
            double x2 = int.Parse(Console.ReadLine());
            double y1 = int.Parse(Console.ReadLine());
            double y2 = int.Parse(Console.ReadLine());
            double length1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            Console.WriteLine("enter x3,x4,y3,y4 values");
            double x3 = int.Parse(Console.ReadLine());
            double x4 = int.Parse(Console.ReadLine());
            double y3 = int.Parse(Console.ReadLine());
            double y4 = int.Parse(Console.ReadLine());
            double length2 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
            // Console.WriteLine("length is equals or not : " + length1.CompareTo(length2));
            int compare = length1.CompareTo(length2);
            if (length1 == length2)
            {
                Console.WriteLine("lth1 is equal to lth2");
            }
            else if (compare == 0)
            {
                Console.WriteLine("lth2 is greater then lth1");
            }
            else if (compare == 1)
            {
                Console.WriteLine("lth1 is greater then lth2");
            }
        }
    }
}
