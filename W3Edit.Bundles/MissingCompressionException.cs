using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W3Edit.Bundles
{
    public class MissingCompressionException : Exception
    {
        public MissingCompressionException(string message) :
            base (message)
        {

        }

        public uint Compression { get; set; }
    }
}
