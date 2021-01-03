using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TarotMainGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(1)]  [RED("TooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(2)]  [RED("afterCloseRequest")] public CBool AfterCloseRequest { get; set; }
		[Ordinal(3)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(4)]  [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(5)]  [RED("fullscreenPreviewController")] public CHandle<TarotPreviewGameController> FullscreenPreviewController { get; set; }
		[Ordinal(6)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(7)]  [RED("list")] public inkCompoundWidgetReference List { get; set; }
		[Ordinal(8)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(9)]  [RED("numberOfCardsInTarotDeck")] public CInt32 NumberOfCardsInTarotDeck { get; set; }
		[Ordinal(10)]  [RED("selectedTarotCard")] public wCHandle<tarotCardLogicController> SelectedTarotCard { get; set; }
		[Ordinal(11)]  [RED("tarotPreviewPopupToken")] public CHandle<inkGameNotificationToken> TarotPreviewPopupToken { get; set; }

		public TarotMainGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
