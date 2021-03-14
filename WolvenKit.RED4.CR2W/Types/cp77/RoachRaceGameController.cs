using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RoachRaceGameController : gameuiSideScrollerMiniGameController
	{
		[Ordinal(4)] [RED("gameMenu")] public inkWidgetReference GameMenu { get; set; }
		[Ordinal(5)] [RED("scoreboardMenu")] public inkWidgetReference ScoreboardMenu { get; set; }
		[Ordinal(6)] [RED("isCutsceneInProgress")] public CBool IsCutsceneInProgress { get; set; }

		public RoachRaceGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
