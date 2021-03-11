using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace mygrep
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Error.WriteLine("USAGE: mygrep <search pattern> <filename>");
                Environment.Exit(1);
            }

            string searchString = args[0];
            string[] files = args.Skip(1).ToArray();
            foreach (string textPath in files)
            {
                if (!File.Exists(textPath))
                {
                    Console.Error.WriteLine($"No such file: {textPath}");
                    Environment.Exit(1);
                }

                using var file = new StreamReader(textPath);
                while (file.Peek() > -1)
                {
                    var line = file.ReadLine();
                    if (line == null)
                    {
                        return;
                    }
                    Match m = Regex.Match(line, searchString);
                    if (m.Success)
                    {
                        Console.WriteLine(line);
                    }
                }
            }

        }
    }
}
