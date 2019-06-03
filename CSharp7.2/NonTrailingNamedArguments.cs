using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp7._2
{
    public class NonTrailingNamedArguments : Demo<NonTrailingNamedArguments>
    {
        public override int Title => 33;

        public override void Run()
        {
            DoSomething(33, bar: 44);

            DoSomething(foo: 33, 44);

            DoSomething(bar: 33, foo: 44);
        }

        void DoSomething(int foo, int bar)
        {
            WriteLine($"{nameof(foo)}: {foo}, {nameof(bar)}: {bar}");
        }
    }
}
