using System;

namespace CP77.CR2W
{
    public class InvalidFileTypeException : Exception
    {
        public InvalidFileTypeException(string message)
            : base(message)
        {
        }
    }
}