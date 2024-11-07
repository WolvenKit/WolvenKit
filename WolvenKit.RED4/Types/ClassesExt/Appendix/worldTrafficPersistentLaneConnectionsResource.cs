using System.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class worldTrafficPersistentLaneConnectionsResource : IRedAppendix
{
    [RED("unk1")]
    [REDProperty(IsIgnored = true)]
    public CArray<worldTrafficPersistentLaneConnectionsResource_Class1> Unk1
    {
        get => GetPropertyValue<CArray<worldTrafficPersistentLaneConnectionsResource_Class1>>();
        set => SetPropertyValue<CArray<worldTrafficPersistentLaneConnectionsResource_Class1>>(value);
    }

    partial void PostConstruct()
    {
        Unk1 = new CArray<worldTrafficPersistentLaneConnectionsResource_Class1>();
    }

    public void Read(Red4Reader reader, uint size)
    {
        var entryCount = reader.BaseReader.ReadUInt32();
        for (var i = 0; i < entryCount; i++)
        {
            var entry = new worldTrafficPersistentLaneConnectionsResource_Class1
            {
                Index = reader.ReadCUInt16()
            };

            var cnt1 = reader.BaseReader.ReadVLQInt32();
            for (var j = 0; j < cnt1; j++)
            {
                entry.Unk1.Add(new worldTrafficPersistentLaneConnectionsResource_Class2
                {
                    Unk1 = reader.ReadCUInt32(),
                    Unk2 = reader.ReadCFloat(),
                    Unk3 = reader.ReadCFloat()
                });
            }

            var cnt2 = reader.BaseReader.ReadVLQInt32();
            for (var j = 0; j < cnt2; j++)
            {
                entry.Unk2.Add(reader.ReadCUInt16());
            }

            Unk1.Add(entry);
        }
    }

    public void Write(Red4Writer writer) => throw new NotImplementedException();
}

public class worldTrafficPersistentLaneConnectionsResource_Class1 : RedBaseClass
{
    [RED("index")]
    public CUInt16 Index
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("unk1")] 
    public CArray<worldTrafficPersistentLaneConnectionsResource_Class2> Unk1
    {
        get => GetPropertyValue<CArray<worldTrafficPersistentLaneConnectionsResource_Class2>>();
        set => SetPropertyValue<CArray<worldTrafficPersistentLaneConnectionsResource_Class2>>(value);
    }

    [RED("unk2")]
    public CArray<CUInt16> Unk2
    {
        get => GetPropertyValue<CArray<CUInt16>>();
        set => SetPropertyValue<CArray<CUInt16>>(value);
    }

    public worldTrafficPersistentLaneConnectionsResource_Class1()
    {
        Unk1 = new CArray<worldTrafficPersistentLaneConnectionsResource_Class2>();
        Unk2 = new CArray<CUInt16>();
    }
}

// maybe worldTrafficConnectivityOutLane
public class worldTrafficPersistentLaneConnectionsResource_Class2 : RedBaseClass
{
    [RED("unk1")]
    public CUInt32 Unk1
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [RED("unk2")]
    public CFloat Unk2
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("unk3")]
    public CFloat Unk3
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }
}