using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class worldCookedStaticMeshNode
{
    public override void LoadData(RedBaseClass cls)
    {
        if (cls is not worldStreamingSector wss)
        {
            throw new Exception();
        }

        var result = new worldCookedStaticMeshNode_Buffer();

        //var relatedNodes = GetRelatedNodes(wss);

        using var ms = new MemoryStream(Buffer.Buffer.GetBytes());
        using var br = new Red4Reader(ms);

        var size = br.BaseReader.ReadVLQInt32();

        var count = size / 33;
        for (var i = 0; i < count; i++)
        {
            var entry = new worldCookedGenericProxyMeshNodeInner();

            var cookedMeshNodeEntryData = (worldCookedMeshNodeInner)entry;
            ReadEntry(br, in cookedMeshNodeEntryData);

            result.InnerNodes.Add(entry);
        }

        Buffer.Data = result;
    }

    public override void StoreData()
    {
        if (Buffer.Data is not worldCookedStaticMeshNode_Buffer data)
        {
            throw new Exception();
        }

        using var ms = new MemoryStream();
        using var bw = new Red4Writer(ms);

        bw.BaseWriter.WriteVLQInt32(data.InnerNodes.Count * 33);
        foreach (var entry in data.InnerNodes)
        {
            var cookedMeshNodeEntryData = (worldCookedMeshNodeInner)entry;
            WriteEntry(bw, cookedMeshNodeEntryData);
        }

        bw.BaseWriter.Flush();
        ms.Flush();

        Buffer.Buffer.SetBytes(ms.ToArray());
    }
}

public class worldCookedStaticMeshNode_Buffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<worldCookedMeshNodeInner> InnerNodes { get; set; } = new();
}
