using System;

namespace WolvenKit.Core.Exceptions;

public class WolvenKitException : Exception
{
    /// <summary>
    /// Error code for exception. Define in WolvenKit.Helpers.LogCodeHelper in WolvenkitCommon./>.
    /// </summary>
    public int ErrorCode { get; }

    public WolvenKitException(int errorCode, string message) : base(message) => ErrorCode = errorCode;

    [Obsolete("Please use the other constructor and define an error code in LogCodeHelper")]
    public WolvenKitException(string message) : this(-1, message) { }
}