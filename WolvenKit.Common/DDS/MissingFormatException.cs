using System;
using System.Runtime.Serialization;

namespace WolvenKit.Common.DDS
{
    public class MissingFormatException : Exception
    {
        #region Constructors

        public MissingFormatException(string message)
            : base(message)
        {
        }

        public MissingFormatException()
        {
        }

        public MissingFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MissingFormatException(SerializationInfo serializationInfo, StreamingContext streamingContext) => throw new NotImplementedException();

        #endregion Constructors
    }
}
