using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types
{
    public class BufferHandler
    {
        private Red4File _file;

        private readonly Dictionary<int, List<IRedPrimitive>> _refList = new();

        internal BufferHandler(Red4File red4File)
        {
            _file = red4File;
        }

        public DataBuffer CreateDataBuffer(uint flags, byte[] data, bool inline = false)
        {
            var existingBuffer = GetIndex(data);
            if (existingBuffer != -1)
            {
                return new DataBuffer(_file, existingBuffer);
            }

            if (inline)
            {
                return new DataBuffer { Data = data };
            }

            _file._buffers.Add(RedBuffer.CreateBuffer(flags, data));
            return new DataBuffer(_file, _file._buffers.Count - 1);
        }

        public SerializationDeferredDataBuffer CreateSerializationDeferredDataBuffer(uint flags, byte[] data, bool inline = false)
        {
            var existingBuffer = GetIndex(data);
            if (existingBuffer != -1)
            {
                return new SerializationDeferredDataBuffer(_file, (ushort)existingBuffer);
            }

            _file._buffers.Add(RedBuffer.CreateBuffer(flags, data));
            return new SerializationDeferredDataBuffer(_file, (ushort)(_file._buffers.Count - 1));
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

        public void Register(ushort pointer, SerializationDeferredDataBuffer serializationDeferredDataBuffer)
        {
            if (!_refList.ContainsKey(pointer))
            {
                _refList.Add(pointer, new());
            }

            _refList[pointer].Add(serializationDeferredDataBuffer);
        }

        public void Register(int pointer, DataBuffer dataBuffer)
        {
            if (!_refList.ContainsKey(pointer))
            {
                _refList.Add(pointer, new());
            }

            _refList[pointer].Add(dataBuffer);
        }

        public RedBuffer.BufferType GetBufferType(int index)
        {
            if (_refList[index][0] is DataBuffer)
            {
                return RedBuffer.BufferType.DataBuffer;
            }

            if (_refList[index][0] is SerializationDeferredDataBuffer)
            {
                return RedBuffer.BufferType.SerializationDeferredDataBuffer;
            }

            throw new Exception();
        }
    }
}
