using CSharp8.IndicesAndRanges;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace CSharp8.Tests
{
    public class IndicesAndRangesTests : BaseTest
    {
        private readonly string[] _words = new string[]
        {
            "The",
            "quick",
            "brown",
            "fox",
            "jumped",
            "over",
            "the",
            "lazy",
            "dog"
        };

        public IndicesAndRangesTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void GetWordDog()
        {
            var runner = new IndicesAndRangesRun(_words);
            Assert.Equal("dog", runner.GetWord(8));
        }

        [Fact]
        public void GetWordsLazyDog()
        {
            var runner = new IndicesAndRangesRun(_words);
            Assert.Equal("lazy,dog", runner.GetWordsFromStart(7, 9));
        }

        [Fact]
        public void GetWordsLazyDog2()
        {
            var runner = new IndicesAndRangesRun(_words);
            Assert.Equal("lazy,dog", runner.GetWordsFromEnd(2, 0));
        }

        [Fact]
        public void GetAllWords()
        {
            var runner = new IndicesAndRangesRun(_words);
            Assert.Equal(_words, runner.GetAllWords());
        }
    }
}
