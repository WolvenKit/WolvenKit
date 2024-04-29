using System;

namespace WolvenKit.Core.Exceptions;

public class WolvenKitException(int errorCode, string message) : Exception(message)
{
    /// <summary>
    /// Error code for exception. Define in WolvenKit.Helpers.LogCodeHelper in WolvenkitCommon./>.
    /// </summary>
    public int ErrorCode { get; } = errorCode;
}