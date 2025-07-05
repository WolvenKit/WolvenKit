using System.Collections.Generic;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Conversion;

public class RedFileDto
{
    public RedFileDto()
    {

    }

    public RedFileDto(CR2WFile cr2w, bool writeFlat = false)
    {
        Data = cr2w;
        Header.ArchiveFileName = cr2w.MetaData.FileName;

        Header.DataType = DataTypes.CR2W;
        if (writeFlat)
        {
            Header.DataType = DataTypes.CR2WFlat;
        }
    }

    public List<RedBaseClass> GetChunkList()
    {
        var list = new List<RedBaseClass>();
        var comp = ReferenceEqualityComparer.Instance;
        if (Data is null)
        {
            return list;
        }
        foreach (var (propPath, value) in Data.RootChunk.GetEnumerator())
        {
            if (value is IRedBaseHandle handle)
            {
                var subCls = handle.GetValue().NotNull();
                if (!Contains(subCls))
                {
                    list.Add(subCls);
                }
            }
        }

        foreach (var embeddedFile in Data.EmbeddedFiles)
        {
            foreach (var (propPath, value) in embeddedFile.Content.GetEnumerator())
            {
                if (value is IRedBaseHandle handle)
                {
                    var subCls = handle.GetValue().NotNull();
                    if (!Contains(subCls))
                    {
                        list.Add(subCls);
                    }
                }
            }
        }

        return list;

        bool Contains(RedBaseClass cls)
        {
            foreach (var chunk in list)
            {
                if (comp.Equals(chunk, cls))
                {
                    return true;
                }
            }

            return false;
        }
    }

    public JsonHeader Header { get; set; } = new();
    public CR2WFile? Data { get; set; }
}
