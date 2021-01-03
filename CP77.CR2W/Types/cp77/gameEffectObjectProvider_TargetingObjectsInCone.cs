using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_TargetingObjectsInCone : gameEffectObjectProvider
	{
		[Ordinal(0)]  [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
		[Ordinal(1)]  [RED("maxTargets")] public CUInt32 MaxTargets { get; set; }
		[Ordinal(2)]  [RED("searchAngles")] public EulerAngles SearchAngles { get; set; }
		[Ordinal(3)]  [RED("searchQuery")] public gameTargetSearchQuery SearchQuery { get; set; }

		public gameEffectObjectProvider_TargetingObjectsInCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
