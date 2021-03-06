using System;
using System.IO;

if (args.Length < 1)
{
    Console.Error.WriteLine("USAGE: mytouch <filename> (optional: <filename2> <filename3> ...)");
    Environment.Exit(1);
}

foreach (string filename in args)
{
    if (!File.Exists(filename))
    {
        File.Create(filename);
    }
    else
    {
        Console.Error.WriteLine($"Error: file already exists - {filename}");
        continue;
    }
}
