using System;

namespace WolvenKit.Interfaces.Core
{
    public class InvalidParsingException : Exception
    {
        #region Constructors

        public InvalidParsingException(string message) : base(message)
        {
        }

        #endregion Constructors
    }

    public class InvalidSerializationException : Exception
    {
        #region Constructors

        public InvalidSerializationException(string message) : base(message)
        {
        }

        #endregion Constructors
    }
}
