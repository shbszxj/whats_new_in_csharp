using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp7
{
    public class Tuples : Demo<Tuples>
    {
        public override float Title => 1.3f;

        static Tuple<double, double> SumAndProduct(double a, double b)
        {
            return Tuple.Create(a + b, a * b);
        }

        static (double sum, double product) NewSumAndProduct(double a, double b)
        {
            return (a + b, a * b);
        }

        public override void Run()
        {
            var sp = SumAndProduct(2, 5);
            WriteLine($"sum = {sp.Item1}, product = {sp.Item2}");

            var sp2 = NewSumAndProduct(2, 5);
            WriteLine($"new sum = {sp2.sum}, product = {sp2.product}");
            WriteLine(sp2.GetType());

            // NOTE! var works but double doesn't
            var (sum, product) = NewSumAndProduct(2, 5);
            //double (sum, product) = NewSumAndProduct(2, 5);
            WriteLine($"sum = {sum}, product = {product}");
            WriteLine($"type of {nameof(sum)} is {sum.GetType()}");
            WriteLine($"type of {nameof(product)} is {product.GetType()}");

            // tuple declarations with names
            var me = (Name: "Jack", Age: 30);
            WriteLine(me);
            WriteLine($"type of {nameof(me)} is {me.GetType()}");

            // names are not part of the type:
            WriteLine($"Fields: " + string.Join(",", me.GetType().GetFields().Select(pr => pr.Name)));
            WriteLine($"Properties: " + string.Join(",", me.GetType().GetProperties().Select(pr => pr.Name)));

            WriteLine($"My name is {me.Name} and I am {me.Age} years old");

            var snp = new Func<double, double, (double sum, double product)>((a, b) => (sum: a + b, product: a * b));
            var result = snp(1, 2);

            // there's no result.sum unless you add it to signature
            // var snp = new Func<double, double, (double, double)>((a, b) => (sum: a + b, product: a * b));
            WriteLine($"sum = {result.sum}, product = {result.product}");

            // deconstruction
            Point pt = new Point { X = 2, Y = 3 };
            var (i, j) = pt;
            WriteLine($"Got a point i = {i}, j = {j}");

            // can also discard values
            (int z, _) = pt;
            WriteLine($"z = {z}");
        }
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
