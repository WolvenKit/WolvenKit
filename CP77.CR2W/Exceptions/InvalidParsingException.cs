using System;

namespace WolvenKit.CR2W.Types
{
    public class InvalidParsingException : Exception
    {
        public InvalidParsingException(string message) : base(message)
        {
        }
    }

    public class InvalidSerializationException : Exception
    {
        public InvalidSerializationException(string message) : base(message)
        {
        }
    }
}