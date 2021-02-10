using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questLogV2GameController : gameuiMenuGameController
	{
		[Ordinal(1)]  [RED("QuestDetailsRef")] public inkWidgetReference QuestDetailsRef { get; set; }
		[Ordinal(2)]  [RED("QuestDetailsHeader")] public inkWidgetReference QuestDetailsHeader { get; set; }
		[Ordinal(3)]  [RED("OptinalObjectivesGroupRef")] public inkWidgetReference OptinalObjectivesGroupRef { get; set; }
		[Ordinal(4)]  [RED("CompletedObjectivesGroupRef")] public inkWidgetReference CompletedObjectivesGroupRef { get; set; }
		[Ordinal(5)]  [RED("QuestListRef")] public inkCompoundWidgetReference QuestListRef { get; set; }
		[Ordinal(6)]  [RED("ObjectivesListRef")] public inkCompoundWidgetReference ObjectivesListRef { get; set; }
		[Ordinal(7)]  [RED("OptinalObjectivesListRef")] public inkCompoundWidgetReference OptinalObjectivesListRef { get; set; }
		[Ordinal(8)]  [RED("CompletedObjectivesListRef")] public inkCompoundWidgetReference CompletedObjectivesListRef { get; set; }
		[Ordinal(9)]  [RED("QuestTitleRef")] public inkTextWidgetReference QuestTitleRef { get; set; }
		[Ordinal(10)]  [RED("QuestDescriptionRef")] public inkTextWidgetReference QuestDescriptionRef { get; set; }
		[Ordinal(11)]  [RED("recommendedLevel")] public inkTextWidgetReference RecommendedLevel { get; set; }
		[Ordinal(12)]  [RED("rewardsList")] public inkCompoundWidgetReference RewardsList { get; set; }
		[Ordinal(13)]  [RED("codexLinksList")] public inkCompoundWidgetReference CodexLinksList { get; set; }
		[Ordinal(14)]  [RED("CodexEntryParent")] public inkCompoundWidgetReference CodexEntryParent { get; set; }
		[Ordinal(15)]  [RED("CodexButtonRef")] public inkCompoundWidgetReference CodexButtonRef { get; set; }
		[Ordinal(16)]  [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(17)]  [RED("codexLibraryPath")] public redResourceReferenceScriptToken CodexLibraryPath { get; set; }
		[Ordinal(18)]  [RED("ObjectiveViewName")] public CName ObjectiveViewName { get; set; }
		[Ordinal(19)]  [RED("QuestGroupName")] public CName QuestGroupName { get; set; }
		[Ordinal(20)]  [RED("JournalWrapper")] public CHandle<JournalWrapper> JournalWrapper { get; set; }
		[Ordinal(21)]  [RED("CurrentQuestData")] public CHandle<QuestDataWrapper> CurrentQuestData { get; set; }
		[Ordinal(22)]  [RED("ObjectiveItems")] public CArray<wCHandle<ObjectiveController>> ObjectiveItems { get; set; }
		[Ordinal(23)]  [RED("QuestLists")] public CArray<wCHandle<QuestListController>> QuestLists { get; set; }
		[Ordinal(24)]  [RED("CodexLinksListController")] public wCHandle<inkListController> CodexLinksListController { get; set; }
		[Ordinal(25)]  [RED("codexButton")] public wCHandle<inkButtonController> CodexButton { get; set; }
		[Ordinal(26)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(27)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }

		public questLogV2GameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
