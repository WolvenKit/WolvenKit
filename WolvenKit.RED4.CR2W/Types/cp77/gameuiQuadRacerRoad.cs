using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiQuadRacerRoad : gameuiSideScrollerMiniGameDynObjectLogic
	{
		[Ordinal(2)] [RED("roadQuad")] public inkQuadWidgetReference RoadQuad { get; set; }
		[Ordinal(3)] [RED("leftBackground")] public inkQuadWidgetReference LeftBackground { get; set; }
		[Ordinal(4)] [RED("rightBackground")] public inkQuadWidgetReference RightBackground { get; set; }
		[Ordinal(5)] [RED("groundParts")] public CArray<CName> GroundParts { get; set; }
		[Ordinal(6)] [RED("roadParts")] public CArray<CName> RoadParts { get; set; }

		public gameuiQuadRacerRoad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
