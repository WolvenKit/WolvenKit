using System;

namespace WolvenKit.RED4.Types
{
    [RED("CGUID")]
    public class CGUID : IRedPrimitive
    {
        public byte[] Value { get; set; }

        public static implicit operator CGUID(byte[] value)
        {
            if (value == null || value.Length != 16)
                throw new ArgumentException(nameof(value));
            return new() { Value = value };
        }

        public static implicit operator byte[](CGUID value) => value.Value;
    }
}
