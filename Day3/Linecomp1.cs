using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Linecomp1
    {
        public static void LenthTwoPoints()
        {
            Console.WriteLine("enter x1 , x2 , y1 , y3 values ");
            double x1 = int.Parse(Console.ReadLine());
            double x2 = int.Parse(Console.ReadLine());
            double y1 = int.Parse(Console.ReadLine());
            double y2 = int.Parse(Console.ReadLine());

            double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("length of line is : " + length);
        }
    }
}
