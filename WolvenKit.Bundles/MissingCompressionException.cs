using System;

namespace WolvenKit.Bundles
{
    public class MissingCompressionException : Exception
    {
        #region Constructors

        public MissingCompressionException(string message) :
            base(message)
        {
        }

        #endregion Constructors



        #region Properties

        public uint Compression { get; set; }

        #endregion Properties
    }
}
