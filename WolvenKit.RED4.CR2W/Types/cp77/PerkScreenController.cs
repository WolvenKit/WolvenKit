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
		private inkTextWidgetReference _proficiencyDescriptionText;
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
			get => GetProperty(ref _hubSelector);
			set => SetProperty(ref _hubSelector, value);
		}

		[Ordinal(2)] 
		[RED("connectionLinesContainer")] 
		public inkCompoundWidgetReference ConnectionLinesContainer
		{
			get => GetProperty(ref _connectionLinesContainer);
			set => SetProperty(ref _connectionLinesContainer, value);
		}

		[Ordinal(3)] 
		[RED("boughtConnectionLinesContainer")] 
		public inkCompoundWidgetReference BoughtConnectionLinesContainer
		{
			get => GetProperty(ref _boughtConnectionLinesContainer);
			set => SetProperty(ref _boughtConnectionLinesContainer, value);
		}

		[Ordinal(4)] 
		[RED("maxedConnectionLinesContainer")] 
		public inkCompoundWidgetReference MaxedConnectionLinesContainer
		{
			get => GetProperty(ref _maxedConnectionLinesContainer);
			set => SetProperty(ref _maxedConnectionLinesContainer, value);
		}

		[Ordinal(5)] 
		[RED("boughtMaskContainer")] 
		public inkCanvasWidgetReference BoughtMaskContainer
		{
			get => GetProperty(ref _boughtMaskContainer);
			set => SetProperty(ref _boughtMaskContainer, value);
		}

		[Ordinal(6)] 
		[RED("maxedMaskContainer")] 
		public inkCanvasWidgetReference MaxedMaskContainer
		{
			get => GetProperty(ref _maxedMaskContainer);
			set => SetProperty(ref _maxedMaskContainer, value);
		}

		[Ordinal(7)] 
		[RED("attributeNameText")] 
		public inkTextWidgetReference AttributeNameText
		{
			get => GetProperty(ref _attributeNameText);
			set => SetProperty(ref _attributeNameText, value);
		}

		[Ordinal(8)] 
		[RED("attributeLevelText")] 
		public inkTextWidgetReference AttributeLevelText
		{
			get => GetProperty(ref _attributeLevelText);
			set => SetProperty(ref _attributeLevelText, value);
		}

		[Ordinal(9)] 
		[RED("levelControllerRef")] 
		public inkWidgetReference LevelControllerRef
		{
			get => GetProperty(ref _levelControllerRef);
			set => SetProperty(ref _levelControllerRef, value);
		}

		[Ordinal(10)] 
		[RED("rewardsControllerRef")] 
		public inkWidgetReference RewardsControllerRef
		{
			get => GetProperty(ref _rewardsControllerRef);
			set => SetProperty(ref _rewardsControllerRef, value);
		}

		[Ordinal(11)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(12)] 
		[RED("proficiencyRootRef")] 
		public inkWidgetReference ProficiencyRootRef
		{
			get => GetProperty(ref _proficiencyRootRef);
			set => SetProperty(ref _proficiencyRootRef, value);
		}

		[Ordinal(13)] 
		[RED("proficiencyDescriptionText")] 
		public inkTextWidgetReference ProficiencyDescriptionText
		{
			get => GetProperty(ref _proficiencyDescriptionText);
			set => SetProperty(ref _proficiencyDescriptionText, value);
		}

		[Ordinal(14)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetProperty(ref _dataManager);
			set => SetProperty(ref _dataManager, value);
		}

		[Ordinal(15)] 
		[RED("displayData")] 
		public CHandle<AttributeDisplayData> DisplayData
		{
			get => GetProperty(ref _displayData);
			set => SetProperty(ref _displayData, value);
		}

		[Ordinal(16)] 
		[RED("proficiencyRoot")] 
		public CHandle<TabRadioGroup> ProficiencyRoot
		{
			get => GetProperty(ref _proficiencyRoot);
			set => SetProperty(ref _proficiencyRoot, value);
		}

		[Ordinal(17)] 
		[RED("widgetMap")] 
		public CArray<wCHandle<PerkDisplayContainerController>> WidgetMap
		{
			get => GetProperty(ref _widgetMap);
			set => SetProperty(ref _widgetMap, value);
		}

		[Ordinal(18)] 
		[RED("traitController")] 
		public CHandle<PerkDisplayContainerController> TraitController
		{
			get => GetProperty(ref _traitController);
			set => SetProperty(ref _traitController, value);
		}

		[Ordinal(19)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get => GetProperty(ref _currentIndex);
			set => SetProperty(ref _currentIndex, value);
		}

		[Ordinal(20)] 
		[RED("connectionLines", 45)] 
		public CArrayFixedSize<CInt32> ConnectionLines
		{
			get => GetProperty(ref _connectionLines);
			set => SetProperty(ref _connectionLines, value);
		}

		[Ordinal(21)] 
		[RED("levelController")] 
		public CHandle<StatsProgressController> LevelController
		{
			get => GetProperty(ref _levelController);
			set => SetProperty(ref _levelController, value);
		}

		[Ordinal(22)] 
		[RED("rewardsController")] 
		public CHandle<StatsStreetCredReward> RewardsController
		{
			get => GetProperty(ref _rewardsController);
			set => SetProperty(ref _rewardsController, value);
		}

		[Ordinal(23)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		public PerkScreenController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
