using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types;

public partial class worldCookedStaticDecalNode
{
    public override void LoadData(RedBaseClass cls)
    {
        if (cls is not worldStreamingSector wss)
        {
            throw new Exception();
        }

        var result = new worldCookedStaticDecalNodeBuffer();

        //var relatedNodes = GetRelatedNodes(wss);

        using var ms = new MemoryStream(Buffer.Buffer.GetBytes());
        using var br = new Red4Reader(ms);

        var size1 = br.BaseReader.ReadVLQInt32();

        var count1 = size1 / 36;
        for (var i = 0; i < count1; i++)
        {
            var entry = new worldCookedStaticDecalInnerNode();

            entry.Material = new CResourceAsyncReference<IMaterial>(br.BaseReader.ReadUInt64());
            entry.ForcedAutoHideDistance = br.ReadCFloat();
            entry.AutoHideDistance = br.ReadCFloat();
            entry.Alpha = br.ReadCFloat();
            entry.NormalThreshold = br.ReadCFloat();
            entry.RoughnessScale = br.ReadCFloat();
            entry.OrderNo = br.ReadCUInt16();
            entry.DiffuseColorScaleIndex = br.ReadCUInt16();
            entry.SurfaceType = (ERenderObjectType)br.BaseReader.ReadByte();
            entry.DecalRenderMode = (EDecalRenderMode)br.BaseReader.ReadByte();
            entry.NormalsBlendingMode = (RenderDecalNormalsBlendingMode)br.BaseReader.ReadByte();
            entry.Flags = (CookedStaticDecalNodeEntryData_EMiscFlags)br.BaseReader.ReadByte();

            result.InnerNodes.Add(entry);
        }

        var count2 = br.BaseReader.ReadVLQInt32(); // WHY????
        for (var i = 0; i < count2; i++)
        {
            var entry = new HDRColor();

            entry.Red = br.ReadCFloat();
            entry.Green = br.ReadCFloat();
            entry.Blue = br.ReadCFloat();
            entry.Alpha = br.ReadCFloat();

            result.DiffuseColorScales.Add(entry);
        }

        Buffer.Data = result;
    }

    public override void StoreData()
    {
        if (Buffer.Data is not worldCookedStaticDecalNodeBuffer data)
        {
            throw new Exception();
        }

        using var ms = new MemoryStream();
        using var bw = new Red4Writer(ms);

        bw.BaseWriter.WriteVLQInt32(data.InnerNodes.Count * 36);
        foreach (var entry in data.InnerNodes)
        {
            bw.BaseWriter.Write((ulong)entry.Material.DepotPath);
            bw.Write(entry.ForcedAutoHideDistance);
            bw.Write(entry.AutoHideDistance);
            bw.Write(entry.Alpha);
            bw.Write(entry.NormalThreshold);
            bw.Write(entry.RoughnessScale);
            bw.Write(entry.OrderNo);
            bw.Write(entry.DiffuseColorScaleIndex);
            bw.BaseWriter.Write((byte)(ERenderObjectType)entry.SurfaceType);
            bw.BaseWriter.Write((byte)(EDecalRenderMode)entry.DecalRenderMode);
            bw.BaseWriter.Write((byte)(RenderDecalNormalsBlendingMode)entry.NormalsBlendingMode);
            bw.BaseWriter.Write((byte)(CookedStaticDecalNodeEntryData_EMiscFlags)entry.Flags);
        }

        bw.BaseWriter.WriteVLQInt32(data.DiffuseColorScales.Count);
        foreach (var entry in data.DiffuseColorScales)
        {
            bw.Write(entry.Red);
            bw.Write(entry.Green);
            bw.Write(entry.Blue);
            bw.Write(entry.Alpha);
        }

        bw.BaseWriter.Flush();
        ms.Flush();

        Buffer.Buffer.SetBytes(ms.ToArray());
    }
}

public class worldCookedStaticDecalNodeBuffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<worldCookedStaticDecalInnerNode> InnerNodes { get; set; } = new();
    public CArray<HDRColor> DiffuseColorScales { get; set; } = new();
}

public class worldCookedStaticDecalInnerNode : RedBaseClass
{
    [RED("material")]
    [REDProperty(IsIgnored = true)]
    public CResourceAsyncReference<IMaterial> Material
    {
        get => GetPropertyValue<CResourceAsyncReference<IMaterial>>();
        set => SetPropertyValue<CResourceAsyncReference<IMaterial>>(value);
    }

    [RED("forcedAutoHideDistance")]
    [REDProperty(IsIgnored = true)]
    public CFloat ForcedAutoHideDistance
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("autoHideDistance")]
    [REDProperty(IsIgnored = true)]
    public CFloat AutoHideDistance
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("alpha")]
    [REDProperty(IsIgnored = true)]
    public CFloat Alpha
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("normalThreshold")]
    [REDProperty(IsIgnored = true)]
    public CFloat NormalThreshold
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("roughnessScale")]
    [REDProperty(IsIgnored = true)]
    public CFloat RoughnessScale
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("orderNo")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 OrderNo
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("diffuseColorScaleIndex")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 DiffuseColorScaleIndex
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("surfaceType")]
    [REDProperty(IsIgnored = true)]
    public CEnum<ERenderObjectType> SurfaceType
    {
        get => GetPropertyValue<CEnum<ERenderObjectType>>();
        set => SetPropertyValue<CEnum<ERenderObjectType>>(value);
    }

    [RED("decalRenderMode")]
    [REDProperty(IsIgnored = true)]
    public CEnum<EDecalRenderMode> DecalRenderMode
    {
        get => GetPropertyValue<CEnum<EDecalRenderMode>>();
        set => SetPropertyValue<CEnum<EDecalRenderMode>>(value);
    }

    [RED("normalsBlendingMode")]
    [REDProperty(IsIgnored = true)]
    public CEnum<RenderDecalNormalsBlendingMode> NormalsBlendingMode
    {
        get => GetPropertyValue<CEnum<RenderDecalNormalsBlendingMode>>();
        set => SetPropertyValue<CEnum<RenderDecalNormalsBlendingMode>>(value);
    }

    [RED("flags")]
    [REDProperty(IsIgnored = true)]
    public CBitField<CookedStaticDecalNodeEntryData_EMiscFlags> Flags
    {
        get => GetPropertyValue<CBitField<CookedStaticDecalNodeEntryData_EMiscFlags>>();
        set => SetPropertyValue<CBitField<CookedStaticDecalNodeEntryData_EMiscFlags>>(value);
    }
}
