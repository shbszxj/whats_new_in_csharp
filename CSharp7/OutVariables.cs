using Infrastructure;
using System;
using static System.Console;

namespace CSharp7
{
    public class OutVariables : Demo<OutVariables>
    {
        public override float Title => 1.1f;

        public override void Run()
        {
            DateTime dt;
            if (DateTime.TryParse("01/01/2019", out dt))
            {
                WriteLine($"Old-fashioned parse: {dt}");
            }

            if (DateTime.TryParse("02/02/2019", out var dt2))
            {
                WriteLine($"New parse: {dt2}");
            }

            int.TryParse("615", out var i);
            WriteLine($"i = {i}");

            int.TryParse("abc", out var j);
            WriteLine($"j = {j}");
        }
    }
}
