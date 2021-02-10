using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractionsHubGameController : gameuiHUDGameController
	{
		[Ordinal(7)]  [RED("TopInteractionWidgetsLibraries")] public CArray<inkWidgetLibraryReference> TopInteractionWidgetsLibraries { get; set; }
		[Ordinal(8)]  [RED("TopInteractionsRoot")] public inkWidgetReference TopInteractionsRoot { get; set; }
		[Ordinal(9)]  [RED("BotInteractionWidgetsLibraries")] public CArray<inkWidgetLibraryReference> BotInteractionWidgetsLibraries { get; set; }
		[Ordinal(10)]  [RED("BotInteractionsRoot")] public inkWidgetReference BotInteractionsRoot { get; set; }
		[Ordinal(11)]  [RED("TooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(12)]  [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }

		public InteractionsHubGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
