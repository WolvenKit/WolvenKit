using System;

namespace WolvenKit.RED3.CR2W
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
