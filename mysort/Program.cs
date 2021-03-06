using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

if (args.Length < 1)
{
    Console.Error.WriteLine("USAGE: mysort <filename> (optional: <filename2> <filename3> ...)");
    Environment.Exit(1);
}

List<string> lineList = new List<string>();

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
        lineList.Add(line);
    }

}

List<string> sortedList = lineList.OrderBy(line => line).ToList();

foreach (string line in sortedList)
{
    Console.WriteLine(line);
}