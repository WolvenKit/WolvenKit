using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entPhysicalSkinnedMeshComponent : entSkinnedMeshComponent
	{
		[Ordinal(0)]  [RED("simulationType")] public CEnum<physicsSimulationType> SimulationType { get; set; }
		[Ordinal(1)]  [RED("useResourceSimulationType")] public CBool UseResourceSimulationType { get; set; }
		[Ordinal(2)]  [RED("startInactive")] public CBool StartInactive { get; set; }
		[Ordinal(3)]  [RED("filterDataSource")] public CEnum<physicsFilterDataSource> FilterDataSource { get; set; }
		[Ordinal(4)]  [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }

		public entPhysicalSkinnedMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
