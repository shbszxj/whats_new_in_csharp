using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public abstract class Demo<T> : IDemo
    {
        public abstract int Title { get; }

        public virtual string Description => $"{typeof(T)}";

        public abstract void Run();
    }
}
