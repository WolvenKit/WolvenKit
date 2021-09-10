using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.CR2W
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct CR2WChunkInfo
    {
        [FieldOffset(0)]
        public ushort className;        //needs to be registered upon new creation and updated on file write!   //done

        [FieldOffset(2)]
        public ushort objectFlags;      // 0 means uncooked, 8192 is cooked //TODO

        [FieldOffset(4)]
        public uint parentID;

        [FieldOffset(8)]
        public uint dataSize;           // created upon data write  //done

        [FieldOffset(12)]
        public uint dataOffset;         // created upon data write  //done

        [FieldOffset(16)]
        public uint template;           // can be 0 //TODO?

        [FieldOffset(20)]
        public uint crc32;              // created upon write   //done
    }
}
