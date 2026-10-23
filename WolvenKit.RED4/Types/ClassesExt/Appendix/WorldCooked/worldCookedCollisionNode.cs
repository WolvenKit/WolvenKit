using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types;

public partial class worldCookedCollisionNode
{
    public override void LoadData(RedBaseClass cls)
    {
        if (cls is not worldStreamingSector wss)
        {
            throw new Exception();
        }

        var result = new worldCookedCollisionInfoBuffer();

        //var relatedNodes = GetRelatedNodes(wss);

        using var ms = new MemoryStream(Buffer.Buffer.GetBytes());
        using var br = new Red4Reader(ms);

        var size = br.BaseReader.ReadVLQInt32();

        var count = size / 48;
        for (var i = 0; i < count; i++)
        {
            var entry = new worldCookedCollisionNodeInfo();

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

            result.CollisionNodeInfos.Add(entry);
        }

        Buffer.Data = result;

        LoadCompiledData(result.CollisionNodeInfos);
    }

    protected void LoadCompiledData(CArray<worldCookedCollisionNodeInfo> infos)
    {
        using var ms = new MemoryStream(CompiledData.Buffer.GetBytes());
        using var br = new Red4Reader(ms);

        var result = new worldCookedCollisionNodeBuffer();

        foreach (var info in infos)
        {
            if (br.BaseStream.Position != info.DataOffset)
            {
                return;
            }

            var entry = new worldCookedCollisionInnerNode();

            for (var i = 0; i < info.NumActors; i++)
            {
                var subEntry = new worldCookedCollisionActor();

                subEntry.Transform.Position.X.Bits = br.ReadCInt32();
                subEntry.Transform.Position.Y.Bits = br.ReadCInt32();
                subEntry.Transform.Position.Z.Bits = br.ReadCInt32();
                br.BaseReader.ReadBytes(4); // padding

                subEntry.Transform.Orientation.I = br.ReadCFloat();
                subEntry.Transform.Orientation.J = br.ReadCFloat();
                subEntry.Transform.Orientation.K = br.ReadCFloat();
                subEntry.Transform.Orientation.R = br.ReadCFloat();

                subEntry.ShapeStartIndex = br.ReadCUInt16();
                subEntry.ShapeCount = br.ReadCUInt16();
                subEntry.ScaleIndex = br.ReadCInt16();
                subEntry.Uk1 = br.ReadCUInt8();
                br.BaseReader.ReadBytes(9); // padding

                entry.Actors.Add(subEntry);
            }

            for (var i = 0; i < info.NumShapeInfos; i++)
            {
                var subEntry = new worldCookedCollisionShape();

                subEntry.CollisionSourceKey.Pe = br.ReadCUInt8();

                for (var j = 0; j < 12; j++)
                {
                    subEntry.CollisionSourceKey.Ta[j] = br.ReadCUInt8();
                }
                br.BaseReader.ReadBytes(3); // padding

                subEntry.Index = br.ReadCUInt16();
                subEntry.MaterialCount = br.ReadCUInt16();
                subEntry.ShapePositionIndex = br.ReadCInt16();
                subEntry.ShapeRotationIndex = br.ReadCInt16();
                subEntry.ShapePresetIndex = br.ReadCUInt8();
                subEntry.ProxyType = br.ReadCUInt8();
                br.BaseReader.ReadBytes(6); // padding

                entry.Shapes.Add(subEntry);
            }

            for (var i = 0; i < info.NumShapePositions; i++)
            {
                var subEntry = new Vector3();

                subEntry.X = br.ReadCFloat();
                subEntry.Y = br.ReadCFloat();
                subEntry.Z = br.ReadCFloat();

                entry.ShapePositions.Add(subEntry);
            }

            for (var i = 0; i < info.NumShapeRotations; i++)
            {
                var subEntry = new Quaternion();

                subEntry.I = br.ReadCFloat();
                subEntry.J = br.ReadCFloat();
                subEntry.K = br.ReadCFloat();
                subEntry.R = br.ReadCFloat();

                entry.ShapeRotations.Add(subEntry);
            }

            for (var i = 0; i < info.NumScales; i++)
            {
                var subEntry = new Vector3();

                subEntry.X = br.ReadCFloat();
                subEntry.Y = br.ReadCFloat();
                subEntry.Z = br.ReadCFloat();

                entry.Scales.Add(subEntry);
            }

            for (var i = 0; i < info.NumMaterials; i++)
            {
                entry.Materials.Add((CName)br.BaseReader.ReadUInt64());
            }

            for (var i = 0; i < info.NumPresets; i++)
            {
                entry.Presets.Add((CName)br.BaseReader.ReadUInt64());
            }

            for (var i = 0; i < info.NumShapeIndices; i++)
            {
                entry.ShapeIndices.Add(br.ReadCUInt32());
            }

            for (var i = 0; i < info.NumMaterialIndices; i++)
            {
                entry.MaterialIndices.Add(br.ReadCUInt8());
            }

            var paddingLen = ((ms.Position + 15U) & (~15)) - ms.Position;
            br.BaseReader.ReadBytes((int)paddingLen); // padding to 16 bytes

            result.CollisionNodes.Add(entry);
        }

        CompiledData.Data = result;
    }

