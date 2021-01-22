using System;

namespace CP77.CR2W
{
    public class InvalidChunkTypeException : Exception
    {
        public InvalidChunkTypeException(string message)
            : base(message)
        {
        }
    }
}