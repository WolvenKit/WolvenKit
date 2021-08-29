using System;

namespace WolvenKit.RED4.Types
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class OrdinalAttribute : Attribute
    {
        internal OrdinalAttribute(ushort ordinal)
        {
            Ordinal = ordinal;
        }

        public ushort Ordinal { get; private set; }
    }
}
