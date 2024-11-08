using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class worldTrafficPersistentLanePolygonResource : IRedAppendix
{
    [RED("data")]
    [REDProperty(IsIgnored = true)]
    public CArray<worldTrafficPersistentLanePolygonResource_Data> Data
    {
        get => GetPropertyValue<CArray<worldTrafficPersistentLanePolygonResource_Data>>();
        set => SetPropertyValue<CArray<worldTrafficPersistentLanePolygonResource_Data>>(value);
    }

    partial void PostConstruct()
    {
        Data = new CArray<worldTrafficPersistentLanePolygonResource_Data>();
    }

    public void Read(Red4Reader reader, uint size)
    {
        var entryCount = reader.BaseReader.ReadUInt32();
        for (var i = 0; i < entryCount; i++)
        {
            var entry = new worldTrafficPersistentLanePolygonResource_Data
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

                entry.Value.Outline.Add(subEntry);
            }

            var cnt2 = reader.BaseReader.ReadVLQInt32();
            for (var j = 0; j < cnt2; j++)
            {
                var subEntry = new Vector2
                {
                    X = reader.ReadCFloat(),
                    Y = reader.ReadCFloat()
                };

                entry.Value.Polygon.Add(subEntry);
            }

            Data.Add(entry);
        }
    }

    public void Write(Red4Writer writer) => throw new NotImplementedException();
}

public class worldTrafficPersistentLanePolygonResource_Data : RedBaseClass
{
    [RED("index")]
    public CUInt16 Index
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("value")]
    public worldTrafficLanePolygonRepresentation Value
    {
        get => GetPropertyValue<worldTrafficLanePolygonRepresentation>();
        set => SetPropertyValue<worldTrafficLanePolygonRepresentation>(value);
    }

    public worldTrafficPersistentLanePolygonResource_Data()
    {
        Value = new worldTrafficLanePolygonRepresentation();
    }
}