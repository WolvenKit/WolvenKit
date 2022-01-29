using System;

namespace WolvenKit.Core.Exceptions;

public class DecompressionException : Exception
{
    #region Constructors

    public DecompressionException(string message) : base(message)
    {
    }

    #endregion Constructors
}
