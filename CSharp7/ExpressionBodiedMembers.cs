using Infrastructure;
using System.Collections.Generic;
using static System.Console;

namespace CSharp7.ExpressionBodiedMembers
{
    public class ExpressionBodiedMembers : Demo<ExpressionBodiedMembers>
    {
        public override int Title => 7;

        public override void Run()
        {
            var me = new Person(1, "Jack");
            me.Id = 1;
            WriteLine($"my name is {me.Name}");
        }
    }

    public class Person
    {
        public int Id;

        private static readonly Dictionary<int, string> names = new Dictionary<int, string>();

        public Person(int id, string name) => names.Add(id, name);
        ~Person() => names.Remove(Id);

        public string Name
        {
            get => names[Id];
            set => names[Id] = value;
        }
    }
}
