using System;
using System.Runtime.Serialization;

namespace WolvenKit.Interfaces.Core
{
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

        #endregion Constructors
    }
}
