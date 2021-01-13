using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace CP77.CR2W
{
    /// IMPORT FLAGS
    [System.Flags]
    public enum EBufferFlags
    {
        
    };
    
    
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct CR2WBuffer
    {
        //TODO
        [FieldOffset(0)]
        public uint flags;

        /// <summary>
        /// index
        /// </summary>
        [FieldOffset(4)]
        public uint index;

        /// <summary>
        /// offset inside a cr2w file, buffers are compressed and appended to a cr2w file
        /// </summary>
        [FieldOffset(8)]
        public uint offset;

        /// <summary>
        /// This is the compressed size of the buffer
        /// it's called disksize because buffers are compressed and appended to a cr2w file
        /// </summary>
        [FieldOffset(12)]
        public uint diskSize;    

        /// <summary>
        /// This is the uncompressed size of the buffer
        /// it's called memSize because buffers are uncompressed at runtime in the game
        /// </summary>
        [FieldOffset(16)]
        public uint memSize;
        
        /// <summary>
        /// crc32 over the compressed buffer
        /// </summary>
        [FieldOffset(20)]
        public uint crc32;
    }
    
    public class CR2WBufferWrapper
    {
        private CR2WBuffer _buffer;
        public CR2WBuffer Buffer {
            get => _buffer;
            set => _buffer = value;
        }
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
            return Buffer.index.ToString();
        }
    }
}