using System;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    [RED("CGUID")]
    public class CGUID : IRedPrimitive, IEquatable<CGUID>
    {
        public byte[] Value { get; set; }

        public static implicit operator CGUID(byte[] value)
        {
            if (value == null || value.Length != 16)
                throw new ArgumentException(nameof(value));
            return new() { Value = value };
        }

        public static implicit operator byte[](CGUID value) => value.Value;


        public override bool Equals(object value)
        {
            if (value is CGUID cObj)
            {
                return Equals(cObj);
            }
            return false;
        }

        public bool Equals(CGUID other)
        {
            if (other == null)
            {
                return false;
            }

            return Value.SequenceEqual(other.Value);
        }
    }
}
