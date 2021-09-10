using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.CR2W
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct CR2WNameInfo
    {
        [FieldOffset(0)]
        public uint offset;

        [FieldOffset(4)]
        public uint hash;
    }
}
