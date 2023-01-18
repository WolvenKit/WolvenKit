using System;
using System.Runtime.InteropServices;

namespace WolvenKit.RED4.Archive.Buffer
{

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct RedPackageHeader
    {
        [FieldOffset(0)]
        public ushort version;

        [FieldOffset(2)]
        public ushort numSections;

        [FieldOffset(4)]
        public uint numComponents;

        [FieldOffset(8)]
        public uint refPoolDescOffset;

        [FieldOffset(12)]
        public uint refPoolDataOffset;

        [FieldOffset(16)]
        public uint namePoolDescOffset;

        [FieldOffset(20)]
        public uint namePoolDataOffset;

        [FieldOffset(24)]
        public uint chunkDescOffset;

        [FieldOffset(28)]
        public uint chunkDataOffset;

        // need to process separtely
        //[FieldOffset(32)]
        //public ushort uk2;

        //[FieldOffset(34)]
        //public ushort numCruids1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct RedPackageImportHeader
    {
        [FieldOffset(0)]
        public uint bitfield;

        private const int sizeShift = 23;
        private const uint offsetMask = (1U << sizeShift) - 1U;
        private const uint sizeMask = 0xFF << (sizeShift);
        private const int syncShift = 31;

        public uint offset
        {
            get => bitfield & offsetMask;
            set
            {
                bitfield &= ~offsetMask;
                bitfield |= value & offsetMask;
            }
        }

        public byte size
        {
            get => (byte)((bitfield & sizeMask) >> sizeShift);
            set
            {
                bitfield &= ~sizeMask;
                bitfield |= ((uint)value << sizeShift) & sizeMask;
            }
        }

        public bool sync
        {
            get => Convert.ToBoolean(bitfield >> syncShift);
            set
            {
                bitfield &= ~(1U << syncShift);
                bitfield |= Convert.ToUInt32(value) << syncShift;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct RedPackageNameHeader
    {
        [FieldOffset(0)]
        private uint bitfield;

        private const int s_sizeShift = 24;
        private const uint s_offsetMask = 0x00FFFFFF;
        private const uint s_sizeMask   = 0xFF000000;

        public uint offset
        {
            get => bitfield & s_offsetMask;
            set
            {
                bitfield &= ~s_offsetMask;
                bitfield |= value & s_offsetMask;
            }
        }

        public byte size
        {
            get => (byte)((bitfield & s_sizeMask) >> s_sizeShift);
            set
            {
                bitfield &= ~s_sizeMask;
                bitfield |= ((uint)value << s_sizeShift) & s_sizeMask;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct RedPackageChunkHeader
    {
        [FieldOffset(0)]
        public uint typeID;

        [FieldOffset(4)]
        public uint offset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct RedPackageFieldHeader
    {
        [FieldOffset(0)]
        public ushort nameID;

        [FieldOffset(2)]
        public ushort typeID;

        [FieldOffset(4)]
        public uint offset;
    }
}
