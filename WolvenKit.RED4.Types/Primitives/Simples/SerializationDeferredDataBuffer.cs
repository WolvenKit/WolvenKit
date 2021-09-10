using System;

namespace WolvenKit.RED4.Types
{
    [RED("serializationDeferredDataBuffer")]
    public class SerializationDeferredDataBuffer : IRedPrimitive, IEquatable<SerializationDeferredDataBuffer>
    {
        public ushort Buffer { get; set; }

        public bool Equals(SerializationDeferredDataBuffer other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Buffer == other.Buffer;
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

            return Equals((SerializationDeferredDataBuffer)obj);
        }

        public override int GetHashCode() => Buffer.GetHashCode();
    }
}
