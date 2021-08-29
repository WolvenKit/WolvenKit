using System;

namespace WolvenKit.RED4.Types.Exceptions
{
    public class TypeNotFoundException : Exception
    {
        public string RedTypeName { get; set; }

        public TypeNotFoundException(string redTypeName) : base($"The type '{redTypeName}' could not be found")
        {
            RedTypeName = redTypeName;
        }
    }
}
