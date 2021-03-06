using System;
using System.IO;
using System.Collections.Generic;

const int LINE_COUNT = 10;

if (args.Length != 1)
{
    Console.Error.WriteLine("USAGE: myhead <filename>");
    Environment.Exit(1);
}

var filename = args[0];

if (!File.Exists(filename))
{
    Console.Error.WriteLine($"No such file: {filename}");
    Environment.Exit(1);
}

using var file = new StreamReader(filename);
List<string> lineList = new List<string>();
int lineCounter = 0;
while (file.Peek() > -1)
{
    string line = file.ReadLine();
    lineList.Add(line);
    lineCounter++;
}

lineList.Reverse();

List<string> backwardList = new List<string>();

for (var i = 0; i < LINE_COUNT; i++)
{
    try
    {
        backwardList.Add(lineList[i]);
    }
    catch
    {
        break;
    }
}

backwardList.Reverse();
foreach (string line in backwardList)
{
    Console.WriteLine(line);
}
