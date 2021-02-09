using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class dialogWidgetGameController : InteractionUIBase
	{
		[Ordinal(21)]  [RED("root")] public wCHandle<inkCanvasWidget> Root { get; set; }
		[Ordinal(22)]  [RED("hubsContainer")] public inkBasePanelWidgetReference HubsContainer { get; set; }
		[Ordinal(23)]  [RED("hubControllers")] public CArray<wCHandle<DialogHubLogicController>> HubControllers { get; set; }
		[Ordinal(24)]  [RED("activeHubController")] public CHandle<DialogHubLogicController> ActiveHubController { get; set; }
		[Ordinal(25)]  [RED("data")] public gameinteractionsvisDialogChoiceHubs Data { get; set; }
		[Ordinal(26)]  [RED("activeHubID")] public CInt32 ActiveHubID { get; set; }
		[Ordinal(27)]  [RED("prevActiveHubID")] public CInt32 PrevActiveHubID { get; set; }
		[Ordinal(28)]  [RED("selectedIndex")] public CInt32 SelectedIndex { get; set; }
		[Ordinal(29)]  [RED("fadeAnimTime")] public CFloat FadeAnimTime { get; set; }
		[Ordinal(30)]  [RED("fadeDelay")] public CFloat FadeDelay { get; set; }
		[Ordinal(31)]  [RED("dialogFocusInputHintShown")] public CBool DialogFocusInputHintShown { get; set; }
		[Ordinal(32)]  [RED("hubAvailable")] public CBool HubAvailable { get; set; }
		[Ordinal(33)]  [RED("animCloseHudProxy")] public CHandle<inkanimProxy> AnimCloseHudProxy { get; set; }
		[Ordinal(34)]  [RED("currentFadeItem")] public wCHandle<DialogHubLogicController> CurrentFadeItem { get; set; }
		[Ordinal(35)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(36)]  [RED("uiSystemBB")] public CHandle<UI_SystemDef> UiSystemBB { get; set; }
		[Ordinal(37)]  [RED("uiSystemId")] public CUInt32 UiSystemId { get; set; }

		public dialogWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
