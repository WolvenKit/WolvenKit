using System;

namespace WolvenKit.CR2W
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
