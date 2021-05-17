using System;

namespace WolvenKit.Common.Exceptions
{
    public class TypeMismatchException : Exception
    {
        public TypeMismatchException(string expected, string got) : base($"Type mismatch (Expected:\"{expected}\", Got:\"{got}\")")
        {
        }
    }
}
