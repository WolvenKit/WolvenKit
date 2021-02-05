using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractionsHubGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("TopInteractionWidgetsLibraries")] public CArray<inkWidgetLibraryReference> TopInteractionWidgetsLibraries { get; set; }
		[Ordinal(8)]  [RED("TopInteractionsRoot")] public inkWidgetReference TopInteractionsRoot { get; set; }
		[Ordinal(9)]  [RED("BotInteractionWidgetsLibraries")] public CArray<inkWidgetLibraryReference> BotInteractionWidgetsLibraries { get; set; }
		[Ordinal(10)]  [RED("BotInteractionsRoot")] public inkWidgetReference BotInteractionsRoot { get; set; }
		[Ordinal(11)]  [RED("TooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(12)]  [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }

		public InteractionsHubGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
