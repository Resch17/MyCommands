using System;
using System.IO;
using System.Collections.Generic;

if (args.Length < 1)
{
    Console.WriteLine("USAGE: myhead <filename> (optional: <filename2> <filename3> ...)");
    Environment.Exit(1);
}

if (args.Length == 1)
{
    var filename = args[0];

    if (!File.Exists(filename))
    {
        Console.WriteLine($"No such file: {filename}");
        Environment.Exit(1);
    }

    using var file = new StreamReader(filename);
    using var fileCount = new StreamReader(filename);
    while (fileCount.ReadLine() != null)
    {
        var line = file.ReadLine();
        if (line == null)
        {
            return;
        }
        Console.WriteLine(line);
    }
}

if (args.Length > 1)
{
    List<string> concatFiles = new List<string>();

    for (int i = 0; i < args.Length; i++)
    {
        var filename = args[i];
        if (!File.Exists(filename))
        {
            Console.WriteLine($"No such file: {filename}");
            Environment.Exit(1);
        }

        using var file = new StreamReader(filename);
        using var fileCount = new StreamReader(filename);
        while (fileCount.ReadLine() != null)
        {
            var line = file.ReadLine();
            if (line == null)
            {
                return;
            }
            Console.WriteLine(line);
        }
    }
}
