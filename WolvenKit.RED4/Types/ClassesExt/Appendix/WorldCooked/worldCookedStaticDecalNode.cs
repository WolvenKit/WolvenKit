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

        var result = new worldCookedStaticDecalNode_Buffer();

        //var relatedNodes = GetRelatedNodes(wss);

        using var ms = new MemoryStream(Buffer.Buffer.GetBytes());
        using var br = new Red4Reader(ms);

        var size1 = br.BaseReader.ReadVLQInt32();

        var count1 = size1 / 36;
        for (var i = 0; i < count1; i++)
        {
            var entry = new worldCookedStaticDecalNode_Class1();

            entry.Unknown1 = new CResourceAsyncReference<IMaterial>(br.BaseReader.ReadUInt64());
            entry.Unknown2 = br.ReadCFloat();
            entry.Unknown3 = br.ReadCFloat();
            entry.Unknown4 = br.ReadCFloat();
            entry.Unknown5 = br.ReadCFloat();
            entry.Unknown6 = br.ReadCFloat();
            entry.Unknown7 = br.ReadCUInt16();
            entry.Unknown8 = br.ReadCUInt16();
            entry.Unknown9 = (ERenderObjectType)br.BaseReader.ReadByte();
            entry.Unknown10 = (EDecalRenderMode)br.BaseReader.ReadByte();
            entry.Unknown11 = (RenderDecalNormalsBlendingMode)br.BaseReader.ReadByte();
            entry.Unknown12 = (CookedStaticDecalNodeEntryData_EMiscFlags)br.BaseReader.ReadByte();

            result.Unknown1.Add(entry);
        }

        var count2 = br.BaseReader.ReadVLQInt32(); // WHY????
        for (var i = 0; i < count2; i++)
        {
            var entry = new HDRColor();

            entry.Red = br.ReadCFloat();
            entry.Green = br.ReadCFloat();
            entry.Blue = br.ReadCFloat();
            entry.Alpha = br.ReadCFloat();

            result.Unknown2.Add(entry);
        }

        Buffer.Data = result;
    }

    public override void StoreData()
    {
        if (Buffer.Data is not worldCookedStaticDecalNode_Buffer data)
        {
            throw new Exception();
        }

        using var ms = new MemoryStream();
        using var bw = new Red4Writer(ms);

        bw.BaseWriter.WriteVLQInt32(data.Unknown1.Count * 36);
        foreach (var entry in data.Unknown1)
        {
            bw.BaseWriter.Write((ulong)entry.Unknown1.DepotPath);
            bw.Write(entry.Unknown2);
            bw.Write(entry.Unknown3);
            bw.Write(entry.Unknown4);
            bw.Write(entry.Unknown5);
            bw.Write(entry.Unknown6);
            bw.Write(entry.Unknown7);
            bw.Write(entry.Unknown8);
            bw.BaseWriter.Write((byte)(ERenderObjectType)entry.Unknown9);
            bw.BaseWriter.Write((byte)(EDecalRenderMode)entry.Unknown10);
            bw.BaseWriter.Write((byte)(RenderDecalNormalsBlendingMode)entry.Unknown11);
            bw.BaseWriter.Write((byte)(CookedStaticDecalNodeEntryData_EMiscFlags)entry.Unknown12);
        }

        bw.BaseWriter.WriteVLQInt32(data.Unknown2.Count);
        foreach (var entry in data.Unknown2)
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

public class worldCookedStaticDecalNode_Buffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<worldCookedStaticDecalNode_Class1> Unknown1 { get; set; } = new();
    public CArray<HDRColor> Unknown2 { get; set; } = new();
}

public class worldCookedStaticDecalNode_Class1 : RedBaseClass
{
    [RED("unknown1")]
    [REDProperty(IsIgnored = true)]
    public CResourceAsyncReference<IMaterial> Unknown1
    {
        get => GetPropertyValue<CResourceAsyncReference<IMaterial>>();
        set => SetPropertyValue<CResourceAsyncReference<IMaterial>>(value);
    }

    [RED("unknown2")]
    [REDProperty(IsIgnored = true)]
    public CFloat Unknown2
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("unknown3")]
    [REDProperty(IsIgnored = true)]
    public CFloat Unknown3
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("unknown4")]
    [REDProperty(IsIgnored = true)]
    public CFloat Unknown4
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("unknown5")]
    [REDProperty(IsIgnored = true)]
    public CFloat Unknown5
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("unknown6")]
    [REDProperty(IsIgnored = true)]
    public CFloat Unknown6
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("unknown7")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Unknown7
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("unknown8")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Unknown8
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("unknown9")]
    [REDProperty(IsIgnored = true)]
    public CEnum<ERenderObjectType> Unknown9
    {
        get => GetPropertyValue<CEnum<ERenderObjectType>>();
        set => SetPropertyValue<CEnum<ERenderObjectType>>(value);
    }

    [RED("unknown10")]
    [REDProperty(IsIgnored = true)]
    public CEnum<EDecalRenderMode> Unknown10
    {
        get => GetPropertyValue<CEnum<EDecalRenderMode>>();
        set => SetPropertyValue<CEnum<EDecalRenderMode>>(value);
    }

    [RED("unknown11")]
    [REDProperty(IsIgnored = true)]
    public CEnum<RenderDecalNormalsBlendingMode> Unknown11
    {
        get => GetPropertyValue<CEnum<RenderDecalNormalsBlendingMode>>();
        set => SetPropertyValue<CEnum<RenderDecalNormalsBlendingMode>>(value);
    }

    [RED("unknown12")]
    [REDProperty(IsIgnored = true)]
    public CBitField<CookedStaticDecalNodeEntryData_EMiscFlags> Unknown12
    {
        get => GetPropertyValue<CBitField<CookedStaticDecalNodeEntryData_EMiscFlags>>();
        set => SetPropertyValue<CBitField<CookedStaticDecalNodeEntryData_EMiscFlags>>(value);
    }
}
