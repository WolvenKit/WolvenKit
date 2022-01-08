using System;
using System.Diagnostics;
using System.ComponentModel;

namespace WolvenKit.RED4.Types
{
    public class DataBuffer : IRedDataBuffer, IRedBufferPointer, IEquatable<DataBuffer>
    {
        [Browsable(false)]
        public RedBuffer Buffer { get; set; }

        [Browsable(false)]
        public IParseableBuffer Data
        {
            get => Buffer.Data;
            set => Buffer.Data = value;
        }

        public DataBuffer()
        {
            Buffer = new RedBuffer();
        }

        public DataBuffer(byte[] data)
        {
            Buffer = RedBuffer.CreateBuffer(0, data);
        }


        public RedBuffer GetValue() => Buffer;
        public void SetValue(RedBuffer instance) => Buffer = instance;

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

            return ReferenceEquals(Buffer, other.Buffer);
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

        public override int GetHashCode() => Buffer.GetHashCode();
    }
}
