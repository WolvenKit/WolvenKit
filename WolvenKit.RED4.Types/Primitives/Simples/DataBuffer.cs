using System;

namespace WolvenKit.RED4.Types
{
    public class DataBuffer : IRedPrimitive, IEquatable<DataBuffer>
    {
        public byte[] Buffer { get; set; }
        public int Pointer { get; set; } = -1;

        public bool Equals(DataBuffer other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Equals(Buffer, other.Buffer) && Pointer == other.Pointer;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((DataBuffer)obj);
        }

        public override int GetHashCode() => HashCode.Combine(Buffer, Pointer);
    }
}
