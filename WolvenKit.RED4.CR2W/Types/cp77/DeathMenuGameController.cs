using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeathMenuGameController : gameuiMenuItemListGameController
	{
		[Ordinal(6)] [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(7)] [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(8)] [RED("loadComplete")] public CBool LoadComplete { get; set; }
		[Ordinal(9)] [RED("animIntro")] public CHandle<inkanimProxy> AnimIntro { get; set; }

		public DeathMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
