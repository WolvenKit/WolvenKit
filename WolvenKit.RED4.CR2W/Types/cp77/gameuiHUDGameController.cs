using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHUDGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(3)] [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(4)] [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(5)] [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(6)] [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(7)] [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(8)] [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }

		public gameuiHUDGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
