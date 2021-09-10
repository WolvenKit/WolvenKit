using System;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    public class SharedDataBuffer : IRedPrimitive, IEquatable<SharedDataBuffer>
    {
        public byte[] Buffer { get; set; }

        public bool Equals(SharedDataBuffer other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Equals(Buffer, other.Buffer);
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

            return Equals((SharedDataBuffer)obj);
        }

        public override int GetHashCode() => (Buffer != null ? Buffer.GetHashCode() : 0);
    }
}
