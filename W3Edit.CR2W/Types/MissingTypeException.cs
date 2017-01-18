using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W3Edit.CR2W.Types
{
    public class MissingTypeException : Exception
    {
        public MissingTypeException(string message) : base(message)
        {

        }
    }
}
