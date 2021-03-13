using System;

namespace WolvenKit.RED4.CR2W.Types
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
