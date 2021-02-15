using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entPhysicalMeshComponent : entMeshComponent
	{
		[Ordinal(22)] [RED("visibilityAnimationParam")] public CName VisibilityAnimationParam { get; set; }
		[Ordinal(23)] [RED("simulationType")] public CEnum<physicsSimulationType> SimulationType { get; set; }
		[Ordinal(24)] [RED("useResourceSimulationType")] public CBool UseResourceSimulationType { get; set; }
		[Ordinal(25)] [RED("startInactive")] public CBool StartInactive { get; set; }
		[Ordinal(26)] [RED("filterDataSource")] public CEnum<physicsFilterDataSource> FilterDataSource { get; set; }
		[Ordinal(27)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }

		public entPhysicalMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
