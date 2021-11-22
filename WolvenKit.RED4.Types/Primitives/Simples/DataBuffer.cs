using System;
using System.Diagnostics;

namespace WolvenKit.RED4.Types
{
    public class DataBuffer : IRedDataBuffer, IEquatable<DataBuffer>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public Red4File File { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int Pointer { get; set; } = -1;

        private byte[] _inlineBuffer = Array.Empty<byte>();

        public byte[] Buffer
        {
            get
            {
                if (Pointer < -1 || Pointer >= File._buffers.Count)
                {
                    throw new IndexOutOfRangeException(nameof(Pointer));
                }

                if (Pointer == -1)
                {
                    return _inlineBuffer;
                }

                return File._buffers[Pointer].Data;
            }
            set
            {
                var existingBuffer = File.BufferHandler.GetIndex(value);
                if (existingBuffer != -1)
                {
                    Pointer = existingBuffer;
                }
                else
                {
                    File._buffers[Pointer].Data = value;
                }
            }
        }

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
