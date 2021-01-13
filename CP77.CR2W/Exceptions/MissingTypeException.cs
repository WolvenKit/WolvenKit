using System;

namespace CP77.CR2W.Types
{
    public class MissingTypeException : Exception
    {
        public MissingTypeException(string typename) : base($"Missing Type '{typename}'")
        {
        }
    }
}