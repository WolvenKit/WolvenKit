using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerksMainGameController : gameuiMenuGameController
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
		[RED("playerLevel")] 
		public inkTextWidgetReference PlayerLevel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("centerHiglightParts")] 
		public CArray<inkWidgetReference> CenterHiglightParts
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(7)] 
		[RED("attributeSelectorsContainer")] 
		public inkWidgetReference AttributeSelectorsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("perksScreen")] 
		public inkWidgetReference PerksScreen
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("pointsDisplay")] 
		public inkWidgetReference PointsDisplay
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("johnnyConnectorRef")] 
		public inkWidgetReference JohnnyConnectorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("attributeTooltipHolderRight")] 
		public inkWidgetReference AttributeTooltipHolderRight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("attributeTooltipHolderLeft")] 
		public inkWidgetReference AttributeTooltipHolderLeft
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("respecButtonContainer")] 
		public inkWidgetReference RespecButtonContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("cantRespecNotificationContainer")] 
		public inkWidgetReference CantRespecNotificationContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("resetPrice")] 
		public inkTextWidgetReference ResetPrice
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("spentPerks")] 
		public inkTextWidgetReference SpentPerks
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("activeScreen")] 
		public CEnum<CharacterScreenType> ActiveScreen
		{
			get => GetPropertyValue<CEnum<CharacterScreenType>>();
			set => SetPropertyValue<CEnum<CharacterScreenType>>(value);
		}

		[Ordinal(18)] 
		[RED("tooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(19)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(20)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetPropertyValue<CHandle<PlayerDevelopmentDataManager>>();
			set => SetPropertyValue<CHandle<PlayerDevelopmentDataManager>>(value);
		}

		[Ordinal(21)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(22)] 
		[RED("perksMenuItemCreatedQueue")] 
		public CArray<CHandle<PerksMenuAttributeItemCreated>> PerksMenuItemCreatedQueue
		{
			get => GetPropertyValue<CArray<CHandle<PerksMenuAttributeItemCreated>>>();
			set => SetPropertyValue<CArray<CHandle<PerksMenuAttributeItemCreated>>>(value);
		}

		[Ordinal(23)] 
		[RED("attributesControllersList")] 
		public CArray<CWeakHandle<PerksMenuAttributeItemController>> AttributesControllersList
		{
			get => GetPropertyValue<CArray<CWeakHandle<PerksMenuAttributeItemController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<PerksMenuAttributeItemController>>>(value);
		}

		[Ordinal(24)] 
		[RED("playerStatsBlackboard")] 
		public CWeakHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(25)] 
		[RED("characterLevelListener")] 
		public CHandle<redCallbackObject> CharacterLevelListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(26)] 
		[RED("perksScreenController")] 
		public CWeakHandle<PerkScreenController> PerksScreenController
		{
			get => GetPropertyValue<CWeakHandle<PerkScreenController>>();
			set => SetPropertyValue<CWeakHandle<PerkScreenController>>(value);
		}

		[Ordinal(27)] 
		[RED("pointsDisplayController")] 
		public CWeakHandle<PerksPointsDisplayController> PointsDisplayController
		{
			get => GetPropertyValue<CWeakHandle<PerksPointsDisplayController>>();
			set => SetPropertyValue<CWeakHandle<PerksPointsDisplayController>>(value);
		}

		[Ordinal(28)] 
		[RED("questSystem")] 
		public CWeakHandle<questQuestsSystem> QuestSystem
		{
			get => GetPropertyValue<CWeakHandle<questQuestsSystem>>();
			set => SetPropertyValue<CWeakHandle<questQuestsSystem>>(value);
		}

		[Ordinal(29)] 
		[RED("equipmentSystem")] 
		public CWeakHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetPropertyValue<CWeakHandle<EquipmentSystem>>();
			set => SetPropertyValue<CWeakHandle<EquipmentSystem>>(value);
		}

		[Ordinal(30)] 
		[RED("resetConfirmationToken")] 
		public CHandle<inkGameNotificationToken> ResetConfirmationToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(31)] 
		[RED("inCombat")] 
		public CBool InCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("enoughMoneyForRespec")] 
		public CBool EnoughMoneyForRespec
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("cantRespecAnim")] 
		public CHandle<inkanimProxy> CantRespecAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(34)] 
		[RED("lastHoveredAttribute")] 
		public CEnum<PerkMenuAttribute> LastHoveredAttribute
		{
			get => GetPropertyValue<CEnum<PerkMenuAttribute>>();
			set => SetPropertyValue<CEnum<PerkMenuAttribute>>(value);
		}

		public PerksMainGameController()
		{
			TooltipsManagerRef = new();
			ButtonHintsManagerRef = new();
			PlayerLevel = new();
			CenterHiglightParts = new();
			AttributeSelectorsContainer = new();
			PerksScreen = new();
			PointsDisplay = new();
			JohnnyConnectorRef = new();
			AttributeTooltipHolderRight = new();
			AttributeTooltipHolderLeft = new();
			RespecButtonContainer = new();
			CantRespecNotificationContainer = new();
			ResetPrice = new();
			SpentPerks = new();
			PerksMenuItemCreatedQueue = new();
			AttributesControllersList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
