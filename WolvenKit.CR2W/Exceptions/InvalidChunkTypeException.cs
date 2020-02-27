using System;

namespace WolvenKit.CR2W
{
    public class InvalidChunkTypeException : Exception
    {
        public InvalidChunkTypeException(string message)
            : base(message)
        {
        }
    }
}