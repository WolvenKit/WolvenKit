using System;

namespace W3Edit.CR2W
{
    public class InvalidChunkTypeException : Exception
    {
        public InvalidChunkTypeException(string message)
            : base(message)
        {
        }
    }
}