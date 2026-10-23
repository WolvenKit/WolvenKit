using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class worldCookedGenericProxyMeshNode
{
    public override void LoadData(RedBaseClass cls)
    {
        if (cls is not worldStreamingSector wss)
        {
            throw new Exception();
        }

        var result = new worldCookedGenericProxyMeshNode_Buffer();

        //var relatedNodes = GetRelatedNodes(wss);

        using var ms = new MemoryStream(Buffer.Buffer.GetBytes());
        using var br = new Red4Reader(ms);

        var size = br.BaseReader.ReadVLQInt32();

        var count = size / 41;
        for (var i = 0; i < count; i++)
        {
            var entry = new worldCookedGenericProxyMeshNodeInner();

            var castedEntry = (worldCookedMeshNodeInner)entry;
            ReadEntry(br, in castedEntry);

            entry.NbNodesUnderProxy = br.ReadCUInt32();
            entry.NearAutoHideDistance = br.ReadCFloat();

            result.InnerNodes.Add(entry);
        }

        Buffer.Data = result;
    }

    public override void StoreData()
    {
        if (Buffer.Data is not worldCookedGenericProxyMeshNode_Buffer data)
        {
            throw new Exception();
        }

        using var ms = new MemoryStream();
        using var bw = new Red4Writer(ms);

        bw.BaseWriter.WriteVLQInt32(data.InnerNodes.Count * 41);
        foreach (var entry in data.InnerNodes)
        {
            var castedEntry = (worldCookedMeshNodeInner)entry;
            WriteEntry(bw, castedEntry);

            bw.Write(entry.NbNodesUnderProxy);
            bw.Write(entry.NearAutoHideDistance);
        }

        bw.BaseWriter.Flush();
        ms.Flush();

        Buffer.Buffer.SetBytes(ms.ToArray());
    }
}

public class worldCookedGenericProxyMeshNode_Buffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<worldCookedGenericProxyMeshNodeInner> InnerNodes { get; set; } = new();
}

public class worldCookedGenericProxyMeshNodeInner : worldCookedMeshNodeInner
{
    [RED("nbNodesUnderProxy")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 NbNodesUnderProxy
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("nearAutoHideDistance")]
    [REDProperty(IsIgnored = true)]
    public CFloat NearAutoHideDistance
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }
}
