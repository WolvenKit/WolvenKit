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

        private RedBuffer _inlineBuffer;

        public RedBuffer Buffer
        {
            get
            {
                if (Pointer == -1)
                {
                    return _inlineBuffer;
                }

                if (Pointer < 0 || Pointer >= File._buffers.Count)
                {
                    throw new IndexOutOfRangeException(nameof(Pointer));
                }

                return File._buffers[Pointer];
            }
            set
            {
                if (Pointer == -1)
                {
                    _inlineBuffer = value;
                    return;
                }

                var existingBuffer = File.BufferHandler.IndexOf(value);
                if (existingBuffer != -1)
                {
                    Pointer = existingBuffer;
                }
                else
                {
                    File._buffers[Pointer] = value;
                }
            }
        }

        public IParseableBuffer Data
        {
            get => Buffer.Data;
            set => Buffer.Data = value;
        }

        public DataBuffer() {}

        public DataBuffer(Red4File file, int pointer)
        {
            File = file;
            Pointer = pointer;

            File.BufferHandler.Register(pointer, this);
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
