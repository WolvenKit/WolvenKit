using System;

namespace WolvenKit.CR2W.Types
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
