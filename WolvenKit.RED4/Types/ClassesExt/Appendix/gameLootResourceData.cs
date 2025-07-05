using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class gameLootResourceData : IRedAppendix
{
    [RED("nodeRefsHash")]
    [REDProperty(IsIgnored = true)]
    public CArray<CUInt64> NodeRefsHash
    {
        get => GetPropertyValue<CArray<CUInt64>>();
        set => SetPropertyValue<CArray<CUInt64>>(value);
    }

    [RED("tweakDbIds")]
    [REDProperty(IsIgnored = true)]
    public CArray<CArray<TweakDBID>> TweakDbIds
    {
        get => GetPropertyValue<CArray<CArray<TweakDBID>>>();
        set => SetPropertyValue<CArray<CArray<TweakDBID>>>(value);
    }

    partial void PostConstruct()
    {
        NodeRefsHash = new CArray<CUInt64>();
        TweakDbIds = new CArray<CArray<TweakDBID>>();
    }

    public void Read(Red4Reader reader, uint size)
    {
        NodeRefsHash = new CArray<CUInt64>();
        TweakDbIds = new CArray<CArray<TweakDBID>>();

        var cnt = reader.BaseReader.ReadVLQInt32();
        for (int i = 0; i < cnt; i++)
        {
            NodeRefsHash.Add(reader.ReadCUInt64());
        }

        for (int i = 0; i < cnt; i++)
        {
            var tmp = new CArray<TweakDBID>();

            var cnt2 = reader.BaseReader.ReadByte();
            for (int j = 0; j <= cnt2; j++)
            {
                tmp.Add(reader.ReadTweakDBID());
            }
            TweakDbIds.Add(tmp);
        }
    }

    public void Write(Red4Writer writer)
    {
        writer.WriteVLQ(NodeRefsHash.Count);
        foreach (var entry in NodeRefsHash)
        {
            writer.Write(entry);
        }

        foreach (var ids in TweakDbIds)
        {
            writer.BaseWriter.Write((byte)(ids.Count - 1));
            foreach (var tweakDbid in ids)
            {
                writer.Write(tweakDbid);
            }
        }
    }
}