using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class worldTrafficPersistentLaneConnectionsResource : IRedAppendix
{
    [RED("data")]
    [REDProperty(IsIgnored = true)]
    public CArray<worldTrafficPersistentLaneConnectionsResource_Data> Data
    {
        get => GetPropertyValue<CArray<worldTrafficPersistentLaneConnectionsResource_Data>>();
        set => SetPropertyValue<CArray<worldTrafficPersistentLaneConnectionsResource_Data>>(value);
    }

    partial void PostConstruct()
    {
        Data = new CArray<worldTrafficPersistentLaneConnectionsResource_Data>();
    }

    public void Read(Red4Reader reader, uint size)
    {
        var entryCount = reader.BaseReader.ReadUInt32();
        for (var i = 0; i < entryCount; i++)
        {
            var entry = new worldTrafficPersistentLaneConnectionsResource_Data
            {
                Index = reader.ReadCUInt16()
            };

            var cnt1 = reader.BaseReader.ReadVLQInt32();
            for (var j = 0; j < cnt1; j++)
            {
                entry.Value.Outlanes.Add(new worldTrafficConnectivityOutLane
                {
                    LaneIndex = reader.ReadCUInt16(),
                    ExitProbabilityCompressed = reader.ReadCUInt8(),
                    IsSharpAngle = reader.ReadCBool(),
                    ThisLaneExitPosition = reader.ReadCFloat(),
                    NextLaneEntryPosition = reader.ReadCFloat()
                });
            }

            var cnt2 = reader.BaseReader.ReadVLQInt32();
            for (var j = 0; j < cnt2; j++)
            {
                entry.Value.InLanes.Add(new worldTrafficConnectivityInLane() { LaneIndex = reader.ReadCUInt16() });
            }

            Data.Add(entry);
        }
    }

    public void Write(Red4Writer writer) => throw new NotImplementedException();
}

public class worldTrafficPersistentLaneConnectionsResource_Data : RedBaseClass
{
    [RED("index")]
    public CUInt16 Index
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("value")] 
    public worldTrafficPersistentLaneConnections Value
    {
        get => GetPropertyValue<worldTrafficPersistentLaneConnections>();
        set => SetPropertyValue<worldTrafficPersistentLaneConnections>(value);
    }

    public worldTrafficPersistentLaneConnectionsResource_Data()
    {
        Value = new worldTrafficPersistentLaneConnections();
    }
}