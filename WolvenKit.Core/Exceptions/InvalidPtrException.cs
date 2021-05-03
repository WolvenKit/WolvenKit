using System;
using System.Runtime.Serialization;

namespace WolvenKit.Interfaces.Core
{
    [Serializable]
    public class InvalidPtrException : Exception
    {
        #region Constructors

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

        #endregion Constructors
    }
}