    public override void StoreData()
    {
        if (Buffer.Data is not worldCookedCollisionInfoBuffer data)
        {
            throw new Exception();
        }

        StoreCompiledData(data.CollisionNodeInfos);

        using var ms = new MemoryStream();
        using var bw = new Red4Writer(ms);

        bw.BaseWriter.WriteVLQInt32(data.CollisionNodeInfos.Count * 48);
        foreach (var entry in data.CollisionNodeInfos)
        {
            bw.Write(entry.Extents[0]);
            bw.Write(entry.Extents[1]);
            bw.Write(entry.Extents[2]);
            bw.Write(entry.Extents[3]);

            bw.Write(entry.SectorHash);
            bw.Write(entry.DataOffset);
            bw.Write(entry.NumActors);
            bw.Write(entry.NumShapeInfos);
            bw.Write(entry.NumShapePositions);
            bw.Write(entry.NumShapeRotations);
            bw.Write(entry.NumScales);
            bw.Write(entry.NumMaterials);
            bw.Write(entry.NumPresets);
            bw.Write(entry.NumShapeIndices);
            bw.Write(entry.NumMaterialIndices);
            bw.Write(entry.Lod);

            bw.BaseWriter.Write((byte)0); // padding
        }

        bw.BaseWriter.Flush();
        ms.Flush();

        Buffer.Buffer.SetBytes(ms.ToArray());
    }

