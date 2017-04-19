using System;

namespace WolvenKit.Bundles
{
    public class InvalidBundleException : Exception
    {
        public InvalidBundleException(string message) : base(message)
        {
        }
    }
}