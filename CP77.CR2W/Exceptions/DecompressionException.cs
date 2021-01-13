using System;

namespace CP77.CR2W.Types
{
    public class DecompressionException : Exception
    {
        public DecompressionException(string message) : base(message)
        {
        }
    }
}