    protected void StoreCompiledData(CArray<worldCookedCollisionNodeInfo> infos)
    {
        if(CompiledData.Data is not worldCookedCollisionNodeBuffer data)
        {
            throw new Exception();
        }

        if (infos.Count != data.CollisionNodes.Count)
        {
            throw new Exception("Mismatch between collision node infos and compiled data entries count.");
        }

        using var ms = new MemoryStream();
        using var bw = new Red4Writer(ms);

        for (var i = 0; i < data.CollisionNodes.Count; i++)
        {
            var entry = data.CollisionNodes[i];

            var paddingLen = ((ms.Position + 15U) & (~15)) - ms.Position;
            bw.BaseWriter.Write(new byte[paddingLen]); // padding to 16 bytes

            infos[i].DataOffset = (CUInt32)bw.BaseStream.Position;

            infos[i].NumActors = (CUInt16)entry.Actors.Count;
            foreach (var actor in entry.Actors)
            {
                bw.Write(actor.Transform.Position.X.Bits);
                bw.Write(actor.Transform.Position.Y.Bits);
                bw.Write(actor.Transform.Position.Z.Bits);
                bw.BaseWriter.Write(new byte[4]); // padding

                bw.Write(actor.Transform.Orientation.I);
                bw.Write(actor.Transform.Orientation.J);
                bw.Write(actor.Transform.Orientation.K);
                bw.Write(actor.Transform.Orientation.R);

                bw.Write(actor.ShapeStartIndex);
                bw.Write(actor.ShapeCount);
                bw.Write(actor.ScaleIndex);
                bw.Write(actor.Uk1);
                bw.BaseWriter.Write(new byte[9]); // padding
            }

            infos[i].NumShapeInfos = (CUInt16)entry.Shapes.Count;
            foreach (var shapeInfo in entry.Shapes)
            {
                bw.Write(shapeInfo.CollisionSourceKey.Pe);
                foreach (var ta in shapeInfo.CollisionSourceKey.Ta)
                {
                    bw.Write(ta);
                }

                bw.BaseWriter.Write(new byte[3]); // padding

                bw.Write(shapeInfo.Index);
                bw.Write(shapeInfo.MaterialCount);
                bw.Write(shapeInfo.ShapePositionIndex);
                bw.Write(shapeInfo.ShapeRotationIndex);
                bw.Write(shapeInfo.ShapePresetIndex);
                bw.Write(shapeInfo.ProxyType);
                bw.BaseWriter.Write(new byte[6]); // padding
            }

            infos[i].NumShapePositions = (CUInt16)entry.ShapePositions.Count;
            foreach (var shapePosition in entry.ShapePositions)
            {
                bw.Write(shapePosition.X);
                bw.Write(shapePosition.Y);
                bw.Write(shapePosition.Z);
            }

            infos[i].NumShapeRotations = (CUInt16)entry.ShapeRotations.Count;
            foreach (var shapeRotation in entry.ShapeRotations)
            {
                bw.Write(shapeRotation.I);
                bw.Write(shapeRotation.J);
                bw.Write(shapeRotation.K);
                bw.Write(shapeRotation.R);
            }

            infos[i].NumScales = (CUInt16)entry.Scales.Count;
            foreach (var scale in entry.Scales)
            {
                bw.Write(scale.X);
                bw.Write(scale.Y);
                bw.Write(scale.Z);
            }

            infos[i].NumMaterials = (CUInt16)entry.Materials.Count;
            foreach (var material in entry.Materials)
            {
                bw.BaseWriter.Write((ulong)material);
            }

            infos[i].NumPresets = (CUInt16)entry.Presets.Count;
            foreach (var preset in entry.Presets)
            {
                bw.BaseWriter.Write((ulong)preset);
            }

            infos[i].NumShapeIndices = (CUInt16)entry.ShapeIndices.Count;
            foreach (var shapeIndex in entry.ShapeIndices)
            {
                bw.Write(shapeIndex);
            }

            infos[i].NumMaterialIndices = (CUInt16)entry.MaterialIndices.Count;
            foreach (var materialIndex in entry.MaterialIndices)
            {
                bw.Write(materialIndex);
            }
        }

        bw.BaseWriter.Flush();
        ms.Flush();

        CompiledData.Buffer.SetBytes(ms.ToArray());
    }
}

public class worldCookedCollisionInfoBuffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<worldCookedCollisionNodeInfo> CollisionNodeInfos { get; set; } = new();
}

public class worldCookedCollisionNodeInfo : RedBaseClass
{
    [RED("extents", 4)]
    [REDProperty(IsIgnored = true)]
    public CArrayFixedSize<CFloat> Extents
    {
        get => GetPropertyValue<CArrayFixedSize<CFloat>>();
        set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
    }

    [RED("sectorHash")]
    [REDProperty(IsIgnored = true)]
    public CUInt64 SectorHash
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [RED("dataOffset")]
    [REDProperty(IsIgnored = true)]
    public CUInt32 DataOffset
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("numActors")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 NumActors
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("numShapeInfos")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 NumShapeInfos
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("numShapePositions")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 NumShapePositions
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("numShapeRotations")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 NumShapeRotations
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("numScales")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 NumScales
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("numMaterials")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 NumMaterials
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("numPresets")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 NumPresets
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("numShapeIndices")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 NumShapeIndices
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("numMaterialIndices")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 NumMaterialIndices
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("lod")]
    [REDProperty(IsIgnored = true)]
    public CUInt8 Lod
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }

    public worldCookedCollisionNodeInfo()
    {
        Extents = new CArrayFixedSize<CFloat>(4);
    }
}

public class worldCookedCollisionNodeBuffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<worldCookedCollisionInnerNode> CollisionNodes { get; set; } = new();
}

public class worldCookedCollisionInnerNode : RedBaseClass
{
    [RED("actors")]
    [REDProperty(IsIgnored = true)]
    public CArray<worldCookedCollisionActor> Actors
    {
        get => GetPropertyValue<CArray<worldCookedCollisionActor>>();
        set => SetPropertyValue<CArray<worldCookedCollisionActor>>(value);
    }

    [RED("shapes")]
    [REDProperty(IsIgnored = true)]
    public CArray<worldCookedCollisionShape> Shapes
    {
        get => GetPropertyValue<CArray<worldCookedCollisionShape>>();
        set => SetPropertyValue<CArray<worldCookedCollisionShape>>(value);
    }

