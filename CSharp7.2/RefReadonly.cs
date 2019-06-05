using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7._2
{
    public class RefReadonly : Demo<RefReadonly>
    {
        public override int Title => 35;

        public override void Run()
        {
            var p1 = new Point(1, 1);
            var p2 = new Point(4, 5);

            var distance = MeasureDistance(p1, p2);
            Console.WriteLine($"Distance between {p1} and {p2} is {distance}");
            var distFromOrigin = MeasureDistance(p1, Point.Origin);

            Point copyOfOrigin = Point.Origin;

            ref readonly var originRef = ref Point.Origin;
            // originRef.X++; // not allowed
            Console.WriteLine($"Distance between {p1} and {p2} is {distFromOrigin}");
        }

        double MeasureDistance(in Point p1, in Point p2)
        {
            p2.Reset();
            var dx = p1.X - p2.X;
            var dy = p1.Y - p2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public struct Point
        {
            public double X, Y;

            private static Point origin = new Point(2, 3);
            public static ref readonly Point Origin => ref origin;

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
