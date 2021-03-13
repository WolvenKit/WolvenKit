using System;

namespace WolvenKit.RED4.CR2W
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
