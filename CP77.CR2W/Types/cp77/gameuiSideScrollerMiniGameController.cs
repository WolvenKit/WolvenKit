using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("gameName")] public CName GameName { get; set; }
		[Ordinal(1)]  [RED("gameplayCanvas")] public inkWidgetReference GameplayCanvas { get; set; }

		public gameuiSideScrollerMiniGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
