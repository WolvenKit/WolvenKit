using System;

namespace WolvenKit.RED4.Types
{
    public class LocalizationString : IRedPrimitive, IEquatable<LocalizationString>
    {
        public ulong Unk1 { get; set; }
        public string Value { get; set; }


        public override bool Equals(object obj)
        {
            if (obj is LocalizationString cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(LocalizationString other)
        {
            if (other == null)
            {
                return false;
            }

            return Unk1.Equals(other.Unk1) && Value.Equals(other.Value);
        }
    }
}
