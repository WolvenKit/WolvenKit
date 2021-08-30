using System;

namespace WolvenKit.RED4.Types
{
    public class TweakDBID : IRedPrimitive, IEquatable<TweakDBID>
    {
        public ulong Value { get; set; }

        public static implicit operator TweakDBID(ulong value) => new() { Value = value };
        public static implicit operator ulong(TweakDBID value) => value.Value;


        public override bool Equals(object obj)
        {
            if (obj is TweakDBID cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(TweakDBID other)
        {
            if (other == null)
            {
                return false;
            }

            return Value.Equals(other.Value);
        }
    }
}
