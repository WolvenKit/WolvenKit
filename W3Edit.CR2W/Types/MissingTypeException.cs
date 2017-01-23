using System;

namespace W3Edit.CR2W.Types
{
    public class MissingTypeException : Exception
    {
        public MissingTypeException(string message) : base(message)
        {
        }
    }
}