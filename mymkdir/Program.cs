using System;
using System.IO;

namespace mymkdir
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Error.WriteLine("USAGE: mymkdir <directory>");
                Environment.Exit(0);
            }

            foreach (string path in args)
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine($"Directory {path} already exists");
                    continue;
                }
                else
                {
                    Directory.CreateDirectory(path);
                }
            }
        }
    }
}
