using System.Text.Json.Serialization;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive
{
    public interface ICR2WProperty
    {
    }

    public interface ICR2WImport
    {
        public string DepotPath { get; }
        public ushort Flags { get; }
    }

    public interface ICR2WBuffer
    {
        public byte[] Data { get; set; }
        public uint Flags { get; set; }

        public bool IsCompressed { get; set; }
        public uint MemSize { get; set; }
    }

    public interface ICR2WEmbedded
    {
        public string ImportPath { get; set; }
        public IRedClass Export { get; set; }
    }

    public interface IEditableVariable
    {
        bool IsSerialized { get; set; }

        [JsonIgnore] int VarChunkIndex { get; set; }

        void Read(CR2WReader file, uint size);
    }
}
