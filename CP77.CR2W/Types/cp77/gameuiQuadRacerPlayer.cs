using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiQuadRacerPlayer : gameuiSideScrollerMiniGamePlayerController
	{
		[Ordinal(0)]  [RED("leftFlame")] public inkImageWidgetReference LeftFlame { get; set; }
		[Ordinal(1)]  [RED("leftTireSmoke")] public inkImageWidgetReference LeftTireSmoke { get; set; }
		[Ordinal(2)]  [RED("leftTurnAtlasRegion")] public CName LeftTurnAtlasRegion { get; set; }
		[Ordinal(3)]  [RED("playerImage")] public inkImageWidgetReference PlayerImage { get; set; }
		[Ordinal(4)]  [RED("rightFlame")] public inkImageWidgetReference RightFlame { get; set; }
		[Ordinal(5)]  [RED("rightTireSmoke")] public inkImageWidgetReference RightTireSmoke { get; set; }
		[Ordinal(6)]  [RED("rightTurnAtlasRegion")] public CName RightTurnAtlasRegion { get; set; }
		[Ordinal(7)]  [RED("straightTurnAtlasRegion")] public CName StraightTurnAtlasRegion { get; set; }

		public gameuiQuadRacerPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
