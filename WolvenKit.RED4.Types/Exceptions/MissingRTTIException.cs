using System;

namespace WolvenKit.RED4.Types.Exceptions
{
    public class MissingRTTIException : Exception
    {
        public MissingRTTIException(string varname, string vartype, string parenttype) : base($"Missing in wolven rtti: ({vartype}){varname} in {parenttype}")
        {
        }
    }
}
