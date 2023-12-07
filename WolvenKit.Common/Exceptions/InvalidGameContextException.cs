using System;
using System.Runtime.Serialization;

namespace WolvenKit.Common.Model
{
    [Serializable]
    public class InvalidGameContextException : Exception
    {
        public InvalidGameContextException()
        {
        }

        public InvalidGameContextException(string? message) : base(message)
        {
        }

        public InvalidGameContextException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
