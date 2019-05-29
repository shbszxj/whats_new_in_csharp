using Infrastructure;
using static System.Console;

namespace CSharp7
{
    public class PatternMatching : Demo<PatternMatching>
    {
        public override int Title => 2;

        public override void Run()
        {
            Shape shape = new Rectangle();
            if (shape is Rectangle rc)
            {
                WriteLine(rc);
            }

            if (!(shape is Circle cc))
            {
                // Use of unassigned local variable 'cc'
                //WriteLine(cc);
            }

            switch (shape)
            {
                case Circle c:
                    WriteLine(c);
                    break;
                case Rectangle sq when sq.Width == sq.Height:
                    WriteLine(sq);
                    break;
                case Rectangle rr:
                    WriteLine(rr);
                    break;
            }
        }
    }

    class Shape
    {

    }

    class Rectangle : Shape
    {
        public int Width, Height;

        public override string ToString()
        {
            return $"{nameof(Width)} : {Width}, {nameof(Height)} : {Height}";
        }
    }

    class Circle : Shape
    {
        public int Diameter;

        public override string ToString()
        {
            return $"{nameof(Diameter)} : {Diameter}";
        }
    }
}
