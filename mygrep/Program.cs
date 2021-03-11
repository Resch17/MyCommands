﻿using System;
using System.IO;
using System.Collections.Generic;

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
            string textPath = args[1];

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
                if (line.Contains(searchString))
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
