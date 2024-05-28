using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class FoliageReader : IBufferReader
{
    private MemoryStream _ms;

    public FoliageReader(MemoryStream ms)
    {
        _ms = ms;
    }

    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        if (buffer.Parent is not worldFoliageCompiledResource resource)
        {
            return EFileReadErrorCodes.NoError;
        }

        var data = new FoliageBuffer();
        buffer.Data = data;

        var reader = new BinaryReader(_ms);

        for (var i = 0; i < resource.PopulationCount; i++)
        {
            data.Populations.Add(new Foliage_Class1
            {
                Position = new Vector3
                {
                    X = reader.ReadSingle(), 
                    Y = reader.ReadSingle(), 
                    Z = reader.ReadSingle(),
                }
            });
        }

        for (var i = 0; i < resource.PopulationCount; i++)
        {
            data.Populations[i].Scale = reader.ReadSingle();
        }

        for (var i = 0; i < resource.PopulationCount; i++)
        {
            data.Populations[i].Rotation = new Vector4
            {
                X = (float)reader.ReadHalf(), 
                Y = (float)reader.ReadHalf(),
                Z = (float)reader.ReadHalf(),
                W = (float)reader.ReadHalf()
            };
        }

        for (var i = 0; i < resource.BucketCount; i++)
        {
            data.Buckets.Add(new Foliage_BucketClass
            {
                PopulationSubIndex = reader.ReadUInt32(),
                PopulationCount = reader.ReadUInt32()
            });
        }

        return EFileReadErrorCodes.NoError;
    }
}