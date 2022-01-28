using System;
using System.Diagnostics;
using System.ComponentModel;

namespace WolvenKit.RED4.Types
{
    [RED("serializationDeferredDataBuffer")]
    public class SerializationDeferredDataBuffer : IRedBufferWrapper, IRedBufferPointer, IRedPrimitive, IEquatable<SerializationDeferredDataBuffer>
    {
        [Browsable(false)]
        public RedBuffer Buffer { get; set; }

        [Browsable(false)]
        public IParseableBuffer Data
        {
            get => Buffer.Data;
            set => Buffer.Data = value;
        }


        public SerializationDeferredDataBuffer()
        {
            Buffer = new RedBuffer();
        }

        public SerializationDeferredDataBuffer(byte[] data)
        {
            Buffer = RedBuffer.CreateBuffer(0, data);
        }


        public RedBuffer GetValue() => Buffer;
        public void SetValue(RedBuffer instance) => Buffer = instance;

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

            if (!Equals(Buffer, other.Buffer))
            {
                return false;
            }

            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj is SerializationDeferredDataBuffer cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public override int GetHashCode() => Buffer.GetHashCode();
    }
}
