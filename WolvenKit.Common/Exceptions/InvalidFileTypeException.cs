using System;

namespace WolvenKit.Common.Exceptions
{
    public class InvalidFileTypeException : Exception
    {
        #region Constructors

        public InvalidFileTypeException(string message)
            : base(message)
        {
        }

        #endregion Constructors
    }
}
