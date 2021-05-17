using System;

namespace WolvenKit.Common.Exceptions
{
    public class InvalidChunkTypeException : Exception
    {
        #region Constructors

        public InvalidChunkTypeException(string message)
            : base(message)
        {
        }

        #endregion Constructors
    }
}
