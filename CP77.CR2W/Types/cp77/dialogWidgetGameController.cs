using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class dialogWidgetGameController : InteractionUIBase
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("InteractionsBlackboard")] public CHandle<gameIBlackboard> InteractionsBlackboard { get; set; }
		[Ordinal(8)]  [RED("InteractionsBBDefinition")] public CHandle<UIInteractionsDef> InteractionsBBDefinition { get; set; }
		[Ordinal(9)]  [RED("DialogsDataListenerId")] public CUInt32 DialogsDataListenerId { get; set; }
		[Ordinal(10)]  [RED("DialogsActiveHubListenerId")] public CUInt32 DialogsActiveHubListenerId { get; set; }
		[Ordinal(11)]  [RED("DialogsSelectedChoiceListenerId")] public CUInt32 DialogsSelectedChoiceListenerId { get; set; }
		[Ordinal(12)]  [RED("InteractionsDataListenerId")] public CUInt32 InteractionsDataListenerId { get; set; }
		[Ordinal(13)]  [RED("lootingDataListenerId")] public CUInt32 LootingDataListenerId { get; set; }
		[Ordinal(14)]  [RED("AreDialogsOpen")] public CBool AreDialogsOpen { get; set; }
		[Ordinal(15)]  [RED("AreContactsOpen")] public CBool AreContactsOpen { get; set; }
		[Ordinal(16)]  [RED("IsLootingOpen")] public CBool IsLootingOpen { get; set; }
		[Ordinal(17)]  [RED("AreInteractionsOpen")] public CBool AreInteractionsOpen { get; set; }
		[Ordinal(18)]  [RED("interactionIsScrollable")] public CBool InteractionIsScrollable { get; set; }
		[Ordinal(19)]  [RED("dialogIsScrollable")] public CBool DialogIsScrollable { get; set; }
		[Ordinal(20)]  [RED("lootingIsScrollable")] public CBool LootingIsScrollable { get; set; }
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
