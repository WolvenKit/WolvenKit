using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using RED.CRC32;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.CR2W
{
    #region Header Structs
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct CR2WFileHeader
    {
        [FieldOffset(0)]
        public uint version;

        [FieldOffset(4)]
        public uint flags;

        [FieldOffset(8)]
        public ulong timeStamp;

        [FieldOffset(16)]
        public uint buildVersion;

        [FieldOffset(20)]
        public uint fileSize;

        [FieldOffset(24)]
        public uint bufferSize;

        [FieldOffset(28)]
        public uint crc32;

        [FieldOffset(32)]
        public uint numChunks;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct CR2WTableHeader
    {
        [FieldOffset(0)]
        public uint offset;

        [FieldOffset(4)]
        public uint size;

        [FieldOffset(8)]
        public uint crc32;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct CR2WName
    {
        [FieldOffset(0)]
        public uint value;

        [FieldOffset(4)]
        public uint hash;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct CR2WImportHeader
    {
        [FieldOffset(0)]
        public uint depotPath;

        [FieldOffset(4)]
        public ushort className;

        [FieldOffset(6)]
        public ushort flags;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct CR2WTable4Item
    {
        [FieldOffset(0)]
        public ushort className;

        [FieldOffset(2)]
        public ushort classFlags;

        [FieldOffset(4)]
        public ushort propertyName;

        [FieldOffset(6)]
        public ushort propertyFlags;

        [FieldOffset(8)]
        public ulong hash;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct CR2WExportHeader
    {
        [FieldOffset(0)]
        public ushort className;

        [FieldOffset(2)]
        public ushort objectFlags;

        [FieldOffset(4)]
        public uint parentID;

        [FieldOffset(8)]
        public uint dataSize;

        [FieldOffset(12)]
        public uint dataOffset;

        [FieldOffset(16)]
        public uint template;

        [FieldOffset(20)]
        public uint crc32;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct CR2WBufferHeader
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

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct CR2WEmbeddedHeader
    {
        [FieldOffset(0)]
        public uint importIndex;

        [FieldOffset(4)]
        public uint path;

        [FieldOffset(8)]
        public ulong pathHash;

        [FieldOffset(16)]
        public uint dataOffset;

        [FieldOffset(20)]
        public uint dataSize;
    }
    #endregion

}
