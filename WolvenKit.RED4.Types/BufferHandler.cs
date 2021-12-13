using System;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    public class BufferHandler
    {
        private Red4File _file;

        internal BufferHandler(Red4File red4File)
        {
            _file = red4File;
        }

        public DataBuffer CreateDataBuffer(uint flags, byte[] data, bool inline = false)
        {
            var existingBuffer = GetIndex(data);
            if (existingBuffer != -1)
            {
                return new DataBuffer { File = _file, Pointer = existingBuffer };
            }

            if (inline)
            {
                return new DataBuffer { File = _file, Data = data };
            }

            _file._buffers.Add(RedBuffer.CreateBuffer(flags, data));
            return new DataBuffer { File = _file, Pointer = _file._buffers.Count - 1 };
        }

        public SerializationDeferredDataBuffer CreateSerializationDeferredDataBuffer(uint flags, byte[] data, bool inline = false)
        {
            var existingBuffer = GetIndex(data);
            if (existingBuffer != -1)
            {
                return new SerializationDeferredDataBuffer { File = _file, Pointer = (ushort)existingBuffer };
            }

            _file._buffers.Add(RedBuffer.CreateBuffer(flags, data));
            return new SerializationDeferredDataBuffer { File = _file, Pointer = (ushort)(_file._buffers.Count - 1) };
        }

        internal int GetIndex(byte[] data)
        {
            for (int i = 0; i < _file._buffers.Count; i++)
            {
                if (data.SequenceEqual(_file._buffers[i].Data))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
