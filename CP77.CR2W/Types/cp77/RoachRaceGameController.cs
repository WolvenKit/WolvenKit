using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RoachRaceGameController : gameuiSideScrollerMiniGameController
	{
		[Ordinal(0)]  [RED("gameMenu")] public inkWidgetReference GameMenu { get; set; }
		[Ordinal(1)]  [RED("isCutsceneInProgress")] public CBool IsCutsceneInProgress { get; set; }
		[Ordinal(2)]  [RED("scoreboardMenu")] public inkWidgetReference ScoreboardMenu { get; set; }

		public RoachRaceGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
