using System;
using System.Security.AccessControl;
using System.Xml.Schema;

namespace src.RightAngleTriangle
{
    public class Triangle
    {
        public Point Pointa { get; set; }
        public Point Pointb { get; set; }
        public Point Pointc { get; set; }
        public Triangle(Point pointa, Point pointb, Point pointc)
        {
            Pointa = pointa;
            Pointb = pointb;
            Pointc = pointc;
        }

        public Boolean IsRightAngled()
        {
            var d1 = DistnaceBetweenpoints(Pointa, Pointb);
            var d2 = DistnaceBetweenpoints(Pointa, Pointc);
            var d3 = DistnaceBetweenpoints(Pointb, Pointc);
            var hyp =Math.Max(Math.Max(d1, d2),d3);
            if (hyp != d1 && hyp != d2)
            {
                if (Math.Pow(hyp, 2) == Math.Pow(d1, 2) + Math.Pow(d2, 2))
                {
                    return true;
                }
            }
            else if (hyp != d2 && hyp != d3)
            {
                if (Math.Pow(hyp, 2) == Math.Pow(d2, 2) + Math.Pow(d3, 2))
                {
                    return true;
                }
            }
            else if (hyp != d1 && hyp != d2)
            {
                if (Math.Pow(hyp, 2) == Math.Pow(d1, 2) + Math.Pow(d2, 2))
                {
                    return true;
                }
            }
            return false;
            
        }

        public double DistnaceBetweenpoints(Point a, Point b)
        {
           return Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));
        }
    }
}
