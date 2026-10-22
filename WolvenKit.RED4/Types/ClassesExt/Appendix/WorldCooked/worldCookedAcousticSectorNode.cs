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
            var entry = new worldCookedAcousticSectorNode_Class1();

            entry.Unknown1 = new CResourceAsyncReference<worldAcousticDataResource>(br.BaseReader.ReadUInt64());
            entry.Unknown2 = br.ReadCUInt32();
            entry.Unknown3 = br.ReadCUInt32();
            entry.Unknown4 = br.ReadCUInt32();
            entry.Unknown5 = br.ReadCUInt8();

            result.Unknown1.Add(entry);
        }

        result.Unknown2 = br.ReadCUInt32();

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

        bw.BaseWriter.WriteVLQInt32(data.Unknown1.Count * 21);
        foreach (var entry in data.Unknown1)
        {
            bw.BaseWriter.Write((ulong)entry.Unknown1.DepotPath);
            bw.Write(entry.Unknown2);
            bw.Write(entry.Unknown3);
            bw.Write(entry.Unknown4);
            bw.Write(entry.Unknown5);
        }
        bw.Write(data.Unknown2);

        bw.BaseWriter.Flush();
        ms.Flush();

        Buffer.Buffer.SetBytes(ms.ToArray());
    }
}

public class worldCookedAcousticSectorNode_Buffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<worldCookedAcousticSectorNode_Class1> Unknown1 { get; set; } = new();
    public CUInt32 Unknown2 { get; set; }
}

public class worldCookedAcousticSectorNode_Class1 : RedBaseClass
{
    [RED("unknown1")]
    [REDProperty(IsIgnored = true)]
    public CResourceAsyncReference<worldAcousticDataResource> Unknown1
    {
        get => GetPropertyValue<CResourceAsyncReference<worldAcousticDataResource>>();
        set => SetPropertyValue<CResourceAsyncReference<worldAcousticDataResource>>(value);
    }

    [RED("unknown2")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 Unknown2
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("unknown3")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 Unknown3
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("unknown4")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 Unknown4
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("unknown5")]
    [REDProperty(IsIgnored = true)]
    public CUInt8 Unknown5
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }
}
