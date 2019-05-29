using Infrastructure;
using System;
using System.Collections.Generic;
using static System.Console;

namespace CSharp7
{
    public class RefReturnAndLocals : Demo<RefReturnAndLocals>
    {
        public override float Title => 1.6f;

        public override void Run()
        {
            int[] numbers = { 1, 2, 3 };
            ref int refToSecond = ref numbers[1];
            var valueOfSecond = refToSecond;

            // cannot rebind
            // refToSecond = ref numbers[0];

            refToSecond = 123;
            WriteLine(string.Join(", ", numbers)); // 1, 123, 3

            Array.Resize(ref numbers, 1);
            WriteLine(string.Join(", ", numbers));
            WriteLine($"second = {refToSecond}, array size is {numbers.Length}");
            refToSecond = 321;
            WriteLine($"second = {refToSecond}, array size is {numbers.Length}");

            var numberList = new List<int> { 1, 2, 3 };
            // property or indexer cannot be out
            // ref int second = ref numberList[1];

            int[] moreNumbers = { 10, 20, 30 };
            Find(moreNumbers, 30) = 1000;
            WriteLine(string.Join(",", moreNumbers));

            // too many references:
            int a = 1, b = 2;
            ref var minRef = ref Min(ref a, ref b);

            // non-ref call just gets the value
            int minValue = Min(ref a, ref b);
            WriteLine($"min is {minValue}");
        }

        static ref int Find(int[] numbers, int value)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == value)
                {
                    return ref numbers[i];
                }
            }

            throw new ArgumentException("not found");
        }

        static ref int Min(ref int x, ref int y)
        {
            // below not work
            // return x < y ? (ref x) : (ref) y;
            // return ref (x < y ? x : y);
            if (x < y) return ref x;
            return ref y;
        }

        static ref int Max(ref int x, ref int y)
        {
            if (x < y) return ref y;
            return ref x;
        }
    }
}
