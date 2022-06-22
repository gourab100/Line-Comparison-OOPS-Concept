using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonOOPS
{
    public class Line
    {
        public double lengthofline()
        {
           int x1=Convert.ToInt16(Console.ReadLine());
           int y1=Convert.ToInt16(Console.ReadLine());
           int x2=Convert.ToInt16(Console.ReadLine());
           int y2 =Convert.ToInt16(Console.ReadLine());

            double lengthofline = (double)Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            return (double)lengthofline;
        }


        

    }
}
