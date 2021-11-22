using System;
using System.Diagnostics;

namespace WolvenKit.RED4.Types
{
    [RED("serializationDeferredDataBuffer")]
    public class SerializationDeferredDataBuffer : IRedPrimitive, IEquatable<SerializationDeferredDataBuffer>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public Red4File File { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public ushort Pointer { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public byte[] Buffer
        {
            get
            {
                if (Pointer >= File._buffers.Count)
                {
                    throw new IndexOutOfRangeException(nameof(Pointer));
                }
                return File._buffers[Pointer].Data;
            }
            set
            {
                var existingBuffer = File.BufferHandler.GetIndex(value);
                if (existingBuffer != -1)
                {
                    Pointer = (ushort)existingBuffer;
                }
                else
                {
                    File._buffers[Pointer].Data = value;
                }
            }
        }

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
