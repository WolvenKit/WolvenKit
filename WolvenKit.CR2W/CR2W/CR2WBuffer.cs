using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.CR2W
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct CR2WBuffer
    {
        [FieldOffset(0)]
        public uint flags;

        [FieldOffset(4)]
        public uint index;

        [FieldOffset(8)]
        public uint offset;

        [FieldOffset(12)]
        public uint diskSize;

        [FieldOffset(16)]
        public uint memSize;

        [FieldOffset(20)]
        public uint crc32;
    }
    
    public class CR2WBufferWrapper : ICR2WBuffer
    {
        private CR2WBuffer _buffer;
        public CR2WBuffer Buffer => _buffer;

        private byte[] _data;

        public byte[] Data {
            get => _data;
            set => _data = value;
        }

        public CR2WBufferWrapper()
        {
            _buffer = new CR2WBuffer();
        }

        public CR2WBufferWrapper(CR2WBuffer buffer)
        {
            _buffer = buffer;
        }

        public void SetOffset(uint offset) => _buffer.offset = offset;

        public uint Flags => _buffer.flags;

        public uint Index => _buffer.index;

        public uint Offset
        {
            get => _buffer.offset;
            set => _buffer.offset = value;
        }

        public uint DiskSize
        {
            get => _buffer.diskSize;
            set => _buffer.diskSize = value;
        }

        public uint MemSize
        {
            get => _buffer.memSize;
            set => _buffer.memSize = value;
        }

        public uint Crc32
        {
            get => _buffer.crc32;
            set => _buffer.crc32 = value;
        }

        public void ReadData(BinaryReader file)
        {
            file.BaseStream.Seek(_buffer.offset, SeekOrigin.Begin);
            Data = file.ReadBytes((int) _buffer.memSize);
        }

        public /*async Task*/ void ReadData(MemoryMappedFile mmf)
        {
            //await Task.Run(() =>
            //{
                using (MemoryMappedViewStream vs = mmf.CreateViewStream(_buffer.offset, _buffer.memSize, MemoryMappedFileAccess.Read))
                using (BinaryReader br = new BinaryReader(vs))
                {
                    Data = br.ReadBytes((int)_buffer.memSize);
                }
            //}
            //);
        }

        public void WriteData(BinaryWriter file)
        {
            _buffer.offset = (uint) file.BaseStream.Position;
            if (Data != null)
            {
                file.Write(Data);
                _buffer.memSize = (uint)Data.Length;
            }
            
        }

        public override string ToString()
        {
            return _buffer.index.ToString();
        }
    }
}
