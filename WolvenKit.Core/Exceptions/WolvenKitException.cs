using System;

namespace WolvenKit.Core.Exceptions;

public class WolvenKitException : Exception
{

    public WolvenKitException(int errorCode, string message) : base(message) => ErrorCode = errorCode;

    /// <summary>
    /// Error code for exception. Define in WolvenKit.Helpers.LogCodeHelper in WolvenkitCommon./>.
    /// </summary>
    public int ErrorCode { get; }
}