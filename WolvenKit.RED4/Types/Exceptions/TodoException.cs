namespace WolvenKit.RED4.Types.Exceptions;

// Temp exception, if you catch this, you forgot something :P
public class TodoException : Exception
{
    public TodoException()
    {

    }

    public TodoException(string message) : base(message)
    {
    }
}