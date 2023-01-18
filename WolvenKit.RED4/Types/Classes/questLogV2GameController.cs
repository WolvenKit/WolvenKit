using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questLogV2GameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("QuestDetailsRef")] 
		public inkWidgetReference QuestDetailsRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("QuestDetailsHeader")] 
		public inkWidgetReference QuestDetailsHeader
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("OptinalObjectivesGroupRef")] 
		public inkWidgetReference OptinalObjectivesGroupRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("CompletedObjectivesGroupRef")] 
		public inkWidgetReference CompletedObjectivesGroupRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("QuestListRef")] 
		public inkCompoundWidgetReference QuestListRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("ObjectivesListRef")] 
		public inkCompoundWidgetReference ObjectivesListRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("OptinalObjectivesListRef")] 
		public inkCompoundWidgetReference OptinalObjectivesListRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("CompletedObjectivesListRef")] 
		public inkCompoundWidgetReference CompletedObjectivesListRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("QuestTitleRef")] 
		public inkTextWidgetReference QuestTitleRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("QuestDescriptionRef")] 
		public inkTextWidgetReference QuestDescriptionRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("recommendedLevel")] 
		public inkTextWidgetReference RecommendedLevel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("rewardsList")] 
		public inkCompoundWidgetReference RewardsList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("codexLinksList")] 
		public inkCompoundWidgetReference CodexLinksList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("CodexEntryParent")] 
		public inkCompoundWidgetReference CodexEntryParent
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("CodexButtonRef")] 
		public inkCompoundWidgetReference CodexButtonRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("codexLibraryPath")] 
		public redResourceReferenceScriptToken CodexLibraryPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(20)] 
		[RED("ObjectiveViewName")] 
		public CName ObjectiveViewName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("QuestGroupName")] 
		public CName QuestGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("JournalWrapper")] 
		public CHandle<JournalWrapper> JournalWrapper
		{
			get => GetPropertyValue<CHandle<JournalWrapper>>();
			set => SetPropertyValue<CHandle<JournalWrapper>>(value);
		}

		[Ordinal(23)] 
		[RED("CurrentQuestData")] 
		public CHandle<QuestDataWrapper> CurrentQuestData
		{
			get => GetPropertyValue<CHandle<QuestDataWrapper>>();
			set => SetPropertyValue<CHandle<QuestDataWrapper>>(value);
		}

		[Ordinal(24)] 
		[RED("ObjectiveItems")] 
		public CArray<CWeakHandle<ObjectiveController>> ObjectiveItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<ObjectiveController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<ObjectiveController>>>(value);
		}

		[Ordinal(25)] 
		[RED("QuestLists")] 
		public CArray<CWeakHandle<QuestListController>> QuestLists
		{
			get => GetPropertyValue<CArray<CWeakHandle<QuestListController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<QuestListController>>>(value);
		}

		[Ordinal(26)] 
		[RED("CodexLinksListController")] 
		public CWeakHandle<inkListController> CodexLinksListController
		{
			get => GetPropertyValue<CWeakHandle<inkListController>>();
			set => SetPropertyValue<CWeakHandle<inkListController>>(value);
		}

		[Ordinal(27)] 
		[RED("codexButton")] 
		public CWeakHandle<inkButtonController> CodexButton
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(28)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(29)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		public questLogV2GameController()
		{
			QuestDetailsRef = new();
			QuestDetailsHeader = new();
			OptinalObjectivesGroupRef = new();
			CompletedObjectivesGroupRef = new();
			QuestListRef = new();
			ObjectivesListRef = new();
			OptinalObjectivesListRef = new();
			CompletedObjectivesListRef = new();
			QuestTitleRef = new();
			QuestDescriptionRef = new();
			RecommendedLevel = new();
			RewardsList = new();
			CodexLinksList = new();
			CodexEntryParent = new();
			CodexButtonRef = new();
			ButtonHintsManagerRef = new();
			CodexLibraryPath = new();
			ObjectiveItems = new();
			QuestLists = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
