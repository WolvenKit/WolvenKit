using System;

namespace WolvenKit.Modkit.Exceptions;

[Serializable]
public class PackException : Exception
{
    public PackException() { }
    public PackException(string message) : base(message) { }
    public PackException(string message, Exception inner) : base(message, inner) { }
}
