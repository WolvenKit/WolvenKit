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
            var entry = new worldCookedGenericProxyMeshNode_Class1();

            var castedEntry = (worldCookedMeshNode_Class1)entry;
            ReadEntry(br, in castedEntry);

            entry.Unknown14 = br.ReadCUInt32();
            entry.Unknown15 = br.ReadCFloat();

            result.Unknown1.Add(entry);
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

        bw.BaseWriter.WriteVLQInt32(data.Unknown1.Count * 41);
        foreach (var entry in data.Unknown1)
        {
            var castedEntry = (worldCookedMeshNode_Class1)entry;
            WriteEntry(bw, castedEntry);

            bw.Write(entry.Unknown14);
            bw.Write(entry.Unknown15);
        }

        bw.BaseWriter.Flush();
        ms.Flush();

        Buffer.Buffer.SetBytes(ms.ToArray());
    }
}

public class worldCookedGenericProxyMeshNode_Buffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<worldCookedGenericProxyMeshNode_Class1> Unknown1 { get; set; } = new();
}

public class worldCookedGenericProxyMeshNode_Class1 : worldCookedMeshNode_Class1
{
    [RED("unknown14")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 Unknown14
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("unknown15")]
    [REDProperty(IsIgnored = true)]
    public CFloat Unknown15
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }
}
