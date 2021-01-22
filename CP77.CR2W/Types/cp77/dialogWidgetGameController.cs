using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class dialogWidgetGameController : InteractionUIBase
	{
		[Ordinal(0)]  [RED("activeHubController")] public CHandle<DialogHubLogicController> ActiveHubController { get; set; }
		[Ordinal(1)]  [RED("activeHubID")] public CInt32 ActiveHubID { get; set; }
		[Ordinal(2)]  [RED("animCloseHudProxy")] public CHandle<inkanimProxy> AnimCloseHudProxy { get; set; }
		[Ordinal(3)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(4)]  [RED("currentFadeItem")] public wCHandle<DialogHubLogicController> CurrentFadeItem { get; set; }
		[Ordinal(5)]  [RED("data")] public gameinteractionsvisDialogChoiceHubs Data { get; set; }
		[Ordinal(6)]  [RED("dialogFocusInputHintShown")] public CBool DialogFocusInputHintShown { get; set; }
		[Ordinal(7)]  [RED("fadeAnimTime")] public CFloat FadeAnimTime { get; set; }
		[Ordinal(8)]  [RED("fadeDelay")] public CFloat FadeDelay { get; set; }
		[Ordinal(9)]  [RED("hubAvailable")] public CBool HubAvailable { get; set; }
		[Ordinal(10)]  [RED("hubControllers")] public CArray<wCHandle<DialogHubLogicController>> HubControllers { get; set; }
		[Ordinal(11)]  [RED("hubsContainer")] public inkBasePanelWidgetReference HubsContainer { get; set; }
		[Ordinal(12)]  [RED("prevActiveHubID")] public CInt32 PrevActiveHubID { get; set; }
		[Ordinal(13)]  [RED("root")] public wCHandle<inkCanvasWidget> Root { get; set; }
		[Ordinal(14)]  [RED("selectedIndex")] public CInt32 SelectedIndex { get; set; }
		[Ordinal(15)]  [RED("uiSystemBB")] public CHandle<UI_SystemDef> UiSystemBB { get; set; }
		[Ordinal(16)]  [RED("uiSystemId")] public CUInt32 UiSystemId { get; set; }

		public dialogWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
