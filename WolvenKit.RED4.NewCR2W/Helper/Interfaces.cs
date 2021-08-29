using System.Text.Json.Serialization;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.NewCR2W
{
    public interface ICR2WName
    {
        public string Str { get; }
    }

    public interface ICR2WImport
    {

    }

    public interface ICR2WExport
    {
        public IRedClass NewData { get; }

        public void ReadData(Red4ReaderExt file);
    }

    public interface ICR2WBuffer
    {
    }

    public interface ICR2WEmbedded
    {
    }

    public interface IEditableVariable
    {
        bool IsSerialized { get; set; }

        [JsonIgnore] int VarChunkIndex { get; set; }

        void Read(Red4ReaderExt file, uint size);
    }
}
