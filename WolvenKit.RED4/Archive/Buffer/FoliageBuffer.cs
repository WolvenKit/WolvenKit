using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer;

public class FoliageBuffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<Foliage_Class1> Populations { get; set; } = new();
    public CArray<Foliage_BucketClass> Buckets { get; set; } = new();
}

public class Foliage_Class1 : IRedClass
{
    public Vector3 Position { get; set; }
    public CFloat Scale { get; set; }
    public Vector4 Rotation { get; set; }
}

public class Foliage_BucketClass : IRedClass
{
    public CUInt32 PopulationSubIndex { get; set; }
    public CUInt32 PopulationCount { get; set; }
}