using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiQuadRacerRoad : gameuiSideScrollerMiniGameDynObjectLogic
	{
		[Ordinal(0)]  [RED("roadQuad")] public inkQuadWidgetReference RoadQuad { get; set; }
		[Ordinal(1)]  [RED("leftBackground")] public inkQuadWidgetReference LeftBackground { get; set; }
		[Ordinal(2)]  [RED("rightBackground")] public inkQuadWidgetReference RightBackground { get; set; }
		[Ordinal(3)]  [RED("groundParts")] public CArray<CName> GroundParts { get; set; }
		[Ordinal(4)]  [RED("roadParts")] public CArray<CName> RoadParts { get; set; }

		public gameuiQuadRacerRoad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
