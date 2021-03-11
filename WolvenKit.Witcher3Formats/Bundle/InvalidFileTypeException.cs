using System;

namespace WolvenKit.Bundles
{
    public class InvalidBundleException : Exception
    {
        #region Constructors

        public InvalidBundleException(string message) : base(message)
        {
        }

        #endregion Constructors
    }
}
