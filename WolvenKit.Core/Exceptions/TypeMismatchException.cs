using System;

namespace WolvenKit.Core.Exceptions
{
    public class TypeMismatchException : Exception
    {
        public TypeMismatchException(string expected, string got) : base($"Type mismatch (Expected:\"{expected}\", Got:\"{got}\")")
        {
        }
    }

    public class MissingRTTIException : Exception
    {
        public MissingRTTIException(string varname, string vartype, string parenttype) :
            base($"Missing in wolven rtti: ({vartype}){varname} in {parenttype}")
        {
        }
    }
}
