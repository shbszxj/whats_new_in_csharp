using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp7
{
    public class Deconstruction : Demo<Deconstruction>
    {
        public override int Title => 4;

        public override void Run()
        {
            // deconstruction
            Point pt = new Point { X = 2, Y = 3 };
            var (i, j) = pt;
            WriteLine($"Got a point i = {i}, j = {j}");

            // can also discard values
            (int z, _) = pt;
            WriteLine($"z = {z}");
        }

        class Point
        {
            public int X, Y;

            // Deconstructions into a single element are not supported in C# 7.0.
            public void Deconstruct(out string s)
            {
                s = $"{X}-{Y}";
            }

            public void Deconstruct(out int x, out int y)
            {
                x = X;
                y = Y;
            }
        }
    }
}
