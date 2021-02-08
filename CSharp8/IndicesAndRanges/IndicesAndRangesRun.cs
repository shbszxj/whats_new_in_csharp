using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8.IndicesAndRanges
{
    public class IndicesAndRangesRun
    {
        private readonly string[] _words;

        public IndicesAndRangesRun(string[] words)
        {
            _words = words;
        }

        public string[] GetAllWords()
        {
            return _words[..];
        }

        public string GetWord(int index)
        {
            return _words[index];
        }

        public string GetWordsFromStart(int start, int end)
        {
            return ParseStringArrayToString(_words[start..end]);
        }

        public string GetWordsFromEnd(int start, int end)
        {
            return ParseStringArrayToString(_words[^start..^end]);
        }

        private string ParseStringArrayToString(string[] array)
        {
            return string.Join(",", array);
        }
    }
}
