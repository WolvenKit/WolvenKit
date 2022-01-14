using System.Runtime.InteropServices;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.CR2W
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct CR2WBufferInfo
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

    public class CR2WBuffer : ICR2WBuffer
    {
        public byte[] Bytes { get; set; }
        public uint Flags { get; set; }

        public bool IsCompressed { get; set; }
        public uint MemSize { get; set; }

        public IParseableBuffer Data { get; set; }
    }
}
