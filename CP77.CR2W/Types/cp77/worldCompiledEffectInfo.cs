using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldCompiledEffectInfo : CVariable
	{
		[Ordinal(0)]  [RED("componentNames")] public CArray<CName> ComponentNames { get; set; }
		[Ordinal(1)]  [RED("eventsSortedByRUID")] public CArray<worldCompiledEffectEventInfo> EventsSortedByRUID { get; set; }
		[Ordinal(2)]  [RED("placementInfos")] public CArray<worldCompiledEffectPlacementInfo> PlacementInfos { get; set; }
		[Ordinal(3)]  [RED("placementTags")] public CArray<CName> PlacementTags { get; set; }
		[Ordinal(4)]  [RED("relativePositions")] public CArray<Vector3> RelativePositions { get; set; }
		[Ordinal(5)]  [RED("relativeRotations")] public CArray<Quaternion> RelativeRotations { get; set; }

		public worldCompiledEffectInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
