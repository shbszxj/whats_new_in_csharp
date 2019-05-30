using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp7._1
{
    public class InferTupleNames : Demo<InferTupleNames>
    {
        public override int Title => 22;

        public override void Run()
        {
            var me = (Name: "Jack", Age: 30);
            WriteLine(me);

            var alsoMe = (me.Age, me.Name);
            WriteLine($"name = {alsoMe.Name}, age = {alsoMe.Age}");

            var result = new[] { "March", "April", "May" }.Select(m => (m.Length, FirstChar: m[0])).Where(t => t.Length == 5);
            WriteLine(string.Join(", ", result));

            var now = DateTime.Now;
            var u = (now.Hour, now.Minute);
            var v = ((u.Hour, u.Minute) = (11, 12));
            WriteLine(v);
        }
    }
}
