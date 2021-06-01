using System;

namespace WolvenKit.Core.Exceptions
{
    public class TypeMismatchException : Exception
    {
        public TypeMismatchException(string expected, string got) : base($"Type mismatch (Expected:\"{expected}\", Got:\"{got}\")")
        {
        }
    }
}
