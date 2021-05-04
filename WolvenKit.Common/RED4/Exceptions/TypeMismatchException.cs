using System;

namespace WolvenKit.RED4.CR2W.Exceptions
{
    public class TypeMismatchException : Exception
    {
        public TypeMismatchException(string expected, string got) : base($"Type mismatch (Expected:\"{expected}\", Got:\"{got}\")")
        {
        }
    }
}
