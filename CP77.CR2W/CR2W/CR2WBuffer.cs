using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using WolvenKit.Common.Model.Cr2w;

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
    
    public class CR2WBufferWrapper : ICR2WBuffer
    {
        #region ctor

        public CR2WBufferWrapper()
        {
            _buffer = new CR2WBuffer();
        }

        public CR2WBufferWrapper(CR2WBuffer buffer)
        {
            _buffer = buffer;
        }

        #endregion

        private CR2WBuffer _buffer;
        public CR2WBuffer Buffer => _buffer;

        #region properties

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

        private byte[] _data;

        #endregion


        #region methods

        public void SetOffset(uint v) => _buffer.offset = v;

        public void ReadData(BinaryReader file)
        {
            file.BaseStream.Seek(_buffer.offset, SeekOrigin.Begin);
            _data = file.ReadBytes((int)_buffer.diskSize);
        }

        public void WriteData(BinaryWriter file)
        {
            _buffer.offset = (uint)file.BaseStream.Position;
            if (_data == null)
            {
                return;
            }

            file.Write(_data);
            _buffer.diskSize = (uint)_data.Length;
        }

        public override string ToString() => _buffer.index.ToString();

        #endregion
    }
}
