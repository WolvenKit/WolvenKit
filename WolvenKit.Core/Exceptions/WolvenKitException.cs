using System;

namespace WolvenKit.Core.Exceptions;

public class WolvenKitException : Exception
{
    public int ErrorCode { get; }
    
    public WolvenKitException(int errorCode, string message) : base(message)
    {
        ErrorCode = errorCode;
    }
}