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
			get
			{
				if (_questDetailsRef == null)
				{
					_questDetailsRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "QuestDetailsRef", cr2w, this);
				}
				return _questDetailsRef;
			}
			set
			{
				if (_questDetailsRef == value)
				{
					return;
				}
				_questDetailsRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("QuestDetailsHeader")] 
		public inkWidgetReference QuestDetailsHeader
		{
			get
			{
				if (_questDetailsHeader == null)
				{
					_questDetailsHeader = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "QuestDetailsHeader", cr2w, this);
				}
				return _questDetailsHeader;
			}
			set
			{
				if (_questDetailsHeader == value)
				{
					return;
				}
				_questDetailsHeader = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("OptinalObjectivesGroupRef")] 
		public inkWidgetReference OptinalObjectivesGroupRef
		{
			get
			{
				if (_optinalObjectivesGroupRef == null)
				{
					_optinalObjectivesGroupRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "OptinalObjectivesGroupRef", cr2w, this);
				}
				return _optinalObjectivesGroupRef;
			}
			set
			{
				if (_optinalObjectivesGroupRef == value)
				{
					return;
				}
				_optinalObjectivesGroupRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("CompletedObjectivesGroupRef")] 
		public inkWidgetReference CompletedObjectivesGroupRef
		{
			get
			{
				if (_completedObjectivesGroupRef == null)
				{
					_completedObjectivesGroupRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "CompletedObjectivesGroupRef", cr2w, this);
				}
				return _completedObjectivesGroupRef;
			}
			set
			{
				if (_completedObjectivesGroupRef == value)
				{
					return;
				}
				_completedObjectivesGroupRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("QuestListRef")] 
		public inkCompoundWidgetReference QuestListRef
		{
			get
			{
				if (_questListRef == null)
				{
					_questListRef = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "QuestListRef", cr2w, this);
				}
				return _questListRef;
			}
			set
			{
				if (_questListRef == value)
				{
					return;
				}
				_questListRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("ObjectivesListRef")] 
		public inkCompoundWidgetReference ObjectivesListRef
		{
			get
			{
				if (_objectivesListRef == null)
				{
					_objectivesListRef = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "ObjectivesListRef", cr2w, this);
				}
				return _objectivesListRef;
			}
			set
			{
				if (_objectivesListRef == value)
				{
					return;
				}
				_objectivesListRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("OptinalObjectivesListRef")] 
		public inkCompoundWidgetReference OptinalObjectivesListRef
		{
			get
			{
				if (_optinalObjectivesListRef == null)
				{
					_optinalObjectivesListRef = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "OptinalObjectivesListRef", cr2w, this);
				}
				return _optinalObjectivesListRef;
			}
			set
			{
				if (_optinalObjectivesListRef == value)
				{
					return;
				}
				_optinalObjectivesListRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("CompletedObjectivesListRef")] 
		public inkCompoundWidgetReference CompletedObjectivesListRef
		{
			get
			{
				if (_completedObjectivesListRef == null)
				{
					_completedObjectivesListRef = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "CompletedObjectivesListRef", cr2w, this);
				}
				return _completedObjectivesListRef;
			}
			set
			{
				if (_completedObjectivesListRef == value)
				{
					return;
				}
				_completedObjectivesListRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("QuestTitleRef")] 
		public inkTextWidgetReference QuestTitleRef
		{
			get
			{
				if (_questTitleRef == null)
				{
					_questTitleRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "QuestTitleRef", cr2w, this);
				}
				return _questTitleRef;
			}
			set
			{
				if (_questTitleRef == value)
				{
					return;
				}
				_questTitleRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("QuestDescriptionRef")] 
		public inkTextWidgetReference QuestDescriptionRef
		{
			get
			{
				if (_questDescriptionRef == null)
				{
					_questDescriptionRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "QuestDescriptionRef", cr2w, this);
				}
				return _questDescriptionRef;
			}
			set
			{
				if (_questDescriptionRef == value)
				{
					return;
				}
				_questDescriptionRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("recommendedLevel")] 
		public inkTextWidgetReference RecommendedLevel
		{
			get
			{
				if (_recommendedLevel == null)
				{
					_recommendedLevel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "recommendedLevel", cr2w, this);
				}
				return _recommendedLevel;
			}
			set
			{
				if (_recommendedLevel == value)
				{
					return;
				}
				_recommendedLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("rewardsList")] 
		public inkCompoundWidgetReference RewardsList
		{
			get
			{
				if (_rewardsList == null)
				{
					_rewardsList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "rewardsList", cr2w, this);
				}
				return _rewardsList;
			}
			set
			{
				if (_rewardsList == value)
				{
					return;
				}
				_rewardsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("codexLinksList")] 
		public inkCompoundWidgetReference CodexLinksList
		{
			get
			{
				if (_codexLinksList == null)
				{
					_codexLinksList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "codexLinksList", cr2w, this);
				}
				return _codexLinksList;
			}
			set
			{
				if (_codexLinksList == value)
				{
					return;
				}
				_codexLinksList = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("CodexEntryParent")] 
		public inkCompoundWidgetReference CodexEntryParent
		{
			get
			{
				if (_codexEntryParent == null)
				{
					_codexEntryParent = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "CodexEntryParent", cr2w, this);
				}
				return _codexEntryParent;
			}
			set
			{
				if (_codexEntryParent == value)
				{
					return;
				}
				_codexEntryParent = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("CodexButtonRef")] 
		public inkCompoundWidgetReference CodexButtonRef
		{
			get
			{
				if (_codexButtonRef == null)
				{
					_codexButtonRef = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "CodexButtonRef", cr2w, this);
				}
				return _codexButtonRef;
			}
			set
			{
				if (_codexButtonRef == value)
				{
					return;
				}
				_codexButtonRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get
			{
				if (_buttonHintsManagerRef == null)
				{
					_buttonHintsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHintsManagerRef", cr2w, this);
				}
				return _buttonHintsManagerRef;
			}
			set
			{
				if (_buttonHintsManagerRef == value)
				{
					return;
				}
				_buttonHintsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("codexLibraryPath")] 
		public redResourceReferenceScriptToken CodexLibraryPath
		{
			get
			{
				if (_codexLibraryPath == null)
				{
					_codexLibraryPath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "codexLibraryPath", cr2w, this);
				}
				return _codexLibraryPath;
			}
			set
			{
				if (_codexLibraryPath == value)
				{
					return;
				}
				_codexLibraryPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("ObjectiveViewName")] 
		public CName ObjectiveViewName
		{
			get
			{
				if (_objectiveViewName == null)
				{
					_objectiveViewName = (CName) CR2WTypeManager.Create("CName", "ObjectiveViewName", cr2w, this);
				}
				return _objectiveViewName;
			}
			set
			{
				if (_objectiveViewName == value)
				{
					return;
				}
				_objectiveViewName = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("QuestGroupName")] 
		public CName QuestGroupName
		{
			get
			{
				if (_questGroupName == null)
				{
					_questGroupName = (CName) CR2WTypeManager.Create("CName", "QuestGroupName", cr2w, this);
				}
				return _questGroupName;
			}
			set
			{
				if (_questGroupName == value)
				{
					return;
				}
				_questGroupName = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("JournalWrapper")] 
		public CHandle<JournalWrapper> JournalWrapper
		{
			get
			{
				if (_journalWrapper == null)
				{
					_journalWrapper = (CHandle<JournalWrapper>) CR2WTypeManager.Create("handle:JournalWrapper", "JournalWrapper", cr2w, this);
				}
				return _journalWrapper;
			}
			set
			{
				if (_journalWrapper == value)
				{
					return;
				}
				_journalWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("CurrentQuestData")] 
		public CHandle<QuestDataWrapper> CurrentQuestData
		{
			get
			{
				if (_currentQuestData == null)
				{
					_currentQuestData = (CHandle<QuestDataWrapper>) CR2WTypeManager.Create("handle:QuestDataWrapper", "CurrentQuestData", cr2w, this);
				}
				return _currentQuestData;
			}
			set
			{
				if (_currentQuestData == value)
				{
					return;
				}
				_currentQuestData = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("ObjectiveItems")] 
		public CArray<wCHandle<ObjectiveController>> ObjectiveItems
		{
			get
			{
				if (_objectiveItems == null)
				{
					_objectiveItems = (CArray<wCHandle<ObjectiveController>>) CR2WTypeManager.Create("array:whandle:ObjectiveController", "ObjectiveItems", cr2w, this);
				}
				return _objectiveItems;
			}
			set
			{
				if (_objectiveItems == value)
				{
					return;
				}
				_objectiveItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("QuestLists")] 
		public CArray<wCHandle<QuestListController>> QuestLists
		{
			get
			{
				if (_questLists == null)
				{
					_questLists = (CArray<wCHandle<QuestListController>>) CR2WTypeManager.Create("array:whandle:QuestListController", "QuestLists", cr2w, this);
				}
				return _questLists;
			}
			set
			{
				if (_questLists == value)
				{
					return;
				}
				_questLists = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("CodexLinksListController")] 
		public wCHandle<inkListController> CodexLinksListController
		{
			get
			{
				if (_codexLinksListController == null)
				{
					_codexLinksListController = (wCHandle<inkListController>) CR2WTypeManager.Create("whandle:inkListController", "CodexLinksListController", cr2w, this);
				}
				return _codexLinksListController;
			}
			set
			{
				if (_codexLinksListController == value)
				{
					return;
				}
				_codexLinksListController = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("codexButton")] 
		public wCHandle<inkButtonController> CodexButton
		{
			get
			{
				if (_codexButton == null)
				{
					_codexButton = (wCHandle<inkButtonController>) CR2WTypeManager.Create("whandle:inkButtonController", "codexButton", cr2w, this);
				}
				return _codexButton;
			}
			set
			{
				if (_codexButton == value)
				{
					return;
				}
				_codexButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get
			{
				if (_menuEventDispatcher == null)
				{
					_menuEventDispatcher = (wCHandle<inkMenuEventDispatcher>) CR2WTypeManager.Create("whandle:inkMenuEventDispatcher", "menuEventDispatcher", cr2w, this);
				}
				return _menuEventDispatcher;
			}
			set
			{
				if (_menuEventDispatcher == value)
				{
					return;
				}
				_menuEventDispatcher = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get
			{
				if (_buttonHintsController == null)
				{
					_buttonHintsController = (wCHandle<ButtonHints>) CR2WTypeManager.Create("whandle:ButtonHints", "buttonHintsController", cr2w, this);
				}
				return _buttonHintsController;
			}
			set
			{
				if (_buttonHintsController == value)
				{
					return;
				}
				_buttonHintsController = value;
				PropertySet(this);
			}
		}

		public questLogV2GameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
