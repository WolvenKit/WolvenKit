using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class worldCookedAcousticSectorNode
{
    public override void LoadData(RedBaseClass cls)
    {
        if (cls is not worldStreamingSector wss)
        {
            throw new Exception();
        }

        var result = new worldCookedAcousticSectorNode_Buffer();

        //var relatedNodes = GetRelatedNodes(wss);

        using var ms = new MemoryStream(Buffer.Buffer.GetBytes());
        using var br = new Red4Reader(ms);

        var size = br.BaseReader.ReadVLQInt32();

        var count = size / 21;
        for (var i = 0; i < count; i++)
        {
            var entry = new worldCookedAcousticSectorNodeInner();

            entry.Data = new CResourceAsyncReference<worldAcousticDataResource>(br.BaseReader.ReadUInt64());
            entry.InSectorCoordsX = br.ReadCUInt32();
            entry.InSectorCoordsY = br.ReadCUInt32();
            entry.InSectorCoordsZ = br.ReadCUInt32();
            entry.EdgeMask = br.ReadCUInt8();

            result.InnerNodes.Add(entry);
        }

        result.GeneratorId = br.ReadCUInt32();

        Buffer.Data = result;
    }

    public override void StoreData()
    {
        if (Buffer.Data is not worldCookedAcousticSectorNode_Buffer data)
        {
            throw new Exception();
        }

        using var ms = new MemoryStream();
        using var bw = new Red4Writer(ms);

        bw.BaseWriter.WriteVLQInt32(data.InnerNodes.Count * 21);
        foreach (var entry in data.InnerNodes)
        {
            bw.BaseWriter.Write((ulong)entry.Data.DepotPath);
            bw.Write(entry.InSectorCoordsX);
            bw.Write(entry.InSectorCoordsY);
            bw.Write(entry.InSectorCoordsZ);
            bw.Write(entry.EdgeMask);
        }
        bw.Write(data.GeneratorId);

        bw.BaseWriter.Flush();
        ms.Flush();

        Buffer.Buffer.SetBytes(ms.ToArray());
    }
}

public class worldCookedAcousticSectorNode_Buffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<worldCookedAcousticSectorNodeInner> InnerNodes { get; set; } = new();
    public CUInt32 GeneratorId { get; set; }
}

public class worldCookedAcousticSectorNodeInner : RedBaseClass
{
    [RED("data")]
    [REDProperty(IsIgnored = true)]
    public CResourceAsyncReference<worldAcousticDataResource> Data
    {
        get => GetPropertyValue<CResourceAsyncReference<worldAcousticDataResource>>();
        set => SetPropertyValue<CResourceAsyncReference<worldAcousticDataResource>>(value);
    }

    [RED("inSectorCoordsX")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 InSectorCoordsX
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("inSectorCoordsY")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 InSectorCoordsY
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("inSectorCoordsZ")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 InSectorCoordsZ
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("edgeMask")]
    [REDProperty(IsIgnored = true)]
    public CUInt8 EdgeMask
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }
}
