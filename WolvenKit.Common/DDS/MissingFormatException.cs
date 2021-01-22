using System;
using System.Runtime.Serialization;

namespace WolvenKit.Common.DDS
{
    [Serializable]
    public class MissingFormatException : Exception
    {
        public MissingFormatException(string message)
            : base(message)
        {
        }

        protected MissingFormatException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }

        public MissingFormatException()
        {
        }

        public MissingFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
