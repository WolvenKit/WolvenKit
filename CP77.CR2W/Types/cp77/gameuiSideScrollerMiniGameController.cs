using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("gameplayCanvas")] public inkWidgetReference GameplayCanvas { get; set; }
		[Ordinal(1)]  [RED("gameName")] public CName GameName { get; set; }

		public gameuiSideScrollerMiniGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
