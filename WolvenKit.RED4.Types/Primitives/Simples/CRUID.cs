using System;

namespace WolvenKit.RED4.Types
{
    public class CRUID : IRedPrimitive, IEquatable<CRUID>
    {
        public ulong Value { get; set; }

        public static implicit operator CRUID(ulong value) => new() { Value = value };
        public static implicit operator ulong(CRUID value) => value.Value;


        public override bool Equals(object obj)
        {
            if (obj is CRUID cObj)
            {
                return Equals(obj);
            }

            return false;
        }

        public bool Equals(CRUID other)
        {
            if (other == null)
            {
                return false;
            }

            return Value.Equals(other.Value);
        }
    }
}
