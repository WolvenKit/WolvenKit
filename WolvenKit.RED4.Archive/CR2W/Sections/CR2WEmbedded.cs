using System.Runtime.InteropServices;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.CR2W
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct CR2WEmbeddedInfo
    {
        [FieldOffset(0)]
        public uint importIndex;

        [FieldOffset(4)]
        public uint chunkIndex;

        [FieldOffset(8)]
        public ulong pathHash;
    }

    public class CR2WEmbedded : ICR2WEmbeddedFile
    {
        public string FileName { get; set; }
        public RedBaseClass Content { get; set; }
    }
}
