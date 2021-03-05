using System;

namespace WolvenKit.Cache
{
    public class CacheWritingException : Exception
    {
        #region Constructors

        public CacheWritingException(string message) : base(message)
        {
        }

        #endregion Constructors
    }
}
