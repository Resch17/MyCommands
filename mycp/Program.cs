using System;
using System.IO;

namespace mycp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.Error.WriteLine("USAGE: mycp <fileToCopy> <destinationFilename>");
                Environment.Exit(0);
            }
            string originFile = args[0];
            string destinationFile = args[1];

            try
            {
                File.Copy(originFile, destinationFile);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Could not copy - {ex.Message}");
                Environment.Exit(0);
            }
        }
    }
}
