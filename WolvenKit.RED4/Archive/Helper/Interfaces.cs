using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive;

public interface ICR2WProperty
{
}

public interface ICR2WImport : IRedImport
{
}

public interface ICR2WName
{
}

public interface ICR2WExport
{

}

public interface ICR2WEmbeddedFile
{
    public ResourcePath FileName { get; set; }
    public RedBaseClass Content { get; set; }
}

//public interface IEditableVariable
//{
//    bool IsSerialized { get; set; }

//    [JsonIgnore] int VarChunkIndex { get; set; }

//    void Read(CR2WReader file, uint size);
//}