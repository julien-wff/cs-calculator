using System;

namespace Calculator.commands;

public class HelpCommand : Command
{
    protected override bool CheckArgs(string[] args)
    {
        if (args.Length > 1)
        {
            Console.WriteLine("Error: Too many arguments");
            return false;
        }

        return true;
    }

    public override bool Run(string[] args)
    {
        if (!CheckArgs(args))
            return false;

        Console.WriteLine("""
                          --- Calculator Help ---

                          Usage: calculator <command> [<args>]

                          These are common Calculator commands used in various situations:

                          version, v, --version, -v
                              Display the version of the Calculator.

                          help, --help, -h
                              Display help information about the Calculator.

                          add <num1> <num2>
                              Add two numbers and display the result.
                          """);

        return true;
    }
}