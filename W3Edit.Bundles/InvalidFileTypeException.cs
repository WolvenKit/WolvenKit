using System;

namespace W3Edit.Bundles
{
    public class InvalidBundleException : Exception
    {
        public InvalidBundleException(string message) : base(message)
        {
        }
    }
}