    [RED("shapePositions")]
    [REDProperty(IsIgnored = true)]
    public CArray<Vector3> ShapePositions
    {
        get => GetPropertyValue<CArray<Vector3>>();
        set => SetPropertyValue<CArray<Vector3>>(value);
    }

    [RED("shapeRotations")]
    [REDProperty(IsIgnored = true)]
    public CArray<Quaternion> ShapeRotations
    {
        get => GetPropertyValue<CArray<Quaternion>>();
        set => SetPropertyValue<CArray<Quaternion>>(value);
    }

    [RED("scales")]
    [REDProperty(IsIgnored = true)]
    public CArray<Vector3> Scales
    {
        get => GetPropertyValue<CArray<Vector3>>();
        set => SetPropertyValue<CArray<Vector3>>(value);
    }

    [RED("materials")]
    [REDProperty(IsIgnored = true)]
    public CArray<CName> Materials
    {
        get => GetPropertyValue<CArray<CName>>();
        set => SetPropertyValue<CArray<CName>>(value);
    }

    [RED("presets")]
    [REDProperty(IsIgnored = true)]
    public CArray<CName> Presets
    {
        get => GetPropertyValue<CArray<CName>>();
        set => SetPropertyValue<CArray<CName>>(value);
    }

    [RED("shapeIndices")]
    [REDProperty(IsIgnored = true)]
    public CArray<CUInt32> ShapeIndices
    {
        get => GetPropertyValue<CArray<CUInt32>>();
        set => SetPropertyValue<CArray<CUInt32>>(value);
    }

    [RED("materialIndices")]
    [REDProperty(IsIgnored = true)]
    public CArray<CUInt8> MaterialIndices
    {
        get => GetPropertyValue<CArray<CUInt8>>();
        set => SetPropertyValue<CArray<CUInt8>>(value);
    }

    public worldCookedCollisionInnerNode()
    {
        Actors = new();
        Shapes = new();
        ShapePositions = new();
        ShapeRotations = new();
        Scales = new();
        Materials = new();
        Presets = new();
        ShapeIndices = new();
        MaterialIndices = new();
    }
}

public class worldCookedCollisionActor : RedBaseClass
{
    [RED("transform")]
    [REDProperty(IsIgnored = true)]
    public WorldTransform Transform
    {
        get => GetPropertyValue<WorldTransform>();
        set => SetPropertyValue<WorldTransform>(value);
    }

    [RED("shapeStartIndex")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 ShapeStartIndex
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("shapeCount")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 ShapeCount
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("scaleIndex")]
    [REDProperty(IsIgnored = true)]
    public CInt16 ScaleIndex
    {
        get => GetPropertyValue<CInt16>();
        set => SetPropertyValue<CInt16>(value);
    }

    [RED("uk1")]
    [REDProperty(IsIgnored = true)]
    public CUInt8 Uk1
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }

    public worldCookedCollisionActor()
    {
        Transform = new();
    }
}

public class worldCookedCollisionShape : RedBaseClass
{
    [RED("collisionSourceKey")]
    [REDProperty(IsIgnored = true)]
    public physicsGeometryKey CollisionSourceKey
    {
        get => GetPropertyValue<physicsGeometryKey>();
        set => SetPropertyValue<physicsGeometryKey>(value);
    }

    [RED("index")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Index
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("materialCount")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 MaterialCount
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("shapePositionIndex")]
    [REDProperty(IsIgnored = true)]
    public CInt16 ShapePositionIndex
    {
        get => GetPropertyValue<CInt16>();
        set => SetPropertyValue<CInt16>(value);
    }

    [RED("shapeRotationIndex")]
    [REDProperty(IsIgnored = true)]
    public CInt16 ShapeRotationIndex
    {
        get => GetPropertyValue<CInt16>();
        set => SetPropertyValue<CInt16>(value);
    }

    [RED("shapePresetIndex")]
    [REDProperty(IsIgnored = true)]
    public CUInt8 ShapePresetIndex
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }

    [RED("proxyType")]
    [REDProperty(IsIgnored = true)]
    public CUInt8 ProxyType
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }

    public worldCookedCollisionShape()
    {
        CollisionSourceKey = new();
    }
}
