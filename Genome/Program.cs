using System;
using Helix;
using Interface;

namespace Genome
{
    class Program
    {
        static void Main(string[] args)
        {

            // Path to the help.json file
            string helpFilePath = "..\\..\\..\\help.json";

            // Create an instance of FirstRunManager
            var firstRunManager = new FirstRunManager("Riverside Valley", "Helix");

            // Create an instance of CommandLineInterface
            var cli = new CommandLineInterface("Helix", "Riverside", helpFilePath, firstRunManager);

            // Add commands
            cli.AddCommand("greet", () => Console.WriteLine("Hello, user!"));
            cli.AddCommand("exit", () => Environment.Exit(0));

            // Run the CLI
            cli.Run();
        }
    }
}
