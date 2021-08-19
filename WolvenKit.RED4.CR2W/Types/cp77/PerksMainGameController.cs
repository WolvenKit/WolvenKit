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
		private inkWidgetReference _respecButtonContainer;
		private inkWidgetReference _cantRespecNotificationContainer;
		private inkTextWidgetReference _resetPrice;
		private inkTextWidgetReference _spentPerks;
		private CEnum<CharacterScreenType> _activeScreen;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CHandle<PlayerDevelopmentDataManager> _dataManager;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CArray<CHandle<PerksMenuAttributeItemCreated>> _perksMenuItemCreatedQueue;
		private CArray<wCHandle<PerksMenuAttributeItemController>> _attributesControllersList;
		private wCHandle<gameIBlackboard> _playerStatsBlackboard;
		private CHandle<redCallbackObject> _characterLevelListener;
		private wCHandle<PerkScreenController> _perksScreenController;
		private wCHandle<PerksPointsDisplayController> _pointsDisplayController;
		private wCHandle<questQuestsSystem> _questSystem;
		private CHandle<inkGameNotificationToken> _resetConfirmationToken;
		private CBool _inCombat;
		private CBool _enoughMoneyForRespec;
		private CHandle<inkanimProxy> _cantRespecAnim;
		private CEnum<PerkMenuAttribute> _lastHoveredAttribute;

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
		[RED("respecButtonContainer")] 
		public inkWidgetReference RespecButtonContainer
		{
			get => GetProperty(ref _respecButtonContainer);
			set => SetProperty(ref _respecButtonContainer, value);
		}

		[Ordinal(14)] 
		[RED("cantRespecNotificationContainer")] 
		public inkWidgetReference CantRespecNotificationContainer
		{
			get => GetProperty(ref _cantRespecNotificationContainer);
			set => SetProperty(ref _cantRespecNotificationContainer, value);
		}

		[Ordinal(15)] 
		[RED("resetPrice")] 
		public inkTextWidgetReference ResetPrice
		{
			get => GetProperty(ref _resetPrice);
			set => SetProperty(ref _resetPrice, value);
		}

		[Ordinal(16)] 
		[RED("spentPerks")] 
		public inkTextWidgetReference SpentPerks
		{
			get => GetProperty(ref _spentPerks);
			set => SetProperty(ref _spentPerks, value);
		}

		[Ordinal(17)] 
		[RED("activeScreen")] 
		public CEnum<CharacterScreenType> ActiveScreen
		{
			get => GetProperty(ref _activeScreen);
			set => SetProperty(ref _activeScreen, value);
		}

		[Ordinal(18)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(19)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(20)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetProperty(ref _dataManager);
			set => SetProperty(ref _dataManager, value);
		}

		[Ordinal(21)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(22)] 
		[RED("perksMenuItemCreatedQueue")] 
		public CArray<CHandle<PerksMenuAttributeItemCreated>> PerksMenuItemCreatedQueue
		{
			get => GetProperty(ref _perksMenuItemCreatedQueue);
			set => SetProperty(ref _perksMenuItemCreatedQueue, value);
		}

		[Ordinal(23)] 
		[RED("attributesControllersList")] 
		public CArray<wCHandle<PerksMenuAttributeItemController>> AttributesControllersList
		{
			get => GetProperty(ref _attributesControllersList);
			set => SetProperty(ref _attributesControllersList, value);
		}

		[Ordinal(24)] 
		[RED("playerStatsBlackboard")] 
		public wCHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetProperty(ref _playerStatsBlackboard);
			set => SetProperty(ref _playerStatsBlackboard, value);
		}

		[Ordinal(25)] 
		[RED("characterLevelListener")] 
		public CHandle<redCallbackObject> CharacterLevelListener
		{
			get => GetProperty(ref _characterLevelListener);
			set => SetProperty(ref _characterLevelListener, value);
		}

		[Ordinal(26)] 
		[RED("perksScreenController")] 
		public wCHandle<PerkScreenController> PerksScreenController
		{
			get => GetProperty(ref _perksScreenController);
			set => SetProperty(ref _perksScreenController, value);
		}

		[Ordinal(27)] 
		[RED("pointsDisplayController")] 
		public wCHandle<PerksPointsDisplayController> PointsDisplayController
		{
			get => GetProperty(ref _pointsDisplayController);
			set => SetProperty(ref _pointsDisplayController, value);
		}

		[Ordinal(28)] 
		[RED("questSystem")] 
		public wCHandle<questQuestsSystem> QuestSystem
		{
			get => GetProperty(ref _questSystem);
			set => SetProperty(ref _questSystem, value);
		}

		[Ordinal(29)] 
		[RED("resetConfirmationToken")] 
		public CHandle<inkGameNotificationToken> ResetConfirmationToken
		{
			get => GetProperty(ref _resetConfirmationToken);
			set => SetProperty(ref _resetConfirmationToken, value);
		}

		[Ordinal(30)] 
		[RED("inCombat")] 
		public CBool InCombat
		{
			get => GetProperty(ref _inCombat);
			set => SetProperty(ref _inCombat, value);
		}

		[Ordinal(31)] 
		[RED("enoughMoneyForRespec")] 
		public CBool EnoughMoneyForRespec
		{
			get => GetProperty(ref _enoughMoneyForRespec);
			set => SetProperty(ref _enoughMoneyForRespec, value);
		}

		[Ordinal(32)] 
		[RED("cantRespecAnim")] 
		public CHandle<inkanimProxy> CantRespecAnim
		{
			get => GetProperty(ref _cantRespecAnim);
			set => SetProperty(ref _cantRespecAnim, value);
		}

		[Ordinal(33)] 
		[RED("lastHoveredAttribute")] 
		public CEnum<PerkMenuAttribute> LastHoveredAttribute
		{
			get => GetProperty(ref _lastHoveredAttribute);
			set => SetProperty(ref _lastHoveredAttribute, value);
		}

		public PerksMainGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
