using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractionsHubGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("BotInteractionWidgetsLibraries")] public CArray<inkWidgetLibraryReference> BotInteractionWidgetsLibraries { get; set; }
		[Ordinal(1)]  [RED("BotInteractionsRoot")] public inkWidgetReference BotInteractionsRoot { get; set; }
		[Ordinal(2)]  [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(3)]  [RED("TooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(4)]  [RED("TopInteractionWidgetsLibraries")] public CArray<inkWidgetLibraryReference> TopInteractionWidgetsLibraries { get; set; }
		[Ordinal(5)]  [RED("TopInteractionsRoot")] public inkWidgetReference TopInteractionsRoot { get; set; }

		public InteractionsHubGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
