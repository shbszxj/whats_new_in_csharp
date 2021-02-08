using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace CSharp8.Tests
{
    public class BaseTest
    {
        protected ITestOutputHelper Output { get; }

        public BaseTest(ITestOutputHelper output)
        {
            Output = output;
        }
    }
}
