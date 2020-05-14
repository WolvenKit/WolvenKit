using System;

namespace WolvenKit.CR2W.Types
{
    public class MissingTypeException : Exception
    {
        public MissingTypeException(string message) : base(message)
        {
        }
    }
}