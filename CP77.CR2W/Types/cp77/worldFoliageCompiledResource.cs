using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldFoliageCompiledResource : CResource
	{
		[Ordinal(0)]  [RED("version")] public CUInt32 Version { get; set; }
		[Ordinal(1)]  [RED("populationCount")] public CUInt32 PopulationCount { get; set; }
		[Ordinal(2)]  [RED("bucketCount")] public CUInt32 BucketCount { get; set; }
		[Ordinal(3)]  [RED("dataBuffer")] public DataBuffer DataBuffer { get; set; }

		public worldFoliageCompiledResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
