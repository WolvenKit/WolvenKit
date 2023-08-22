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
                Unk1 = new Vector3
                {
                    X = reader.ReadSingle(), 
                    Y = reader.ReadSingle(), 
                    Z = reader.ReadSingle(),
                }
            });
        }

        for (var i = 0; i < resource.PopulationCount; i++)
        {
            data.Populations[i].Unk2 = reader.ReadSingle();
        }

        for (var i = 0; i < resource.PopulationCount; i++)
        {
            data.Populations[i].Unk3 = new Foliage_Class2
            {
                Unk1 = reader.ReadSingle(), 
                Unk2 = reader.ReadSingle()
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