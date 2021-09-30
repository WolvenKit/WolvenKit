using System;

namespace WolvenKit.Interfaces.Core
{
    public class InvalidParsingException : Exception
    {
        #region Constructors

        public InvalidParsingException()
        {
            
        }

        public InvalidParsingException(string message) : base(message)
        {
        }

        #endregion Constructors
    }
}
