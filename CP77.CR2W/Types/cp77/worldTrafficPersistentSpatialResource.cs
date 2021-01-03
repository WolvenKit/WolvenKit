using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentSpatialResource : resStreamedResource
	{
		[Ordinal(0)]  [RED("neighborGroups")] public CArray<CArray<CUInt16>> NeighborGroups { get; set; }

		public worldTrafficPersistentSpatialResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
