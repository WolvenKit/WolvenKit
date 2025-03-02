using System;

namespace WolvenKit.Core.Exceptions;

public class WolvenKitException : Exception
{
    private readonly string _message;

    public WolvenKitException(int errorCode, string message) : base(message)
    {
        ErrorCode = errorCode;
        _message = message;
    }
    
    /// <summary>
    /// Error code for exception. Define in WolvenKit.Helpers.LogCodeHelper in WolvenkitCommon./>.
    /// </summary>
    public int ErrorCode { get; }
}