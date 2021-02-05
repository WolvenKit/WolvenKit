using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_TargetingObjectsInCone : gameEffectObjectProvider
	{
		[Ordinal(0)]  [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
		[Ordinal(1)]  [RED("searchQuery")] public gameTargetSearchQuery SearchQuery { get; set; }
		[Ordinal(2)]  [RED("searchAngles")] public EulerAngles SearchAngles { get; set; }
		[Ordinal(3)]  [RED("maxTargets")] public CUInt32 MaxTargets { get; set; }

		public gameEffectObjectProvider_TargetingObjectsInCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
