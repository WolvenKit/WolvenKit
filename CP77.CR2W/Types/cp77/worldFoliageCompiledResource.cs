using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldFoliageCompiledResource : CResource
	{
		[Ordinal(0)]  [RED("bucketCount")] public CUInt32 BucketCount { get; set; }
		[Ordinal(1)]  [RED("dataBuffer")] public DataBuffer DataBuffer { get; set; }
		[Ordinal(2)]  [RED("populationCount")] public CUInt32 PopulationCount { get; set; }
		[Ordinal(3)]  [RED("version")] public CUInt32 Version { get; set; }

		public worldFoliageCompiledResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
