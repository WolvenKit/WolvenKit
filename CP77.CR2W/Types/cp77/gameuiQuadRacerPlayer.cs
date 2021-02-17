using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiQuadRacerPlayer : gameuiSideScrollerMiniGamePlayerController
	{
		[Ordinal(1)] [RED("playerImage")] public inkImageWidgetReference PlayerImage { get; set; }
		[Ordinal(2)] [RED("leftTireSmoke")] public inkImageWidgetReference LeftTireSmoke { get; set; }
		[Ordinal(3)] [RED("rightTireSmoke")] public inkImageWidgetReference RightTireSmoke { get; set; }
		[Ordinal(4)] [RED("rightFlame")] public inkImageWidgetReference RightFlame { get; set; }
		[Ordinal(5)] [RED("leftFlame")] public inkImageWidgetReference LeftFlame { get; set; }
		[Ordinal(6)] [RED("leftTurnAtlasRegion")] public CName LeftTurnAtlasRegion { get; set; }
		[Ordinal(7)] [RED("rightTurnAtlasRegion")] public CName RightTurnAtlasRegion { get; set; }
		[Ordinal(8)] [RED("straightTurnAtlasRegion")] public CName StraightTurnAtlasRegion { get; set; }

		public gameuiQuadRacerPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
