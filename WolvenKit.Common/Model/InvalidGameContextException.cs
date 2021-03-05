using System;

namespace WolvenKit.Common.Model
{
    public class InvalidGameContextException : Exception
    {
        #region Constructors

        public InvalidGameContextException(string message) : base(message)
        {
        }

        #endregion Constructors
    }
}
