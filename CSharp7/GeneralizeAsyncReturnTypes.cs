using Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp7
{
    public class GeneralizeAsyncReturnTypes : Demo<GeneralizeAsyncReturnTypes>
    {
        public override int Title => 9;

        public override void Run()
        {
            WriteLine(GetDirSize2(@"c:\temp").Result);
        }

        static async Task<long> GetDirSize(string dir)
        {
            if (!Directory.EnumerateFileSystemEntries(dir).Any())
            {
                return 0;
            }

            return await Task.Run(() => Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories).Sum(f => new FileInfo(f).Length));
        }

        static async ValueTask<long> GetDirSize2(string dir)
        {
            if (!Directory.EnumerateFileSystemEntries(dir).Any())
            {
                return 0;
            }

            return await Task.Run(() => Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories).Sum(f => new FileInfo(f).Length));
        }
    }
}
