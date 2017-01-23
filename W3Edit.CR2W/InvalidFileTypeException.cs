using System;

namespace W3Edit.CR2W
{
    public class InvalidFileTypeException : Exception
    {
        public InvalidFileTypeException(string message)
            : base(message)
        {
        }
    }
}