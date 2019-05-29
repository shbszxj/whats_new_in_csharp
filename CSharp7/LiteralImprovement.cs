using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp7
{
    public class LiteralImprovement : Demo<LiteralImprovement>
    {
        public override int Title => 10;

        public override void Run()
        {
            int a = 123_321;
            int b = 123_321______123;
            // also works for hex
            long h = 0xAB_BC_D123EF;

            // also binay
            var bin = 0b1110_0010_0011;

            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
            WriteLine($"h = {h}");
            WriteLine($"bin = {bin}");
        }
    }
}
