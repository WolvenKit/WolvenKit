using System;

namespace WolvenKit.CR2W
{
    public class InvalidFileTypeException : Exception
    {
        public InvalidFileTypeException(string message)
            : base(message)
        {
        }
    }
}