using System;

namespace WolvenKit.RED4.Types.Exceptions
{
    public class InvalidParsingException : Exception
    {
        #region Constructors

        public InvalidParsingException(string message) : base(message)
        {
        }

        #endregion Constructors
    }
}
