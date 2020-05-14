using System;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [Serializable]
    internal class InvalidPtrException : Exception
    {
        public InvalidPtrException()
        {
        }

        public InvalidPtrException(string message) : base(message)
        {
        }

        public InvalidPtrException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidPtrException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}