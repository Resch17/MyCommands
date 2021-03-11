using System;
using System.IO;

namespace mymmv
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.Error.WriteLine("USAGE: mymv <FILE1> <DESTINATION FILE OR DIR>");
                Environment.Exit(0);
            }

            string file = args[0];
            string destination = args[1];

            try
            {
                File.Move(file, destination);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Couldn't execute mv on file: {file}");
                Console.Error.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }
    }
}
