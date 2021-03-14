using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksMainGameController : gameuiMenuGameController
	{
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkTextWidgetReference _playerLevel;
		private CArray<inkWidgetReference> _centerHiglightParts;
		private inkWidgetReference _attributeSelectorsContainer;
		private inkWidgetReference _perksScreen;
		private inkWidgetReference _pointsDisplay;
		private inkWidgetReference _johnnyConnectorRef;
		private inkWidgetReference _attributeTooltipHolderRight;
		private inkWidgetReference _attributeTooltipHolderLeft;
		private CEnum<CharacterScreenType> _activeScreen;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CHandle<PlayerDevelopmentDataManager> _dataManager;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CArray<CHandle<PerksMenuAttributeItemCreated>> _perksMenuItemCreatedQueue;
		private CArray<wCHandle<PerksMenuAttributeItemController>> _attributesControllersList;
		private CHandle<gameIBlackboard> _playerStatsBlackboard;
		private CUInt32 _characterLevelListener;
		private wCHandle<PerkScreenController> _perksScreenController;
		private wCHandle<PerksPointsDisplayController> _pointsDisplayController;
		private wCHandle<questQuestsSystem> _questSystem;

		[Ordinal(3)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get
			{
				if (_tooltipsManagerRef == null)
				{
					_tooltipsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "tooltipsManagerRef", cr2w, this);
				}
				return _tooltipsManagerRef;
			}
			set
			{
				if (_tooltipsManagerRef == value)
				{
					return;
				}
				_tooltipsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("playerLevel")] 
		public inkTextWidgetReference PlayerLevel
		{
			get
			{
				if (_playerLevel == null)
				{
					_playerLevel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "playerLevel", cr2w, this);
				}
				return _playerLevel;
			}
			set
			{
				if (_playerLevel == value)
				{
					return;
				}
				_playerLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("centerHiglightParts")] 
		public CArray<inkWidgetReference> CenterHiglightParts
		{
			get
			{
				if (_centerHiglightParts == null)
				{
					_centerHiglightParts = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "centerHiglightParts", cr2w, this);
				}
				return _centerHiglightParts;
			}
			set
			{
				if (_centerHiglightParts == value)
				{
					return;
				}
				_centerHiglightParts = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("attributeSelectorsContainer")] 
		public inkWidgetReference AttributeSelectorsContainer
		{
			get
			{
				if (_attributeSelectorsContainer == null)
				{
					_attributeSelectorsContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "attributeSelectorsContainer", cr2w, this);
				}
				return _attributeSelectorsContainer;
			}
			set
			{
				if (_attributeSelectorsContainer == value)
				{
					return;
				}
				_attributeSelectorsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("perksScreen")] 
		public inkWidgetReference PerksScreen
		{
			get
			{
				if (_perksScreen == null)
				{
					_perksScreen = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "perksScreen", cr2w, this);
				}
				return _perksScreen;
			}
			set
			{
				if (_perksScreen == value)
				{
					return;
				}
				_perksScreen = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("pointsDisplay")] 
		public inkWidgetReference PointsDisplay
		{
			get
			{
				if (_pointsDisplay == null)
				{
					_pointsDisplay = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "pointsDisplay", cr2w, this);
				}
				return _pointsDisplay;
			}
			set
			{
				if (_pointsDisplay == value)
				{
					return;
				}
				_pointsDisplay = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("johnnyConnectorRef")] 
		public inkWidgetReference JohnnyConnectorRef
		{
			get
			{
				if (_johnnyConnectorRef == null)
				{
					_johnnyConnectorRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "johnnyConnectorRef", cr2w, this);
				}
				return _johnnyConnectorRef;
			}
			set
			{
				if (_johnnyConnectorRef == value)
				{
					return;
				}
				_johnnyConnectorRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("attributeTooltipHolderRight")] 
		public inkWidgetReference AttributeTooltipHolderRight
		{
			get
			{
				if (_attributeTooltipHolderRight == null)
				{
					_attributeTooltipHolderRight = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "attributeTooltipHolderRight", cr2w, this);
				}
				return _attributeTooltipHolderRight;
			}
			set
			{
				if (_attributeTooltipHolderRight == value)
				{
					return;
				}
				_attributeTooltipHolderRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("attributeTooltipHolderLeft")] 
		public inkWidgetReference AttributeTooltipHolderLeft
		{
			get
			{
				if (_attributeTooltipHolderLeft == null)
				{
					_attributeTooltipHolderLeft = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "attributeTooltipHolderLeft", cr2w, this);
				}
				return _attributeTooltipHolderLeft;
			}
			set
			{
				if (_attributeTooltipHolderLeft == value)
				{
					return;
				}
				_attributeTooltipHolderLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("activeScreen")] 
		public CEnum<CharacterScreenType> ActiveScreen
		{
			get
			{
				if (_activeScreen == null)
				{
					_activeScreen = (CEnum<CharacterScreenType>) CR2WTypeManager.Create("CharacterScreenType", "activeScreen", cr2w, this);
				}
				return _activeScreen;
			}
			set
			{
				if (_activeScreen == value)
				{
					return;
				}
				_activeScreen = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get
			{
				if (_tooltipsManager == null)
				{
					_tooltipsManager = (wCHandle<gameuiTooltipsManager>) CR2WTypeManager.Create("whandle:gameuiTooltipsManager", "tooltipsManager", cr2w, this);
				}
				return _tooltipsManager;
			}
			set
			{
				if (_tooltipsManager == value)
				{
					return;
				}
				_tooltipsManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
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

		[Ordinal(16)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get
			{
				if (_dataManager == null)
				{
					_dataManager = (CHandle<PlayerDevelopmentDataManager>) CR2WTypeManager.Create("handle:PlayerDevelopmentDataManager", "dataManager", cr2w, this);
				}
				return _dataManager;
			}
			set
			{
				if (_dataManager == value)
				{
					return;
				}
				_dataManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
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

		[Ordinal(18)] 
		[RED("perksMenuItemCreatedQueue")] 
		public CArray<CHandle<PerksMenuAttributeItemCreated>> PerksMenuItemCreatedQueue
		{
			get
			{
				if (_perksMenuItemCreatedQueue == null)
				{
					_perksMenuItemCreatedQueue = (CArray<CHandle<PerksMenuAttributeItemCreated>>) CR2WTypeManager.Create("array:handle:PerksMenuAttributeItemCreated", "perksMenuItemCreatedQueue", cr2w, this);
				}
				return _perksMenuItemCreatedQueue;
			}
			set
			{
				if (_perksMenuItemCreatedQueue == value)
				{
					return;
				}
				_perksMenuItemCreatedQueue = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("attributesControllersList")] 
		public CArray<wCHandle<PerksMenuAttributeItemController>> AttributesControllersList
		{
			get
			{
				if (_attributesControllersList == null)
				{
					_attributesControllersList = (CArray<wCHandle<PerksMenuAttributeItemController>>) CR2WTypeManager.Create("array:whandle:PerksMenuAttributeItemController", "attributesControllersList", cr2w, this);
				}
				return _attributesControllersList;
			}
			set
			{
				if (_attributesControllersList == value)
				{
					return;
				}
				_attributesControllersList = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("playerStatsBlackboard")] 
		public CHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get
			{
				if (_playerStatsBlackboard == null)
				{
					_playerStatsBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "playerStatsBlackboard", cr2w, this);
				}
				return _playerStatsBlackboard;
			}
			set
			{
				if (_playerStatsBlackboard == value)
				{
					return;
				}
				_playerStatsBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("characterLevelListener")] 
		public CUInt32 CharacterLevelListener
		{
			get
			{
				if (_characterLevelListener == null)
				{
					_characterLevelListener = (CUInt32) CR2WTypeManager.Create("Uint32", "characterLevelListener", cr2w, this);
				}
				return _characterLevelListener;
			}
			set
			{
				if (_characterLevelListener == value)
				{
					return;
				}
				_characterLevelListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("perksScreenController")] 
		public wCHandle<PerkScreenController> PerksScreenController
		{
			get
			{
				if (_perksScreenController == null)
				{
					_perksScreenController = (wCHandle<PerkScreenController>) CR2WTypeManager.Create("whandle:PerkScreenController", "perksScreenController", cr2w, this);
				}
				return _perksScreenController;
			}
			set
			{
				if (_perksScreenController == value)
				{
					return;
				}
				_perksScreenController = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("pointsDisplayController")] 
		public wCHandle<PerksPointsDisplayController> PointsDisplayController
		{
			get
			{
				if (_pointsDisplayController == null)
				{
					_pointsDisplayController = (wCHandle<PerksPointsDisplayController>) CR2WTypeManager.Create("whandle:PerksPointsDisplayController", "pointsDisplayController", cr2w, this);
				}
				return _pointsDisplayController;
			}
			set
			{
				if (_pointsDisplayController == value)
				{
					return;
				}
				_pointsDisplayController = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("questSystem")] 
		public wCHandle<questQuestsSystem> QuestSystem
		{
			get
			{
				if (_questSystem == null)
				{
					_questSystem = (wCHandle<questQuestsSystem>) CR2WTypeManager.Create("whandle:questQuestsSystem", "questSystem", cr2w, this);
				}
				return _questSystem;
			}
			set
			{
				if (_questSystem == value)
				{
					return;
				}
				_questSystem = value;
				PropertySet(this);
			}
		}

		public PerksMainGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
