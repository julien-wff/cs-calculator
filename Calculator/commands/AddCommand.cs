using System;

namespace Calculator.commands;

public class AddCommand : Command
{
    protected override bool CheckArgs(string[] args)
    {
        switch (args.Length)
        {
            case < 3:
                Console.WriteLine("Error: Not enough arguments, 2 numbers expected");
                return false;
            case > 3:
                Console.WriteLine("Error: Too many arguments, 2 numbers expected");
                return false;
        }

        if (!double.TryParse(args[1], out _))
        {
            Console.WriteLine($"Error: {args[1]} is not a number");
            return false;
        }

        if (!double.TryParse(args[2], out _))
        {
            Console.WriteLine($"Error: {args[2]} is not a number");
            return false;
        }

        return true;
    }

    /// <summary>
    /// Usage: calc add &lt;number1&gt; &lt;number2&gt;
    /// </summary>
    /// <param name="args">The full list of command arguments</param>
    public override bool Run(string[] args)
    {
        if (!CheckArgs(args))
            return false;

        var number1 = double.Parse(args[1]);
        var number2 = double.Parse(args[2]);
        var result = number1 + number2;

        Console.WriteLine(result);
        return true;
    }
}