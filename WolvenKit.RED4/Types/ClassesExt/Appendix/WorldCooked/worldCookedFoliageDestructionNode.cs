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

        var result = new WorldCookedFoliageDestructionInfoBuffer();

        //var relatedNodes = GetRelatedNodes(wss);

        using var ms = new MemoryStream(Buffer.Buffer.GetBytes());
        using var br = new Red4Reader(ms);

        var size = br.BaseReader.ReadVLQInt32();

        var count = size / 64;
        for (var i = 0; i < count; i++)
        {
            var entry = new worldCookedFoliageDestructionNodeInfo();

            entry.Extents[0] = br.ReadCFloat();
            entry.Extents[1] = br.ReadCFloat();
            entry.Extents[2] = br.ReadCFloat();
            entry.Extents[3] = br.ReadCFloat();

            entry.SectorHash = br.ReadCUInt64();
            entry.DataOffset = br.ReadCUInt32();
            entry.NumActors = br.ReadCUInt16();
            entry.NumShapeInfos = br.ReadCUInt16();
            entry.NumShapePositions = br.ReadCUInt16();
            entry.NumShapeRotations = br.ReadCUInt16();
            entry.NumScales = br.ReadCUInt16();
            entry.NumMaterials = br.ReadCUInt16();
            entry.NumPresets = br.ReadCUInt16();
            entry.NumShapeIndices = br.ReadCUInt16();
            entry.NumMaterialIndices = br.ReadCUInt16();
            entry.Lod = br.ReadCUInt8();

            br.BaseReader.ReadByte(); // padding

            entry.FoliageResourceHash = br.ReadCUInt64();
            entry.PopulationIndex = br.ReadCUInt32();
            entry.DataVersion = br.ReadCUInt32();

            result.CollisionNodeInfos.Add(entry);
        }

        var count2 = br.BaseReader.ReadVLQInt32();
        for (var i = 0; i < count2; i++)
        {
            result.PopulationIndex.Add(br.ReadCUInt32());
        }

        result.DataVersion = br.ReadCUInt32();

        Buffer.Data = result;

        LoadCompiledData(result.CollisionNodeInfos);
    }

    public override void StoreData()
    {
        if (Buffer.Data is not WorldCookedFoliageDestructionInfoBuffer data)
        {
            throw new Exception();
        }

        StoreCompiledData(data.CollisionNodeInfos);

        using var ms = new MemoryStream();
        using var bw = new Red4Writer(ms);

        bw.BaseWriter.WriteVLQInt32(data.CollisionNodeInfos.Count * 64);
        foreach (var entry in data.CollisionNodeInfos)
        {
            var castedEntry = (worldCookedFoliageDestructionNodeInfo)entry;

            bw.Write(castedEntry.Extents[0]);
            bw.Write(castedEntry.Extents[1]);
            bw.Write(castedEntry.Extents[2]);
            bw.Write(castedEntry.Extents[3]);

            bw.Write(castedEntry.SectorHash);
            bw.Write(castedEntry.DataOffset);
            bw.Write(castedEntry.NumActors);
            bw.Write(castedEntry.NumShapeInfos);
            bw.Write(castedEntry.NumShapePositions);
            bw.Write(castedEntry.NumShapeRotations);
            bw.Write(castedEntry.NumScales);
            bw.Write(castedEntry.NumMaterials);
            bw.Write(castedEntry.NumPresets);
            bw.Write(castedEntry.NumShapeIndices);
            bw.Write(castedEntry.NumMaterialIndices);
            bw.Write(castedEntry.Lod);

            bw.BaseWriter.Write((byte)0); // padding

            bw.Write(castedEntry.FoliageResourceHash);
            bw.Write(castedEntry.PopulationIndex);
            bw.Write(castedEntry.DataVersion);
        }

        bw.BaseWriter.WriteVLQInt32(data.PopulationIndex.Count);
        foreach (var entry in data.PopulationIndex)
        {
            bw.Write(entry);
        }

        bw.Write(data.DataVersion);

        bw.BaseWriter.Flush();
        ms.Flush();

        Buffer.Buffer.SetBytes(ms.ToArray());
    }
}

public class WorldCookedFoliageDestructionInfoBuffer : worldCookedCollisionInfoBuffer
{
    public CArray<CUInt32> PopulationIndex { get; set; } = new();
    public CUInt32 DataVersion { get; set; }
}

public class worldCookedFoliageDestructionNodeInfo : worldCookedCollisionNodeInfo
{
    [RED("foliageResourceHash")]
    [REDProperty(IsIgnored = true)]
    public CUInt64 FoliageResourceHash
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [RED("populationIndex")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 PopulationIndex
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("dataVersion")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 DataVersion
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }
}

public class worldCookedFoliageDestructionNode_Class2
{

}
