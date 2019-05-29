using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp7.ThrowExpression
{
    public class ThrowExpression : Demo<ThrowExpression>
    {
        public override float Title => 1.8f;

        public override void Run()
        {
            int v = -1;
            try
            {
                var te = new Expression("");
                v = te.GetValue(-1); // does not get defaulted!
            }
            catch (Exception e)
            {
                WriteLine(e);
            }
            finally
            {
                WriteLine(v);
            }
        }
    }

    public class Expression
    {
        public string Name { get; set; }

        public Expression(string name)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(Name));
        }

        public int GetValue(int n)
        {
            return n > 0 ? n + 1 : throw new Exception();
        }
    }
}
