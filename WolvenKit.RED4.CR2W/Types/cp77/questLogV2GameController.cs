using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questLogV2GameController : gameuiMenuGameController
	{
		private inkWidgetReference _questDetailsRef;
		private inkWidgetReference _questDetailsHeader;
		private inkWidgetReference _optinalObjectivesGroupRef;
		private inkWidgetReference _completedObjectivesGroupRef;
		private inkCompoundWidgetReference _questListRef;
		private inkCompoundWidgetReference _objectivesListRef;
		private inkCompoundWidgetReference _optinalObjectivesListRef;
		private inkCompoundWidgetReference _completedObjectivesListRef;
		private inkTextWidgetReference _questTitleRef;
		private inkTextWidgetReference _questDescriptionRef;
		private inkTextWidgetReference _recommendedLevel;
		private inkCompoundWidgetReference _rewardsList;
		private inkCompoundWidgetReference _codexLinksList;
		private inkCompoundWidgetReference _codexEntryParent;
		private inkCompoundWidgetReference _codexButtonRef;
		private inkWidgetReference _buttonHintsManagerRef;
		private redResourceReferenceScriptToken _codexLibraryPath;
		private CName _objectiveViewName;
		private CName _questGroupName;
		private CHandle<JournalWrapper> _journalWrapper;
		private CHandle<QuestDataWrapper> _currentQuestData;
		private CArray<wCHandle<ObjectiveController>> _objectiveItems;
		private CArray<wCHandle<QuestListController>> _questLists;
		private wCHandle<inkListController> _codexLinksListController;
		private wCHandle<inkButtonController> _codexButton;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<ButtonHints> _buttonHintsController;

		[Ordinal(3)] 
		[RED("QuestDetailsRef")] 
		public inkWidgetReference QuestDetailsRef
		{
			get => GetProperty(ref _questDetailsRef);
			set => SetProperty(ref _questDetailsRef, value);
		}

		[Ordinal(4)] 
		[RED("QuestDetailsHeader")] 
		public inkWidgetReference QuestDetailsHeader
		{
			get => GetProperty(ref _questDetailsHeader);
			set => SetProperty(ref _questDetailsHeader, value);
		}

		[Ordinal(5)] 
		[RED("OptinalObjectivesGroupRef")] 
		public inkWidgetReference OptinalObjectivesGroupRef
		{
			get => GetProperty(ref _optinalObjectivesGroupRef);
			set => SetProperty(ref _optinalObjectivesGroupRef, value);
		}

		[Ordinal(6)] 
		[RED("CompletedObjectivesGroupRef")] 
		public inkWidgetReference CompletedObjectivesGroupRef
		{
			get => GetProperty(ref _completedObjectivesGroupRef);
			set => SetProperty(ref _completedObjectivesGroupRef, value);
		}

		[Ordinal(7)] 
		[RED("QuestListRef")] 
		public inkCompoundWidgetReference QuestListRef
		{
			get => GetProperty(ref _questListRef);
			set => SetProperty(ref _questListRef, value);
		}

		[Ordinal(8)] 
		[RED("ObjectivesListRef")] 
		public inkCompoundWidgetReference ObjectivesListRef
		{
			get => GetProperty(ref _objectivesListRef);
			set => SetProperty(ref _objectivesListRef, value);
		}

		[Ordinal(9)] 
		[RED("OptinalObjectivesListRef")] 
		public inkCompoundWidgetReference OptinalObjectivesListRef
		{
			get => GetProperty(ref _optinalObjectivesListRef);
			set => SetProperty(ref _optinalObjectivesListRef, value);
		}

		[Ordinal(10)] 
		[RED("CompletedObjectivesListRef")] 
		public inkCompoundWidgetReference CompletedObjectivesListRef
		{
			get => GetProperty(ref _completedObjectivesListRef);
			set => SetProperty(ref _completedObjectivesListRef, value);
		}

		[Ordinal(11)] 
		[RED("QuestTitleRef")] 
		public inkTextWidgetReference QuestTitleRef
		{
			get => GetProperty(ref _questTitleRef);
			set => SetProperty(ref _questTitleRef, value);
		}

		[Ordinal(12)] 
		[RED("QuestDescriptionRef")] 
		public inkTextWidgetReference QuestDescriptionRef
		{
			get => GetProperty(ref _questDescriptionRef);
			set => SetProperty(ref _questDescriptionRef, value);
		}

		[Ordinal(13)] 
		[RED("recommendedLevel")] 
		public inkTextWidgetReference RecommendedLevel
		{
			get => GetProperty(ref _recommendedLevel);
			set => SetProperty(ref _recommendedLevel, value);
		}

		[Ordinal(14)] 
		[RED("rewardsList")] 
		public inkCompoundWidgetReference RewardsList
		{
			get => GetProperty(ref _rewardsList);
			set => SetProperty(ref _rewardsList, value);
		}

		[Ordinal(15)] 
		[RED("codexLinksList")] 
		public inkCompoundWidgetReference CodexLinksList
		{
			get => GetProperty(ref _codexLinksList);
			set => SetProperty(ref _codexLinksList, value);
		}

		[Ordinal(16)] 
		[RED("CodexEntryParent")] 
		public inkCompoundWidgetReference CodexEntryParent
		{
			get => GetProperty(ref _codexEntryParent);
			set => SetProperty(ref _codexEntryParent, value);
		}

		[Ordinal(17)] 
		[RED("CodexButtonRef")] 
		public inkCompoundWidgetReference CodexButtonRef
		{
			get => GetProperty(ref _codexButtonRef);
			set => SetProperty(ref _codexButtonRef, value);
		}

		[Ordinal(18)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(19)] 
		[RED("codexLibraryPath")] 
		public redResourceReferenceScriptToken CodexLibraryPath
		{
			get => GetProperty(ref _codexLibraryPath);
			set => SetProperty(ref _codexLibraryPath, value);
		}

		[Ordinal(20)] 
		[RED("ObjectiveViewName")] 
		public CName ObjectiveViewName
		{
			get => GetProperty(ref _objectiveViewName);
			set => SetProperty(ref _objectiveViewName, value);
		}

		[Ordinal(21)] 
		[RED("QuestGroupName")] 
		public CName QuestGroupName
		{
			get => GetProperty(ref _questGroupName);
			set => SetProperty(ref _questGroupName, value);
		}

		[Ordinal(22)] 
		[RED("JournalWrapper")] 
		public CHandle<JournalWrapper> JournalWrapper
		{
			get => GetProperty(ref _journalWrapper);
			set => SetProperty(ref _journalWrapper, value);
		}

		[Ordinal(23)] 
		[RED("CurrentQuestData")] 
		public CHandle<QuestDataWrapper> CurrentQuestData
		{
			get => GetProperty(ref _currentQuestData);
			set => SetProperty(ref _currentQuestData, value);
		}

		[Ordinal(24)] 
		[RED("ObjectiveItems")] 
		public CArray<wCHandle<ObjectiveController>> ObjectiveItems
		{
			get => GetProperty(ref _objectiveItems);
			set => SetProperty(ref _objectiveItems, value);
		}

		[Ordinal(25)] 
		[RED("QuestLists")] 
		public CArray<wCHandle<QuestListController>> QuestLists
		{
			get => GetProperty(ref _questLists);
			set => SetProperty(ref _questLists, value);
		}

		[Ordinal(26)] 
		[RED("CodexLinksListController")] 
		public wCHandle<inkListController> CodexLinksListController
		{
			get => GetProperty(ref _codexLinksListController);
			set => SetProperty(ref _codexLinksListController, value);
		}

		[Ordinal(27)] 
		[RED("codexButton")] 
		public wCHandle<inkButtonController> CodexButton
		{
			get => GetProperty(ref _codexButton);
			set => SetProperty(ref _codexButton, value);
		}

		[Ordinal(28)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(29)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		public questLogV2GameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
