using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerksCategoriesGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("perksCategoriesContainer")] 
		public inkWidgetReference PerksCategoriesContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("tabsContainer")] 
		public inkWidgetReference TabsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("perksScreenContainer")] 
		public inkWidgetReference PerksScreenContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("espionageScreenContainer")] 
		public inkWidgetReference EspionageScreenContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("skillsScreenContainer")] 
		public inkWidgetReference SkillsScreenContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("pointsDisplay")] 
		public inkWidgetReference PointsDisplay
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("playerLevel")] 
		public inkTextWidgetReference PlayerLevel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("resetAttributesButton")] 
		public inkWidgetReference ResetAttributesButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("skillsScreenButton")] 
		public inkWidgetReference SkillsScreenButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("espionageAttributeMask")] 
		public inkWidgetReference EspionageAttributeMask
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("espionagePointsRef")] 
		public inkWidgetReference EspionagePointsRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("attributeTooltipHolderRight")] 
		public inkWidgetReference AttributeTooltipHolderRight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("attributeTooltipHolderLeft")] 
		public inkWidgetReference AttributeTooltipHolderLeft
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("centerHiglightParts")] 
		public CArray<inkWidgetReference> CenterHiglightParts
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(19)] 
		[RED("perkTooltipPlacementLeft")] 
		public inkWidgetReference PerkTooltipPlacementLeft
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("perkTooltipPlacementRight")] 
		public inkWidgetReference PerkTooltipPlacementRight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("perkTooltipBgLeft")] 
		public inkWidgetReference PerkTooltipBgLeft
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("perkTooltipBgRight")] 
		public inkWidgetReference PerkTooltipBgRight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("perkTooltipBgAnimProxy")] 
		public CHandle<inkanimProxy> PerkTooltipBgAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(24)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(25)] 
		[RED("tabsController")] 
		public CWeakHandle<NewPerkTabsController> TabsController
		{
			get => GetPropertyValue<CWeakHandle<NewPerkTabsController>>();
			set => SetPropertyValue<CWeakHandle<NewPerkTabsController>>(value);
		}

		[Ordinal(26)] 
		[RED("perksScreenController")] 
		public CWeakHandle<NewPerksScreenLogicController> PerksScreenController
		{
			get => GetPropertyValue<CWeakHandle<NewPerksScreenLogicController>>();
			set => SetPropertyValue<CWeakHandle<NewPerksScreenLogicController>>(value);
		}

		[Ordinal(27)] 
		[RED("espionageScreenController")] 
		public CWeakHandle<NewPerksScreenLogicController> EspionageScreenController
		{
			get => GetPropertyValue<CWeakHandle<NewPerksScreenLogicController>>();
			set => SetPropertyValue<CWeakHandle<NewPerksScreenLogicController>>(value);
		}

		[Ordinal(28)] 
		[RED("skillScreenController")] 
		public CWeakHandle<NewPerkSkillsLogicController> SkillScreenController
		{
			get => GetPropertyValue<CWeakHandle<NewPerkSkillsLogicController>>();
			set => SetPropertyValue<CWeakHandle<NewPerkSkillsLogicController>>(value);
		}

		[Ordinal(29)] 
		[RED("tooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(30)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(31)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetPropertyValue<CHandle<PlayerDevelopmentDataManager>>();
			set => SetPropertyValue<CHandle<PlayerDevelopmentDataManager>>(value);
		}

		[Ordinal(32)] 
		[RED("questSystem")] 
		public CWeakHandle<questQuestsSystem> QuestSystem
		{
			get => GetPropertyValue<CWeakHandle<questQuestsSystem>>();
			set => SetPropertyValue<CWeakHandle<questQuestsSystem>>(value);
		}

		[Ordinal(33)] 
		[RED("attributesControllersList")] 
		public CArray<CWeakHandle<PerksMenuAttributeItemController>> AttributesControllersList
		{
			get => GetPropertyValue<CArray<CWeakHandle<PerksMenuAttributeItemController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<PerksMenuAttributeItemController>>>(value);
		}

		[Ordinal(34)] 
		[RED("perksMenuItemCreatedQueue")] 
		public CArray<CHandle<PerksMenuAttributeItemCreated>> PerksMenuItemCreatedQueue
		{
			get => GetPropertyValue<CArray<CHandle<PerksMenuAttributeItemCreated>>>();
			set => SetPropertyValue<CArray<CHandle<PerksMenuAttributeItemCreated>>>(value);
		}

		[Ordinal(35)] 
		[RED("pointsDisplayController")] 
		public CWeakHandle<PerksPointsDisplayController> PointsDisplayController
		{
			get => GetPropertyValue<CWeakHandle<PerksPointsDisplayController>>();
			set => SetPropertyValue<CWeakHandle<PerksPointsDisplayController>>(value);
		}

		[Ordinal(36)] 
		[RED("playerStatsBlackboard")] 
		public CWeakHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(37)] 
		[RED("characterLevelListener")] 
		public CHandle<redCallbackObject> CharacterLevelListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(38)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(39)] 
		[RED("previousScreen")] 
		public CEnum<NewPeksActiveScreen> PreviousScreen
		{
			get => GetPropertyValue<CEnum<NewPeksActiveScreen>>();
			set => SetPropertyValue<CEnum<NewPeksActiveScreen>>(value);
		}

		[Ordinal(40)] 
		[RED("currentScreen")] 
		public CEnum<NewPeksActiveScreen> CurrentScreen
		{
			get => GetPropertyValue<CEnum<NewPeksActiveScreen>>();
			set => SetPropertyValue<CEnum<NewPeksActiveScreen>>(value);
		}

		[Ordinal(41)] 
		[RED("currentStatScreen")] 
		public CEnum<gamedataStatType> CurrentStatScreen
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(42)] 
		[RED("johnnyEspionageInitialized")] 
		public CBool JohnnyEspionageInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("isEspionageUnlocked")] 
		public CBool IsEspionageUnlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("lastHoveredAttribute")] 
		public CEnum<PerkMenuAttribute> LastHoveredAttribute
		{
			get => GetPropertyValue<CEnum<PerkMenuAttribute>>();
			set => SetPropertyValue<CEnum<PerkMenuAttribute>>(value);
		}

		[Ordinal(45)] 
		[RED("cyberwarePerkDetailsPopupToken")] 
		public CHandle<inkGameNotificationToken> CyberwarePerkDetailsPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(46)] 
		[RED("perksScreenIntroAnimProxy")] 
		public CHandle<inkanimProxy> PerksScreenIntroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(47)] 
		[RED("perksScreenOutroAnimProxy")] 
		public CHandle<inkanimProxy> PerksScreenOutroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(48)] 
		[RED("perksScreenDirection")] 
		public CEnum<NewPerkTabsArrowDirection> PerksScreenDirection
		{
			get => GetPropertyValue<CEnum<NewPerkTabsArrowDirection>>();
			set => SetPropertyValue<CEnum<NewPerkTabsArrowDirection>>(value);
		}

		[Ordinal(49)] 
		[RED("currentTooltipData")] 
		public PerkHoverEventTooltipData CurrentTooltipData
		{
			get => GetPropertyValue<PerkHoverEventTooltipData>();
			set => SetPropertyValue<PerkHoverEventTooltipData>(value);
		}

		[Ordinal(50)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(51)] 
		[RED("currentCursorPos")] 
		public Vector2 CurrentCursorPos
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(52)] 
		[RED("perkUserData")] 
		public CHandle<PerkUserData> PerkUserData
		{
			get => GetPropertyValue<CHandle<PerkUserData>>();
			set => SetPropertyValue<CHandle<PerkUserData>>(value);
		}

		[Ordinal(53)] 
		[RED("vendorUserData")] 
		public CHandle<VendorUserData> VendorUserData
		{
			get => GetPropertyValue<CHandle<VendorUserData>>();
			set => SetPropertyValue<CHandle<VendorUserData>>(value);
		}

		[Ordinal(54)] 
		[RED("skillsOpenData")] 
		public CHandle<OpenSkillsMenuData> SkillsOpenData
		{
			get => GetPropertyValue<CHandle<OpenSkillsMenuData>>();
			set => SetPropertyValue<CHandle<OpenSkillsMenuData>>(value);
		}

		[Ordinal(55)] 
		[RED("resetConfirmationToken")] 
		public CHandle<inkGameNotificationToken> ResetConfirmationToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(56)] 
		[RED("userData")] 
		public CHandle<IScriptable> UserData
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		[Ordinal(57)] 
		[RED("isPlayerInCombat")] 
		public CBool IsPlayerInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(58)] 
		[RED("screenDisplayContext")] 
		public CEnum<ScreenDisplayContext> ScreenDisplayContext
		{
			get => GetPropertyValue<CEnum<ScreenDisplayContext>>();
			set => SetPropertyValue<CEnum<ScreenDisplayContext>>(value);
		}

		public NewPerksCategoriesGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
