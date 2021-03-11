using System;
using System.IO;

namespace myrm
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Error.WriteLine("USAGE: myrm <FILE> ...");
                Environment.Exit(0);
            }
            foreach (string file in args)
            {
                try
                {
                    if (File.Exists(file))
                    {
                        File.Delete(file);
                    }
                    else
                    {
                        throw new Exception("File does not exist");
                    }
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine($"Could not delete file {file}");
                    Console.Error.WriteLine(ex.Message);
                    continue;
                }
            }
        }
    }
}
