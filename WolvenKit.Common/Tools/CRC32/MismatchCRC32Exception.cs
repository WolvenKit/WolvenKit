using System;

namespace WolvenKit.Common.Tools.CRC32
{
    public class MismatchCRC32Exception : Exception
    {
        public MismatchCRC32Exception()
        {

        }

        public MismatchCRC32Exception(string message) : base(message)
        {

        }

        public MismatchCRC32Exception(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
