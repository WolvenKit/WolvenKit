using System;
using System.Diagnostics;
using System.ComponentModel;

namespace WolvenKit.RED4.Types
{
    [RED("serializationDeferredDataBuffer")]
    public class SerializationDeferredDataBuffer : IRedPrimitive, IEquatable<SerializationDeferredDataBuffer>
    {
        [Browsable(false)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public Red4File File { get; set; }


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public ushort Pointer { get; set; }

        [Browsable(false)]
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public RedBuffer Buffer
        {
            get
            {
                if (Pointer >= File._buffers.Count)
                {
                    throw new IndexOutOfRangeException(nameof(Pointer));
                }
                return File._buffers[Pointer];
            }
            set
            {
                var existingBuffer = File.BufferHandler.IndexOf(value);
                if (existingBuffer != -1)
                {
                    Pointer = (ushort)existingBuffer;
                }
                else
                {
                    File._buffers[Pointer] = value;
                }
            }
        }

        [Browsable(false)]
        public IParseableBuffer Data
        {
            get => Buffer.Data;
            set => Buffer.Data = value;
        }

        public SerializationDeferredDataBuffer(Red4File file, ushort pointer)
        {
            File = file;
            Pointer = pointer;

            File.BufferHandler.Register(pointer, this);
        }

        public void Compress()
        {
            if (Pointer >= File._buffers.Count)
            {
                throw new IndexOutOfRangeException(nameof(Pointer));
            }

            File._buffers[Pointer].Compress();
        }

        public void Decompress()
        {
            if (Pointer >= File._buffers.Count)
            {
                throw new IndexOutOfRangeException(nameof(Pointer));
            }

            File._buffers[Pointer].Decompress();
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
