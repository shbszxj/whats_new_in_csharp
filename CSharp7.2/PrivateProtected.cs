using Infrastructure;

namespace CSharp7._2
{
    public class PrivateProtected : Demo<PrivateProtected>
    {
        public override int Title => 32;

        public override void Run()
        {
            Base pp = new Base();
            var d = new Derived();
            d.b = 3;
            // d.c is a no-go
        }

        class Base
        {
            private int a;
            // derived classes or classes in same assembly
            protected internal int b;
            // containing class or derived classes in same assembly only
            private protected int c;
        }

        class Derived : Base
        {
            public Derived()
            {
                c = 333;
                b = 3;
            }
        }
    }
}
