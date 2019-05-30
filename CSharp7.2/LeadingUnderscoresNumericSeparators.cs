using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp7._2
{
    public class LeadingUnderscoresNumericSeparators : Demo<LeadingUnderscoresNumericSeparators>
    {
        public override int Title => 31;

        public override void Run()
        {
            // binary
            var x = 0b_1111_0000;

            // hex 
            var y = 0x_baad_f00d;

            WriteLine($"binary x = {x}");
            WriteLine($"hex y = {y}");
        }
    }
}
