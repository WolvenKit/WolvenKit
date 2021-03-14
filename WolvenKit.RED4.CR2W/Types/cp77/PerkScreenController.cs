using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkScreenController : inkWidgetLogicController
	{
		private inkWidgetReference _hubSelector;
		private inkCompoundWidgetReference _connectionLinesContainer;
		private inkCompoundWidgetReference _boughtConnectionLinesContainer;
		private inkCompoundWidgetReference _maxedConnectionLinesContainer;
		private inkCanvasWidgetReference _boughtMaskContainer;
		private inkCanvasWidgetReference _maxedMaskContainer;
		private inkTextWidgetReference _attributeNameText;
		private inkTextWidgetReference _attributeLevelText;
		private inkWidgetReference _levelControllerRef;
		private inkWidgetReference _rewardsControllerRef;
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _proficiencyRootRef;
		private CHandle<PlayerDevelopmentDataManager> _dataManager;
		private CHandle<AttributeDisplayData> _displayData;
		private CHandle<TabRadioGroup> _proficiencyRoot;
		private CArray<wCHandle<PerkDisplayContainerController>> _widgetMap;
		private CHandle<PerkDisplayContainerController> _traitController;
		private CInt32 _currentIndex;
		private CArrayFixedSize<CInt32> _connectionLines;
		private CHandle<StatsProgressController> _levelController;
		private CHandle<StatsStreetCredReward> _rewardsController;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;

		[Ordinal(1)] 
		[RED("hubSelector")] 
		public inkWidgetReference HubSelector
		{
			get
			{
				if (_hubSelector == null)
				{
					_hubSelector = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "hubSelector", cr2w, this);
				}
				return _hubSelector;
			}
			set
			{
				if (_hubSelector == value)
				{
					return;
				}
				_hubSelector = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("connectionLinesContainer")] 
		public inkCompoundWidgetReference ConnectionLinesContainer
		{
			get
			{
				if (_connectionLinesContainer == null)
				{
					_connectionLinesContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "connectionLinesContainer", cr2w, this);
				}
				return _connectionLinesContainer;
			}
			set
			{
				if (_connectionLinesContainer == value)
				{
					return;
				}
				_connectionLinesContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("boughtConnectionLinesContainer")] 
		public inkCompoundWidgetReference BoughtConnectionLinesContainer
		{
			get
			{
				if (_boughtConnectionLinesContainer == null)
				{
					_boughtConnectionLinesContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "boughtConnectionLinesContainer", cr2w, this);
				}
				return _boughtConnectionLinesContainer;
			}
			set
			{
				if (_boughtConnectionLinesContainer == value)
				{
					return;
				}
				_boughtConnectionLinesContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maxedConnectionLinesContainer")] 
		public inkCompoundWidgetReference MaxedConnectionLinesContainer
		{
			get
			{
				if (_maxedConnectionLinesContainer == null)
				{
					_maxedConnectionLinesContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "maxedConnectionLinesContainer", cr2w, this);
				}
				return _maxedConnectionLinesContainer;
			}
			set
			{
				if (_maxedConnectionLinesContainer == value)
				{
					return;
				}
				_maxedConnectionLinesContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("boughtMaskContainer")] 
		public inkCanvasWidgetReference BoughtMaskContainer
		{
			get
			{
				if (_boughtMaskContainer == null)
				{
					_boughtMaskContainer = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "boughtMaskContainer", cr2w, this);
				}
				return _boughtMaskContainer;
			}
			set
			{
				if (_boughtMaskContainer == value)
				{
					return;
				}
				_boughtMaskContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("maxedMaskContainer")] 
		public inkCanvasWidgetReference MaxedMaskContainer
		{
			get
			{
				if (_maxedMaskContainer == null)
				{
					_maxedMaskContainer = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "maxedMaskContainer", cr2w, this);
				}
				return _maxedMaskContainer;
			}
			set
			{
				if (_maxedMaskContainer == value)
				{
					return;
				}
				_maxedMaskContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("attributeNameText")] 
		public inkTextWidgetReference AttributeNameText
		{
			get
			{
				if (_attributeNameText == null)
				{
					_attributeNameText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "attributeNameText", cr2w, this);
				}
				return _attributeNameText;
			}
			set
			{
				if (_attributeNameText == value)
				{
					return;
				}
				_attributeNameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("attributeLevelText")] 
		public inkTextWidgetReference AttributeLevelText
		{
			get
			{
				if (_attributeLevelText == null)
				{
					_attributeLevelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "attributeLevelText", cr2w, this);
				}
				return _attributeLevelText;
			}
			set
			{
				if (_attributeLevelText == value)
				{
					return;
				}
				_attributeLevelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("levelControllerRef")] 
		public inkWidgetReference LevelControllerRef
		{
			get
			{
				if (_levelControllerRef == null)
				{
					_levelControllerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "levelControllerRef", cr2w, this);
				}
				return _levelControllerRef;
			}
			set
			{
				if (_levelControllerRef == value)
				{
					return;
				}
				_levelControllerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("rewardsControllerRef")] 
		public inkWidgetReference RewardsControllerRef
		{
			get
			{
				if (_rewardsControllerRef == null)
				{
					_rewardsControllerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rewardsControllerRef", cr2w, this);
				}
				return _rewardsControllerRef;
			}
			set
			{
				if (_rewardsControllerRef == value)
				{
					return;
				}
				_rewardsControllerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get
			{
				if (_tooltipsManagerRef == null)
				{
					_tooltipsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "TooltipsManagerRef", cr2w, this);
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

		[Ordinal(12)] 
		[RED("proficiencyRootRef")] 
		public inkWidgetReference ProficiencyRootRef
		{
			get
			{
				if (_proficiencyRootRef == null)
				{
					_proficiencyRootRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "proficiencyRootRef", cr2w, this);
				}
				return _proficiencyRootRef;
			}
			set
			{
				if (_proficiencyRootRef == value)
				{
					return;
				}
				_proficiencyRootRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
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

		[Ordinal(14)] 
		[RED("displayData")] 
		public CHandle<AttributeDisplayData> DisplayData
		{
			get
			{
				if (_displayData == null)
				{
					_displayData = (CHandle<AttributeDisplayData>) CR2WTypeManager.Create("handle:AttributeDisplayData", "displayData", cr2w, this);
				}
				return _displayData;
			}
			set
			{
				if (_displayData == value)
				{
					return;
				}
				_displayData = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("proficiencyRoot")] 
		public CHandle<TabRadioGroup> ProficiencyRoot
		{
			get
			{
				if (_proficiencyRoot == null)
				{
					_proficiencyRoot = (CHandle<TabRadioGroup>) CR2WTypeManager.Create("handle:TabRadioGroup", "proficiencyRoot", cr2w, this);
				}
				return _proficiencyRoot;
			}
			set
			{
				if (_proficiencyRoot == value)
				{
					return;
				}
				_proficiencyRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("widgetMap")] 
		public CArray<wCHandle<PerkDisplayContainerController>> WidgetMap
		{
			get
			{
				if (_widgetMap == null)
				{
					_widgetMap = (CArray<wCHandle<PerkDisplayContainerController>>) CR2WTypeManager.Create("array:whandle:PerkDisplayContainerController", "widgetMap", cr2w, this);
				}
				return _widgetMap;
			}
			set
			{
				if (_widgetMap == value)
				{
					return;
				}
				_widgetMap = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("traitController")] 
		public CHandle<PerkDisplayContainerController> TraitController
		{
			get
			{
				if (_traitController == null)
				{
					_traitController = (CHandle<PerkDisplayContainerController>) CR2WTypeManager.Create("handle:PerkDisplayContainerController", "traitController", cr2w, this);
				}
				return _traitController;
			}
			set
			{
				if (_traitController == value)
				{
					return;
				}
				_traitController = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get
			{
				if (_currentIndex == null)
				{
					_currentIndex = (CInt32) CR2WTypeManager.Create("Int32", "currentIndex", cr2w, this);
				}
				return _currentIndex;
			}
			set
			{
				if (_currentIndex == value)
				{
					return;
				}
				_currentIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("connectionLines", 45)] 
		public CArrayFixedSize<CInt32> ConnectionLines
		{
			get
			{
				if (_connectionLines == null)
				{
					_connectionLines = (CArrayFixedSize<CInt32>) CR2WTypeManager.Create("[45]Int32", "connectionLines", cr2w, this);
				}
				return _connectionLines;
			}
			set
			{
				if (_connectionLines == value)
				{
					return;
				}
				_connectionLines = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("levelController")] 
		public CHandle<StatsProgressController> LevelController
		{
			get
			{
				if (_levelController == null)
				{
					_levelController = (CHandle<StatsProgressController>) CR2WTypeManager.Create("handle:StatsProgressController", "levelController", cr2w, this);
				}
				return _levelController;
			}
			set
			{
				if (_levelController == value)
				{
					return;
				}
				_levelController = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("rewardsController")] 
		public CHandle<StatsStreetCredReward> RewardsController
		{
			get
			{
				if (_rewardsController == null)
				{
					_rewardsController = (CHandle<StatsStreetCredReward>) CR2WTypeManager.Create("handle:StatsStreetCredReward", "rewardsController", cr2w, this);
				}
				return _rewardsController;
			}
			set
			{
				if (_rewardsController == value)
				{
					return;
				}
				_rewardsController = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
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

		public PerkScreenController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
