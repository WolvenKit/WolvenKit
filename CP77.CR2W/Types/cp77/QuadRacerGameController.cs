using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuadRacerGameController : gameuiSideScrollerMiniGameController
	{
		[Ordinal(0)]  [RED("gameMenu")] public inkWidgetReference GameMenu { get; set; }
		[Ordinal(1)]  [RED("scoreboardMenu")] public inkWidgetReference ScoreboardMenu { get; set; }

		public QuadRacerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
