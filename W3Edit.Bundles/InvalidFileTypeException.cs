using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W3Edit.Bundles
{
    public class InvalidBundleException : Exception
    {
        public InvalidBundleException(string message) : base(message)
        {

        }
    }
}
