using Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using static System.Console;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var objs = new List<IDemo>();
            foreach(var file in Directory.GetFiles(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "*.dll"))
            {
                foreach (var demo in Assembly.LoadFile(file).DefinedTypes.Where(o => o.ImplementedInterfaces.Contains(typeof(IDemo)) && !o.IsAbstract))
                {
                    objs.Add(Activator.CreateInstance(demo) as IDemo);
                }
                objs = new List<IDemo>(objs.OrderBy(o => o.Title));
            }
            objs.ForEach(o => WriteLine($"{o.Title} : {o.Description}"));
            WriteLine("Please enter the number that you want to run ?");
            float.TryParse(ReadLine(), out var title);
            foreach (var want in objs.OrderBy(o => o.Title).Where(o => o.Title == title))
            {
                want.Run();
            }
            Read();
        }
    }
}
