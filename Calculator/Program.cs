using System;
using Calculator.commands;

namespace Calculator;

public abstract class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Error: Missing arguments");
            return;
        }

        switch (args[0])
        {
            case "version":
            case "v":
            case "--version":
            case "-v":
                var versionCommand = new VersionCommand();
                versionCommand.Run(args);
                break;

            case "help":
            case "-h":
            case "--help":
                var helpCommand = new HelpCommand();
                helpCommand.Run(args);
                break;

            case "add":
                var addCommand = new AddCommand();
                addCommand.Run(args);
                break;

            default:
                Console.WriteLine($"Error: Unknown argument {args[0]}");
                break;
        }
    }
}