using System;

namespace WolvenKit.RED4.Types
{
    public interface IRedOverload
    {
        internal void ConstructorOverload();
    }

    public interface IRedBuffer
    {
        public uint Flags { get; }
        public byte[] Bytes { get; }
        public uint MemSize { get; set; }
        public bool IsCompressed { get; }

        public IParseableBuffer Data { get; set; }
    }
}
