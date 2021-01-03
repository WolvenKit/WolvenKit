using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entPhysicalMeshComponent : entMeshComponent
	{
		[Ordinal(0)]  [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
		[Ordinal(1)]  [RED("filterDataSource")] public CEnum<physicsFilterDataSource> FilterDataSource { get; set; }
		[Ordinal(2)]  [RED("simulationType")] public CEnum<physicsSimulationType> SimulationType { get; set; }
		[Ordinal(3)]  [RED("startInactive")] public CBool StartInactive { get; set; }
		[Ordinal(4)]  [RED("useResourceSimulationType")] public CBool UseResourceSimulationType { get; set; }
		[Ordinal(5)]  [RED("visibilityAnimationParam")] public CName VisibilityAnimationParam { get; set; }

		public entPhysicalMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
