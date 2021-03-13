using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractionsHubGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("TopInteractionWidgetsLibraries")] public CArray<inkWidgetLibraryReference> TopInteractionWidgetsLibraries { get; set; }
		[Ordinal(10)] [RED("TopInteractionsRoot")] public inkWidgetReference TopInteractionsRoot { get; set; }
		[Ordinal(11)] [RED("BotInteractionWidgetsLibraries")] public CArray<inkWidgetLibraryReference> BotInteractionWidgetsLibraries { get; set; }
		[Ordinal(12)] [RED("BotInteractionsRoot")] public inkWidgetReference BotInteractionsRoot { get; set; }
		[Ordinal(13)] [RED("TooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(14)] [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }

		public InteractionsHubGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
