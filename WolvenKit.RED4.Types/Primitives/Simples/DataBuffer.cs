using System;
using System.Diagnostics;
using WolvenKit.RED4.Types.Compression;

namespace WolvenKit.RED4.Types
{
    public class DataBuffer : IRedDataBuffer, IEquatable<DataBuffer>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public Red4File File { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int Pointer { get; set; } = -1;

        private byte[] _inlineBuffer = Array.Empty<byte>();

        private bool _inlineIsCompressed = false;

        private bool _inlineIsIncompressable = false;

        public byte[] Data
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

        public void Compress()
        {
            if (Pointer < -1 || Pointer >= File._buffers.Count)
            {
                throw new IndexOutOfRangeException(nameof(Pointer));
            }

            if (Pointer == -1)
            {
                if (_inlineIsCompressed || _inlineIsIncompressable)
                {
                    return;
                }

                if (OodleLZHelper.CompressBuffer(_inlineBuffer, out _inlineBuffer) == OodleLZHelper.Status.Compressed)
                {
                    _inlineIsCompressed = true;
                }
                else
                {
                    _inlineIsIncompressable = true;
                }
                return;
            }

            File._buffers[Pointer].Compress();
        }

        public void Decompress()
        {
            if (Pointer < -1 || Pointer >= File._buffers.Count)
            {
                throw new IndexOutOfRangeException(nameof(Pointer));
            }

            if (Pointer == -1)
            {
                if (!_inlineIsCompressed)
                {
                    return;
                }

                OodleLZHelper.DecompressBuffer(_inlineBuffer, out _inlineBuffer);

                _inlineIsCompressed = false;
                return;
            }

            File._buffers[Pointer].Decompress();
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

            return Equals(Data, other.Data) && Pointer == other.Pointer;
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

        public override int GetHashCode() => HashCode.Combine(Data, Pointer);
    }
}
