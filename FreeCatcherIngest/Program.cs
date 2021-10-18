using System;

namespace FreeCatcherIngest
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckDependencies();
            CreateMenu();
        }

        static void CheckDependencies()
        {
            // Check FFMpeg is installed
            Console.WriteLine("Checking FFMpeg install");
            FFmpegManager.CheckInstall();

            // Check NDI support
            Console.Write("NDI Supported: ");
            Console.WriteLine(NDIManager.Initialize());
        }

        static void CreateMenu()
        {
            Console.WriteLine();
            Console.WriteLine("FreeCatcher Ingest Server Running");
            InputLoop();
        }

        static void InputLoop()
        {
            string input = Console.ReadLine();
        }


    }
}
