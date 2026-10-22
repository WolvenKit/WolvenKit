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
            var entry = new worldCookedGenericProxyMeshNode_Class1();

            var cookedMeshNodeEntryData = (worldCookedMeshNode_Class1)entry;
            ReadEntry(br, in cookedMeshNodeEntryData);

            result.Unknown1.Add(entry);
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

        bw.BaseWriter.WriteVLQInt32(data.Unknown1.Count * 33);
        foreach (var entry in data.Unknown1)
        {
            var cookedMeshNodeEntryData = (worldCookedMeshNode_Class1)entry;
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

    public CArray<worldCookedMeshNode_Class1> Unknown1 { get; set; } = new();
}
