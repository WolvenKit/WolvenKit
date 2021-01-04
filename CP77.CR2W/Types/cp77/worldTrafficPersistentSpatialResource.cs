using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentSpatialResource : resStreamedResource
	{
		[Ordinal(0)]  [RED("neighborGroups")] public CArray<CArray<CUInt16>> NeighborGroups { get; set; }

		public worldTrafficPersistentSpatialResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
