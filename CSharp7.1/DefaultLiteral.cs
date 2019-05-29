using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp7._1
{
    public class DefaultLiteral : Demo<DefaultLiteral>
    {
        public override int Title => 21;

        public override void Run()
        {
            int a = default;
            WriteLine($"{nameof(a)} = {a}");

            const int c = default;
            WriteLine($"const {nameof(c)} = {c}");

            // will not work here
            // const int? d = default; // oops

            // cannot leave defaults on their own
            var e = new[] { default, 33, default };
            WriteLine(string.Join(",", e));

            string s = default;
            WriteLine($"default of string is equals null ? {s == null}");

            // ternary operations
            var x = a > 0 ? default : 1.5;
            WriteLine($"type of {nameof(x)} is {x.GetType().Name}");

            WriteLine($"default value of DateTime = {GetTimestamps()}");
        }

        DateTime GetTimestamps(List<int> items = default)
        {
            return default;
        }
    }
}
