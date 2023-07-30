using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Archive.IO;

public class FoliageWriter : Red4Writer
{
    public FoliageWriter(Stream ms) : base(ms)
    {

    }

    public void WriteBuffer(FoliageBuffer buffer)
    {
        foreach (var population in buffer.Populations)
        {
            _writer.Write(population.Unk1.X);
            _writer.Write(population.Unk1.Y);
            _writer.Write(population.Unk1.Z);
        }

        foreach (var population in buffer.Populations)
        {
            _writer.Write(population.Unk2);
        }

        foreach (var population in buffer.Populations)
        {
            _writer.Write(population.Unk3.Unk1);
            _writer.Write(population.Unk3.Unk2);
        }

        foreach (var bucket in buffer.Buckets)
        {
            _writer.Write(bucket.PopulationSubIndex);
            _writer.Write(bucket.PopulationCount);
        }
    }
}