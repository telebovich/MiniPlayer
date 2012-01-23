using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuartzTypeLib;

namespace ConsolePlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check to see if the user passed in a filename:
            if (args.Length != 1)
            {
                DisplayUsage();
                return;
            }

            if (args[0] == "/?")
            {
                DisplayUsage();
                return;
            }

            string filename = args[0];

            // Check to see if the file exists
            if (!System.IO.File.Exists(filename))
            {
                Console.WriteLine("File " + filename + " not found.");
                DisplayUsage();
                return;
            }

             // Create instance of Quartz 
            // (Calls CoCreateInstance(E436EBB3-524F-11CE-9F53-0020AF0BA770, 
            //  NULL, CLSCTX_ALL, IID_IUnknown, 
            //  &graphManager).):
            try
            {
                FilgraphManager graphManager = new FilgraphManager();
                IMediaControl mc = (IMediaControl)graphManager;

                mc.RenderFile(filename);
                mc.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected COM exception: " + e.Message);                
            }
            // Wait for completion. 
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }

        private static void DisplayUsage()
        {
            // User did not provide enough parameters. 
            // Display usage. 
            Console.WriteLine("VideoPlayer: Plays AVI files.");
            Console.WriteLine("Usage: VIDEOPLAYER.EXE filename");
            Console.WriteLine("where filename is the full path and");
            Console.WriteLine("file name of the AVI to display.");
        }
    }
}
