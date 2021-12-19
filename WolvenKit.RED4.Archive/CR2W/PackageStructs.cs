using System;
using System.Runtime.InteropServices;

namespace WolvenKit.RED4.Archive.CR2W
{

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct PackageHeader
    {
        [FieldOffset(0)]
        public ushort uk1;

        [FieldOffset(2)]
        public ushort numSections;

        [FieldOffset(4)]
        public uint numCruids0;

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
    public struct PackageImportHeader
    {
        [FieldOffset(0)]
        public uint bitfield;

        private const int sizeShift = 23;
        private const uint offsetMask = (1U << sizeShift) - 1U;
        private const uint sizeMask = 0xFF << (sizeShift);
        private const int unkShift = 31;

        public uint offset
        {
            get
            {
                return bitfield & offsetMask;
            }
            set
            {
                bitfield &= ~offsetMask;
                bitfield |= value & offsetMask;
            }
        }

        public byte size
        {
            get
            {
                return (byte)((bitfield & sizeMask) >> sizeShift);
            }
            set
            {
                bitfield &= ~sizeMask;
                bitfield |= ((uint)value << sizeShift) & sizeMask;
            }
        }

        public bool unk1
        {
            get
            {
                return Convert.ToBoolean(bitfield >> unkShift);
            }
            set
            {
                bitfield &= ~(1U << unkShift);
                bitfield |= Convert.ToUInt32(value) << unkShift;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct PackageNameHeader
    {
        [FieldOffset(0)]
        public uint bitfield;

        private const int sizeShift = 24;
        private const uint offsetMask = (1U << sizeShift) - 1U;
        private const uint sizeMask = 0xFF << (sizeShift - 1);

        public uint offset
        {
            get
            {
                return bitfield & offsetMask;
            }
            set
            {
                bitfield &= ~offsetMask;
                bitfield |= value & offsetMask;
            }
        }

        public byte size
        {
            get
            {
                return (byte)((bitfield & sizeMask) >> sizeShift);
            }
            set
            {
                bitfield &= ~sizeMask;
                bitfield |= ((uint)value << sizeShift) & sizeMask;
            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct PackageChunkHeader
    {
        [FieldOffset(0)]
        public uint typeID;

        [FieldOffset(4)]
        public uint offset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct PackageFieldHeader
    {
        [FieldOffset(0)]
        public ushort nameID;

        [FieldOffset(2)]
        public ushort typeID;

        [FieldOffset(4)]
        public uint offset;
    }
}
