using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace WolvenKit.CR2W
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct CR2WName
    {
        [FieldOffset(0)]
        public uint value;

        [FieldOffset(4)]
        public uint hash;
    }

   
}