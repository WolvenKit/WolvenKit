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
    public Vector3 Unk1 { get; set; }
    public CFloat Unk2 { get; set; }
    public Foliage_Class2 Unk3 { get; set; }
}

public class Foliage_Class2 : IRedClass
{
    public CFloat Unk1 { get; set; }
    public CFloat Unk2 { get; set; }
}

public class Foliage_BucketClass : IRedClass
{
    public CUInt32 PopulationSubIndex { get; set; }
    public CUInt32 PopulationCount { get; set; }
}