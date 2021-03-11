using System;
using System.IO;
using System.Collections;

namespace myls
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "";
            if (args.Length == 0)
            {
                path = Directory.GetCurrentDirectory();
            }
            else
            {
                path = args[0];
            }
            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);
            foreach (string dir in directories)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                string output = dir.Replace(path + @"\", "");
                Console.WriteLine(output);
            }
            foreach (string file in files)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                string output = file.Replace(path + @"\", "");
                Console.WriteLine(output);
            }
        }
    }
}
