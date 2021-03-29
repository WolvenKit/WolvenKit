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
		private inkWidgetReference _resetPerks;
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
		private CHandle<inkGameNotificationToken> _resetConfirmationToken;

		[Ordinal(3)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(4)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(5)] 
		[RED("playerLevel")] 
		public inkTextWidgetReference PlayerLevel
		{
			get => GetProperty(ref _playerLevel);
			set => SetProperty(ref _playerLevel, value);
		}

		[Ordinal(6)] 
		[RED("centerHiglightParts")] 
		public CArray<inkWidgetReference> CenterHiglightParts
		{
			get => GetProperty(ref _centerHiglightParts);
			set => SetProperty(ref _centerHiglightParts, value);
		}

		[Ordinal(7)] 
		[RED("attributeSelectorsContainer")] 
		public inkWidgetReference AttributeSelectorsContainer
		{
			get => GetProperty(ref _attributeSelectorsContainer);
			set => SetProperty(ref _attributeSelectorsContainer, value);
		}

		[Ordinal(8)] 
		[RED("perksScreen")] 
		public inkWidgetReference PerksScreen
		{
			get => GetProperty(ref _perksScreen);
			set => SetProperty(ref _perksScreen, value);
		}

		[Ordinal(9)] 
		[RED("pointsDisplay")] 
		public inkWidgetReference PointsDisplay
		{
			get => GetProperty(ref _pointsDisplay);
			set => SetProperty(ref _pointsDisplay, value);
		}

		[Ordinal(10)] 
		[RED("johnnyConnectorRef")] 
		public inkWidgetReference JohnnyConnectorRef
		{
			get => GetProperty(ref _johnnyConnectorRef);
			set => SetProperty(ref _johnnyConnectorRef, value);
		}

		[Ordinal(11)] 
		[RED("attributeTooltipHolderRight")] 
		public inkWidgetReference AttributeTooltipHolderRight
		{
			get => GetProperty(ref _attributeTooltipHolderRight);
			set => SetProperty(ref _attributeTooltipHolderRight, value);
		}

		[Ordinal(12)] 
		[RED("attributeTooltipHolderLeft")] 
		public inkWidgetReference AttributeTooltipHolderLeft
		{
			get => GetProperty(ref _attributeTooltipHolderLeft);
			set => SetProperty(ref _attributeTooltipHolderLeft, value);
		}

		[Ordinal(13)] 
		[RED("resetPerks")] 
		public inkWidgetReference ResetPerks
		{
			get => GetProperty(ref _resetPerks);
			set => SetProperty(ref _resetPerks, value);
		}

		[Ordinal(14)] 
		[RED("activeScreen")] 
		public CEnum<CharacterScreenType> ActiveScreen
		{
			get => GetProperty(ref _activeScreen);
			set => SetProperty(ref _activeScreen, value);
		}

		[Ordinal(15)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(16)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(17)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetProperty(ref _dataManager);
			set => SetProperty(ref _dataManager, value);
		}

		[Ordinal(18)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(19)] 
		[RED("perksMenuItemCreatedQueue")] 
		public CArray<CHandle<PerksMenuAttributeItemCreated>> PerksMenuItemCreatedQueue
		{
			get => GetProperty(ref _perksMenuItemCreatedQueue);
			set => SetProperty(ref _perksMenuItemCreatedQueue, value);
		}

		[Ordinal(20)] 
		[RED("attributesControllersList")] 
		public CArray<wCHandle<PerksMenuAttributeItemController>> AttributesControllersList
		{
			get => GetProperty(ref _attributesControllersList);
			set => SetProperty(ref _attributesControllersList, value);
		}

		[Ordinal(21)] 
		[RED("playerStatsBlackboard")] 
		public CHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetProperty(ref _playerStatsBlackboard);
			set => SetProperty(ref _playerStatsBlackboard, value);
		}

		[Ordinal(22)] 
		[RED("characterLevelListener")] 
		public CUInt32 CharacterLevelListener
		{
			get => GetProperty(ref _characterLevelListener);
			set => SetProperty(ref _characterLevelListener, value);
		}

		[Ordinal(23)] 
		[RED("perksScreenController")] 
		public wCHandle<PerkScreenController> PerksScreenController
		{
			get => GetProperty(ref _perksScreenController);
			set => SetProperty(ref _perksScreenController, value);
		}

		[Ordinal(24)] 
		[RED("pointsDisplayController")] 
		public wCHandle<PerksPointsDisplayController> PointsDisplayController
		{
			get => GetProperty(ref _pointsDisplayController);
			set => SetProperty(ref _pointsDisplayController, value);
		}

		[Ordinal(25)] 
		[RED("questSystem")] 
		public wCHandle<questQuestsSystem> QuestSystem
		{
			get => GetProperty(ref _questSystem);
			set => SetProperty(ref _questSystem, value);
		}

		[Ordinal(26)] 
		[RED("resetConfirmationToken")] 
		public CHandle<inkGameNotificationToken> ResetConfirmationToken
		{
			get => GetProperty(ref _resetConfirmationToken);
			set => SetProperty(ref _resetConfirmationToken, value);
		}

		public PerksMainGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
