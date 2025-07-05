using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Pools;

namespace WolvenKit.RED4.Archive.CR2W;

public class CR2WFileInfo
{
    public CR2WFileHeader FileHeader { get; internal set; }

    public Dictionary<uint, string> StringDict { get; internal set; } = new();

    public CR2WNameInfo[] NameInfo { get; internal set; } = Array.Empty<CR2WNameInfo>();
    public CR2WImportInfo[] ImportInfo { get; internal set; } = Array.Empty<CR2WImportInfo>();
    public CR2WPropertyInfo[] PropertyInfo { get; internal set; } = Array.Empty<CR2WPropertyInfo>();
    public CR2WExportInfo[] ExportInfo { get; internal set; } = Array.Empty<CR2WExportInfo>();
    public CR2WBufferInfo[] BufferInfo { get; internal set; } = Array.Empty<CR2WBufferInfo>();
    public CR2WEmbeddedInfo[] EmbeddedInfo { get; internal set; } = Array.Empty<CR2WEmbeddedInfo>();

    public List<ICR2WImport> Imports { get; internal set; } = new();

    public List<ResourcePath> GetImports()
    {
        var result = new List<ResourcePath>();
        foreach (var importInfo in ImportInfo)
        {
            result.Add((ResourcePath)StringDict[importInfo.offset]);
        }

        return result;
    }
}