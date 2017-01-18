using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W3Edit.CR2W
{
    public class InvalidChunkTypeException : Exception
    {
        public InvalidChunkTypeException(string message)
            : base(message)
        {
        }
    }
}
