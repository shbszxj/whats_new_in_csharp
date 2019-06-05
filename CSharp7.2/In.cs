using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7._2
{
    public class In : Demo<In>
    {
        public override int Title => 34;

        public override void Run()
        {
            var p1 = new Point(1, 1);
            var p2 = new Point(4, 5);

            var distance = MeasureDistance(p1, p2);
            Console.WriteLine($"Distance between {p1} and {p2} is {distance}");
        }

        double MeasureDistance(in Point p1, in Point p2)
        {
            //  ### cannot assign to in parameter ###
            //  ### p1 = new Point(1, 2);         ###
            //  ## ### ### ### ### ### ### ### ### ##

            // cannot use variable 'in In.Point' as a ref or out value because it is a readonly variable
            // ChangeMe(ref p1);

            p2.Reset(); // instance operations happen on a copy!

            var dx = p1.X - p2.X;
            var dy = p1.Y - p2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        void ChangeMe(ref Point p)
        {
            p.X++;
        }

        public struct Point
        {
            public double X, Y;

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public void Reset()
            {
                X = Y = 0;
            }

            public override string ToString()
            {
                return $"({X},{Y})";
            }
        }
    }
}
