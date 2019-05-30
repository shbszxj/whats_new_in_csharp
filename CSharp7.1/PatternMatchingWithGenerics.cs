using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp7._1
{
    public class PatternMatchingWithGenerics : Demo<PatternMatchingWithGenerics>
    {
        public override int Title => 23;

        public override void Run()
        {
            var pig = new Pig();
            Cook(pig);
        }

        void Cook<T>(T animal) where T : Animal
        {
            if (animal is Pig pig)
            {
                Write("We cooked and ate the pig...");
            }

            switch(animal)
            {
                case Pig pork:
                    WriteLine(" and it tastes delicious!");
                    break;
            }
        }

        class Animal
        {

        }

        class Pig : Animal
        {

        }


    }
}
