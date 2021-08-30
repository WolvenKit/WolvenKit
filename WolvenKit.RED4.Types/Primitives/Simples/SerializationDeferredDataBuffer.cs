using System;

namespace WolvenKit.RED4.Types
{
    [RED("serializationDeferredDataBuffer")]
    public class SerializationDeferredDataBuffer : IRedPrimitive, IEquatable<SerializationDeferredDataBuffer>
    {
        public CUInt16 Buffer { get; set; }


        public override bool Equals(object obj)
        {
            if (obj is SerializationDeferredDataBuffer cObj)
            {
                return Equals(obj);
            }

            return false;
        }

        public bool Equals(SerializationDeferredDataBuffer other)
        {
            if (other == null)
            {
                return false;
            }

            return Buffer.Equals(other.Buffer);
        }
    }
}
