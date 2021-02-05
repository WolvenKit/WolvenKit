using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldCompiledEffectInfo : CVariable
	{
		[Ordinal(0)]  [RED("placementTags")] public CArray<CName> PlacementTags { get; set; }
		[Ordinal(1)]  [RED("componentNames")] public CArray<CName> ComponentNames { get; set; }
		[Ordinal(2)]  [RED("relativePositions")] public CArray<Vector3> RelativePositions { get; set; }
		[Ordinal(3)]  [RED("relativeRotations")] public CArray<Quaternion> RelativeRotations { get; set; }
		[Ordinal(4)]  [RED("placementInfos")] public CArray<worldCompiledEffectPlacementInfo> PlacementInfos { get; set; }
		[Ordinal(5)]  [RED("eventsSortedByRUID")] public CArray<worldCompiledEffectEventInfo> EventsSortedByRUID { get; set; }

		public worldCompiledEffectInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
