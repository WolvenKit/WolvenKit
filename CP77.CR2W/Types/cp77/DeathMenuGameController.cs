using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DeathMenuGameController : gameuiMenuItemListGameController
	{
		[Ordinal(4)]  [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(5)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(6)]  [RED("loadComplete")] public CBool LoadComplete { get; set; }
		[Ordinal(7)]  [RED("animIntro")] public CHandle<inkanimProxy> AnimIntro { get; set; }

		public DeathMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
