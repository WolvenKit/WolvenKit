using System;

namespace WolvenKit.RED4.CR2W
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
