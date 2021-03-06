using System;
using System.IO;

if (args.Length < 1)
{
    Console.Error.WriteLine("USAGE: mycat <filename> (optional: <filename2> <filename3> ...)");
    Environment.Exit(1);
}

foreach (string filename in args)
{
    if (!File.Exists(filename))
    {
        Console.Error.WriteLine($"No such file: {filename}");
        continue;
    }

    using var file = new StreamReader(filename);
    while (file.Peek() > -1)
    {
        var line = file.ReadLine();
        if (line == null)
        {
            return;
        }
        Console.WriteLine(line);
    }
}
