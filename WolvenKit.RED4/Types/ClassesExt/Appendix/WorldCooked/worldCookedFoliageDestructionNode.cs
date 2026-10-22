using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class worldCookedFoliageDestructionNode
{
    public override void LoadData(RedBaseClass cls)
    {
        if (cls is not worldStreamingSector wss)
        {
            throw new Exception();
        }

        var result = new worldCookedFoliageDestructionNode_Buffer();

        //var relatedNodes = GetRelatedNodes(wss);

        using var ms = new MemoryStream(Buffer.Buffer.GetBytes());
        using var br = new Red4Reader(ms);

        var size = br.BaseReader.ReadVLQInt32();

        var count = size / 64;
        for (var i = 0; i < count; i++)
        {
            var entry = new worldCookedFoliageDestructionNode_Class1();

            entry.Unknown1[0] = br.ReadCFloat();
            entry.Unknown1[1] = br.ReadCFloat();
            entry.Unknown1[2] = br.ReadCFloat();
            entry.Unknown1[3] = br.ReadCFloat();

            entry.Unknown2 = br.ReadCUInt64();
            entry.Unknown3 = br.ReadCUInt32();
            entry.Unknown4 = br.ReadCUInt16();
            entry.Unknown5 = br.ReadCUInt16();
            entry.Unknown6 = br.ReadCUInt16();
            entry.Unknown7 = br.ReadCUInt16();
            entry.Unknown8 = br.ReadCUInt16();
            entry.Unknown9 = br.ReadCUInt16();
            entry.Unknown10 = br.ReadCUInt16();
            entry.Unknown11 = br.ReadCUInt16();
            entry.Unknown12 = br.ReadCUInt16();
            entry.Unknown13 = br.ReadCUInt8();

            br.BaseReader.ReadByte(); // padding

            entry.Unknown14 = br.ReadCUInt64();
            entry.Unknown15 = br.ReadCUInt32();
            entry.Unknown16 = br.ReadCUInt32();

            result.Unknown1.Add(entry);
        }

        var count2 = br.BaseReader.ReadVLQInt32();
        for (var i = 0; i < count2; i++)
        {
            result.Unknown2.Add(br.ReadCUInt32());
        }

        result.Unknown3 = br.ReadCUInt32();

        Buffer.Data = result;

        LoadCompiledData(result.Unknown1);
    }

    public override void StoreData()
    {
        if (Buffer.Data is not worldCookedFoliageDestructionNode_Buffer data)
        {
            throw new Exception();
        }

        StoreCompiledData(data.Unknown1);

        using var ms = new MemoryStream();
        using var bw = new Red4Writer(ms);

        bw.BaseWriter.WriteVLQInt32(data.Unknown1.Count * 64);
        foreach (var entry in data.Unknown1)
        {
            var castedEntry = (worldCookedFoliageDestructionNode_Class1)entry;

            bw.Write(castedEntry.Unknown1[0]);
            bw.Write(castedEntry.Unknown1[1]);
            bw.Write(castedEntry.Unknown1[2]);
            bw.Write(castedEntry.Unknown1[3]);

            bw.Write(castedEntry.Unknown2);
            bw.Write(castedEntry.Unknown3);
            bw.Write(castedEntry.Unknown4);
            bw.Write(castedEntry.Unknown5);
            bw.Write(castedEntry.Unknown6);
            bw.Write(castedEntry.Unknown7);
            bw.Write(castedEntry.Unknown8);
            bw.Write(castedEntry.Unknown9);
            bw.Write(castedEntry.Unknown10);
            bw.Write(castedEntry.Unknown11);
            bw.Write(castedEntry.Unknown12);
            bw.Write(castedEntry.Unknown13);

            bw.BaseWriter.Write((byte)0); // padding

            bw.Write(castedEntry.Unknown14);
            bw.Write(castedEntry.Unknown15);
            bw.Write(castedEntry.Unknown16);
        }

        bw.BaseWriter.WriteVLQInt32(data.Unknown2.Count);
        foreach (var entry in data.Unknown2)
        {
            bw.Write(entry);
        }

        bw.Write(data.Unknown3);

        bw.BaseWriter.Flush();
        ms.Flush();

        Buffer.Buffer.SetBytes(ms.ToArray());
    }
}

public class worldCookedFoliageDestructionNode_Buffer : worldCookedCollisionNode_Buffer
{
    public CArray<CUInt32> Unknown2 { get; set; } = new();
    public CUInt32 Unknown3 { get; set; }
}

public class worldCookedFoliageDestructionNode_Class1 : worldCookedCollisionNode_Class1
{
    [RED("unknown14")]
    [REDProperty(IsIgnored = true)]
    public CUInt64 Unknown14
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [RED("unknown15")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 Unknown15
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("unknown16")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 Unknown16
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }
}

public class worldCookedFoliageDestructionNode_Class2
{

}
