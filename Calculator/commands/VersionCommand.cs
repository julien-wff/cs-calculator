using System;

namespace Calculator.commands;

public class VersionCommand : Command
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

        var version = typeof(Program).Assembly.GetName().Version;
        Console.WriteLine($"Calculator v{version}");
        return true;
    }
}