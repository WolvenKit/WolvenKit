using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class worldTrafficPersistentLanePolygonResource : IRedAppendix
{
    [RED("unk1")]
    [REDProperty(IsIgnored = true)]
    public CArray<worldTrafficPersistentLanePolygonResource_Class1> Unk1
    {
        get => GetPropertyValue<CArray<worldTrafficPersistentLanePolygonResource_Class1>>();
        set => SetPropertyValue<CArray<worldTrafficPersistentLanePolygonResource_Class1>>(value);
    }

    partial void PostConstruct()
    {
        Unk1 = new CArray<worldTrafficPersistentLanePolygonResource_Class1>();
    }

    public void Read(Red4Reader reader, uint size)
    {
        var entryCount = reader.BaseReader.ReadUInt32();
        for (var i = 0; i < entryCount; i++)
        {
            var entry = new worldTrafficPersistentLanePolygonResource_Class1
            {
                Index = reader.ReadCUInt16()
            };

            var cnt1 = reader.BaseReader.ReadVLQInt32();
            for (var j = 0; j < cnt1; j++)
            {
                var subEntry = new Vector3
                {
                    X = reader.ReadCFloat(), 
                    Y = reader.ReadCFloat(), 
                    Z = reader.ReadCFloat()
                };

                entry.Unk1.Add(subEntry);
            }

            var cnt2 = reader.BaseReader.ReadVLQInt32();
            for (var j = 0; j < cnt2; j++)
            {
                var subEntry = new Vector2
                {
                    X = reader.ReadCFloat(),
                    Y = reader.ReadCFloat()
                };

                entry.Unk2.Add(subEntry);
            }

            Unk1.Add(entry);
        }
    }

    public void Write(Red4Writer writer) => throw new NotImplementedException();
}

public class worldTrafficPersistentLanePolygonResource_Class1 : RedBaseClass
{
    [RED("index")]
    public CUInt16 Index
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("unk1")]
    public CArray<Vector3> Unk1
    {
        get => GetPropertyValue<CArray<Vector3>>();
        set => SetPropertyValue<CArray<Vector3>>(value);
    }

    [RED("unk2")]
    public CArray<Vector2> Unk2
    {
        get => GetPropertyValue<CArray<Vector2>>();
        set => SetPropertyValue<CArray<Vector2>>(value);
    }

    public worldTrafficPersistentLanePolygonResource_Class1()
    {
        Unk1 = new CArray<Vector3>();
        Unk2 = new CArray<Vector2>();
    }
}