using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliageCompiledResource : CResource
	{
		[Ordinal(1)] [RED("version")] public CUInt32 Version { get; set; }
		[Ordinal(2)] [RED("populationCount")] public CUInt32 PopulationCount { get; set; }
		[Ordinal(3)] [RED("bucketCount")] public CUInt32 BucketCount { get; set; }
		[Ordinal(4)] [RED("dataBuffer")] public DataBuffer DataBuffer { get; set; }

		public worldFoliageCompiledResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
