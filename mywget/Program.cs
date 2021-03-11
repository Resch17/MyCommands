using System;
using System.Net;

namespace mywget
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.Error.WriteLine("USAGE: mywget <file URL> <destination filename>");
                Environment.Exit(0);
            }
            else
            {
                using (var client = new WebClient())
                {
                    try
                    {
                        client.DownloadFile(args[0], args[1]);
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine($"Could not download file at: {args[0]}");
                        Console.Error.WriteLine(ex.Message);
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
