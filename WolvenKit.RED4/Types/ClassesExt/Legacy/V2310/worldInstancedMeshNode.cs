using System.ComponentModel;
using WolvenKit.RED4.IO;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types.Legacy.V2310;

[RED("worldInstancedMeshNode", gameGameVersion.CP77_Patch_2_3_Hotfix1)]
public class worldInstancedMeshNode : worldNode, IRedAppendix
{
    [Ordinal(0)]
    [RED("debugName")]
    public new CName DebugName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(1)]
    [RED("sourcePrefabHash")]
    public new CUInt64 SourcePrefabHash
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [Ordinal(2)]
    [RED("isVisibleInGame")]
    public new CBool IsVisibleInGame
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [Ordinal(3)]
    [RED("isHostOnly")]
    public new CBool IsHostOnly
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [Ordinal(4)]
    [RED("mesh")]
    public CResourceAsyncReference<CMesh> Mesh
    {
        get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
        set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
    }

    [Ordinal(5)]
    [RED("meshAppearance")]
    public CName MeshAppearance
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(6)]
    [RED("castShadows")]
    public CEnum<shadowsShadowCastingMode> CastShadows
    {
        get => GetPropertyValue<CEnum<shadowsShadowCastingMode>>();
        set => SetPropertyValue<CEnum<shadowsShadowCastingMode>>(value);
    }

    [Ordinal(7)]
    [RED("castLocalShadows")]
    public CEnum<shadowsShadowCastingMode> CastLocalShadows
    {
        get => GetPropertyValue<CEnum<shadowsShadowCastingMode>>();
        set => SetPropertyValue<CEnum<shadowsShadowCastingMode>>(value);
    }

    [Ordinal(8)]
    [RED("occluderType")]
    public CEnum<visWorldOccluderType> OccluderType
    {
        get => GetPropertyValue<CEnum<visWorldOccluderType>>();
        set => SetPropertyValue<CEnum<visWorldOccluderType>>(value);
    }

    [Ordinal(9)]
    [RED("meshLODScales")]
    public CUInt32 MeshLODScales
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [Ordinal(10)]
    [RED("occluderAutohideDistanceScale")]
    public CUInt8 OccluderAutohideDistanceScale
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }

    [Ordinal(11)]
    [RED("worldTransformsBuffer")]
    public worldRenderProxyTransformBuffer WorldTransformsBuffer
    {
        get => GetPropertyValue<worldRenderProxyTransformBuffer>();
        set => SetPropertyValue<worldRenderProxyTransformBuffer>(value);
    }

    [Ordinal(12)]
    [RED("version")]
    public CUInt8 Version
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }

    [Ordinal(997)]
    [RED("proxyScale")]
    public new Vector3 ProxyScale
    {
        get => GetPropertyValue<Vector3>();
        set => SetPropertyValue<Vector3>(value);
    }

    [Ordinal(998)]
    [RED("tag")]
    public new CEnum<worldObjectTag> Tag
    {
        get => GetPropertyValue<CEnum<worldObjectTag>>();
        set => SetPropertyValue<CEnum<worldObjectTag>>(value);
    }

    [Ordinal(999)]
    [RED("tagExt")]
    public new CEnum<worldObjectTagExt> TagExt
    {
        get => GetPropertyValue<CEnum<worldObjectTagExt>>();
        set => SetPropertyValue<CEnum<worldObjectTagExt>>(value);
    }

    [RED("buffer")]
    [REDProperty(IsIgnored = true)]
    [Browsable(false)]
    public worldInstancedMeshNode_Buffer Buffer
    {
        get => GetPropertyValue<worldInstancedMeshNode_Buffer>();
        set => SetPropertyValue<worldInstancedMeshNode_Buffer>(value);
    }

    public worldInstancedMeshNode()
    {
        IsVisibleInGame = true;
        MeshLODScales = uint.MaxValue;
        OccluderAutohideDistanceScale = 255;
        WorldTransformsBuffer = new worldRenderProxyTransformBuffer();
        Buffer = new worldInstancedMeshNode_Buffer();
    }

    public void Read(Red4Reader reader, uint size)
    {
        if (size == 0)
        {
            return;
        }

        var length = reader.BaseReader.ReadByte(); // Could be something else, in base files its always 1
        for (var i = 0; i < length; i++)
        {
            Buffer.Unknown1.Add(new Box
            {
                Min = new Vector4 { X = reader.ReadCFloat(), Y = reader.ReadCFloat(), Z = reader.ReadCFloat(), W = reader.ReadCFloat() },
                Max = new Vector4 { X = reader.ReadCFloat(), Y = reader.ReadCFloat(), Z = reader.ReadCFloat(), W = reader.ReadCFloat() }
            });
        }

        length = reader.BaseReader.ReadByte(); // Could be something else, in base files its always 1
        for (var i = 0; i < length; i++)
        {
            Buffer.Unknown2.Add(reader.ReadCFloat());
        }

        length = reader.BaseReader.ReadByte(); // Could be something else, in base files its always 1
        for (var i = 0; i < length; i++)
        {
            Buffer.Unknown3.Add(reader.ReadCUInt32());
        }
    }

    public void Write(Red4Writer writer)
    {
        // TODO: Check for empty buffers. Nothing written vs length 0

        writer.BaseWriter.Write((byte)Buffer.Unknown1.Count); // Could be something else, in base files its always 1
        foreach (var box in Buffer.Unknown1)
        {
            writer.Write(box.Min.X);
            writer.Write(box.Min.Y);
            writer.Write(box.Min.Z);
            writer.Write(box.Min.W);

            writer.Write(box.Max.X);
            writer.Write(box.Max.Y);
            writer.Write(box.Max.Z);
            writer.Write(box.Max.W);
        }

        writer.BaseWriter.Write((byte)Buffer.Unknown2.Count); // Could be something else, in base files its always 1
        foreach (var val in Buffer.Unknown2)
        {
            writer.Write(val);
        }

        writer.BaseWriter.Write((byte)Buffer.Unknown3.Count); // Could be something else, in base files its always 1
        foreach (var val in Buffer.Unknown3)
        {
            writer.Write(val);
        }
    }
}

public class worldInstancedMeshNode_Buffer : IRedClass
{
    public CArray<Box> Unknown1 { get; set; } = new(); // some kind of boundingBox for worldInstancedMeshNode.worldTransformBuffer elements
    public CArray<CFloat> Unknown2 { get; set; } = new(); // ???
    public CArray<CUInt32> Unknown3 { get; set; } = new(); // same as worldInstancedMeshNode.worldTransformBuffer.numElements
}
