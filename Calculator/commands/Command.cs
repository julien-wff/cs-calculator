namespace Calculator.commands;

public abstract class Command
{
    protected abstract bool CheckArgs(string[] args);
    public abstract bool Run(string[] args);
}