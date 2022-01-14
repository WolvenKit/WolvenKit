using System;

namespace WolvenKit.Core.CRC
{
    public class MismatchCRC32Exception : Exception
    {
        #region Constructors

        public MismatchCRC32Exception()
        {
        }

        public MismatchCRC32Exception(string message) : base(message)
        {
        }

        public MismatchCRC32Exception(string message, Exception innerException) : base(message, innerException)
        {
        }

        #endregion Constructors
    }
}
