using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W
{
    #region Header Structs
    [DataContract(Namespace = "")]
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct CR2WFileHeader
    {
        [DataMember]
        [FieldOffset(0)]
        public uint version;

        [DataMember]
        [FieldOffset(4)]
        public uint flags;

        [DataMember]
        [FieldOffset(8)]
        public ulong timeStamp;

        [DataMember]
        [FieldOffset(16)]
        public uint buildVersion;

        [DataMember]
        [FieldOffset(20)]
        public uint fileSize;

        [DataMember]
        [FieldOffset(24)]
        public uint bufferSize;

        [DataMember]
        [FieldOffset(28)]
        public uint crc32;

        [DataMember]
        [FieldOffset(32)]
        public uint numChunks;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct CR2WTable
    {
        [FieldOffset(0)]
        public uint offset;

        [FieldOffset(4)]
        public uint itemCount;

        [FieldOffset(8)]
        public uint crc32;
    }

    
    #endregion

}
