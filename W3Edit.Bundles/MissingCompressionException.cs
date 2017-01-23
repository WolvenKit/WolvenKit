using System;

namespace W3Edit.Bundles
{
    public class MissingCompressionException : Exception
    {
        public MissingCompressionException(string message) :
            base(message)
        {
        }

        public uint Compression { get; set; }
    }
}