using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class FoliageWriter : Red4Writer
{
    public FoliageWriter(Stream ms) : base(ms)
    {

    }

    public void WriteBuffer(FoliageBuffer buffer, worldFoliageCompiledResource parent)
    {
        parent.PopulationCount = (uint)buffer.Populations.Count;
        foreach (var population in buffer.Populations)
        {
            _writer.Write(population.Position.X);
            _writer.Write(population.Position.Y);
            _writer.Write(population.Position.Z);
        }

        foreach (var population in buffer.Populations)
        {
            _writer.Write(population.Scale);
        }

        foreach (var population in buffer.Populations)
        {
            _writer.Write((Half)(float)population.Rotation.X);
            _writer.Write((Half)(float)population.Rotation.Y);
            _writer.Write((Half)(float)population.Rotation.Z);
            _writer.Write((Half)(float)population.Rotation.W);
        }

        parent.BucketCount = (uint)buffer.Buckets.Count;
        foreach (var bucket in buffer.Buckets)
        {
            _writer.Write(bucket.PopulationSubIndex);
            _writer.Write(bucket.PopulationCount);
        }
    }
}