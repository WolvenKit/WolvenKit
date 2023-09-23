using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerksScreenLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("perksWidgets")] 
		public CArray<inkWidgetReference> PerksWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(2)] 
		[RED("gauge")] 
		public inkWidgetReference Gauge
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("tiers")] 
		public CArray<PerkScreenTierInfo> Tiers
		{
			get => GetPropertyValue<CArray<PerkScreenTierInfo>>();
			set => SetPropertyValue<CArray<PerkScreenTierInfo>>(value);
		}

		[Ordinal(4)] 
		[RED("animationBoldLineWidget")] 
		public inkWidgetReference AnimationBoldLineWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("animationLineWidget")] 
		public inkWidgetReference AnimationLineWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("animationGradientWidget")] 
		public inkWidgetReference AnimationGradientWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("attributeButtonWidget")] 
		public inkWidgetReference AttributeButtonWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("lockedLineIcon")] 
		public inkWidgetReference LockedLineIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("unlockedLineIcon")] 
		public inkWidgetReference UnlockedLineIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("attributeRequirementTexts")] 
		public CArray<inkTextWidgetReference> AttributeRequirementTexts
		{
			get => GetPropertyValue<CArray<inkTextWidgetReference>>();
			set => SetPropertyValue<CArray<inkTextWidgetReference>>(value);
		}

		[Ordinal(11)] 
		[RED("levelRequirementTexts")] 
		public CArray<inkTextWidgetReference> LevelRequirementTexts
		{
			get => GetPropertyValue<CArray<inkTextWidgetReference>>();
			set => SetPropertyValue<CArray<inkTextWidgetReference>>(value);
		}

		[Ordinal(12)] 
		[RED("perksInitialized")] 
		public CBool PerksInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("perksControllers")] 
		public CHandle<inkScriptHashMap> PerksControllers
		{
			get => GetPropertyValue<CHandle<inkScriptHashMap>>();
			set => SetPropertyValue<CHandle<inkScriptHashMap>>(value);
		}

		[Ordinal(14)] 
		[RED("perksContainersControllers")] 
		public CHandle<inkScriptHashMap> PerksContainersControllers
		{
			get => GetPropertyValue<CHandle<inkScriptHashMap>>();
			set => SetPropertyValue<CHandle<inkScriptHashMap>>(value);
		}

		[Ordinal(15)] 
		[RED("perkControllersArray")] 
		public CArray<CWeakHandle<NewPerksPerkContainerLogicController>> PerkControllersArray
		{
			get => GetPropertyValue<CArray<CWeakHandle<NewPerksPerkContainerLogicController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<NewPerksPerkContainerLogicController>>>(value);
		}

		[Ordinal(16)] 
		[RED("enabledControllers")] 
		public CArray<CWeakHandle<NewPerksPerkContainerLogicController>> EnabledControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<NewPerksPerkContainerLogicController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<NewPerksPerkContainerLogicController>>>(value);
		}

		[Ordinal(17)] 
		[RED("initData")] 
		public CHandle<NewPerksScreenInitData> InitData
		{
			get => GetPropertyValue<CHandle<NewPerksScreenInitData>>();
			set => SetPropertyValue<CHandle<NewPerksScreenInitData>>(value);
		}

		[Ordinal(18)] 
		[RED("perksList")] 
		public CArray<CWeakHandle<gamedataNewPerk_Record>> PerksList
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataNewPerk_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataNewPerk_Record>>>(value);
		}

		[Ordinal(19)] 
		[RED("playerDevelopmentSystem")] 
		public CWeakHandle<PlayerDevelopmentSystem> PlayerDevelopmentSystem
		{
			get => GetPropertyValue<CWeakHandle<PlayerDevelopmentSystem>>();
			set => SetPropertyValue<CWeakHandle<PlayerDevelopmentSystem>>(value);
		}

		[Ordinal(20)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(21)] 
		[RED("playerDevelopmentData")] 
		public CWeakHandle<PlayerDevelopmentData> PlayerDevelopmentData
		{
			get => GetPropertyValue<CWeakHandle<PlayerDevelopmentData>>();
			set => SetPropertyValue<CWeakHandle<PlayerDevelopmentData>>(value);
		}

		[Ordinal(22)] 
		[RED("attributePoints")] 
		public CInt32 AttributePoints
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(23)] 
		[RED("linksManager")] 
		public CHandle<NewPerksRequirementsLinksManager> LinksManager
		{
			get => GetPropertyValue<CHandle<NewPerksRequirementsLinksManager>>();
			set => SetPropertyValue<CHandle<NewPerksRequirementsLinksManager>>(value);
		}

		[Ordinal(24)] 
		[RED("gaugeController")] 
		public CWeakHandle<NewPerksGaugeController> GaugeController
		{
			get => GetPropertyValue<CWeakHandle<NewPerksGaugeController>>();
			set => SetPropertyValue<CWeakHandle<NewPerksGaugeController>>(value);
		}

		[Ordinal(25)] 
		[RED("attributeButtonController")] 
		public CWeakHandle<NewPerksAttributeButtonController> AttributeButtonController
		{
			get => GetPropertyValue<CWeakHandle<NewPerksAttributeButtonController>>();
			set => SetPropertyValue<CWeakHandle<NewPerksAttributeButtonController>>(value);
		}

		[Ordinal(26)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(27)] 
		[RED("dataManager")] 
		public CWeakHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetPropertyValue<CWeakHandle<PlayerDevelopmentDataManager>>();
			set => SetPropertyValue<CWeakHandle<PlayerDevelopmentDataManager>>(value);
		}

		[Ordinal(28)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(29)] 
		[RED("levels")] 
		public CArray<NewPerksGaugePointDetails> Levels
		{
			get => GetPropertyValue<CArray<NewPerksGaugePointDetails>>();
			set => SetPropertyValue<CArray<NewPerksGaugePointDetails>>(value);
		}

		[Ordinal(30)] 
		[RED("highlightData")] 
		public CArray<PerkTierHighlight> HighlightData
		{
			get => GetPropertyValue<CArray<PerkTierHighlight>>();
			set => SetPropertyValue<CArray<PerkTierHighlight>>(value);
		}

		[Ordinal(31)] 
		[RED("activeProxies")] 
		public CArray<CHandle<inkanimProxy>> ActiveProxies
		{
			get => GetPropertyValue<CArray<CHandle<inkanimProxy>>>();
			set => SetPropertyValue<CArray<CHandle<inkanimProxy>>>(value);
		}

		[Ordinal(32)] 
		[RED("highlightedWires")] 
		public CArray<inkWidgetReference> HighlightedWires
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(33)] 
		[RED("highlightedPerks")] 
		public CArray<CWeakHandle<inkWidget>> HighlightedPerks
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(34)] 
		[RED("dimmedWidgets")] 
		public CArray<inkWidgetReference> DimmedWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(35)] 
		[RED("dimProxies")] 
		public CArray<CHandle<inkanimProxy>> DimProxies
		{
			get => GetPropertyValue<CArray<CHandle<inkanimProxy>>>();
			set => SetPropertyValue<CArray<CHandle<inkanimProxy>>>(value);
		}

		[Ordinal(36)] 
		[RED("undimProxies")] 
		public CArray<CHandle<inkanimProxy>> UndimProxies
		{
			get => GetPropertyValue<CArray<CHandle<inkanimProxy>>>();
			set => SetPropertyValue<CArray<CHandle<inkanimProxy>>>(value);
		}

		[Ordinal(37)] 
		[RED("isActiveScreen")] 
		public CBool IsActiveScreen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("isEspionage")] 
		public CBool IsEspionage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("unlockAnimData")] 
		public UnlockAnimData UnlockAnimData
		{
			get => GetPropertyValue<UnlockAnimData>();
			set => SetPropertyValue<UnlockAnimData>(value);
		}

		[Ordinal(40)] 
		[RED("lineAnimProxy")] 
		public CHandle<inkanimProxy> LineAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(41)] 
		[RED("buttonMoveAnimProxy")] 
		public CHandle<inkanimProxy> ButtonMoveAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(42)] 
		[RED("buttonCustomAnimProxy")] 
		public CHandle<inkanimProxy> ButtonCustomAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(43)] 
		[RED("lockAnimProxy")] 
		public CHandle<inkanimProxy> LockAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(44)] 
		[RED("introFinished")] 
		public CBool IntroFinished
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("perkHovered")] 
		public CBool PerkHovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(46)] 
		[RED("currentHoveredPerkData")] 
		public CHandle<NewPerkDisplayData> CurrentHoveredPerkData
		{
			get => GetPropertyValue<CHandle<NewPerkDisplayData>>();
			set => SetPropertyValue<CHandle<NewPerkDisplayData>>(value);
		}

		[Ordinal(47)] 
		[RED("gameController")] 
		public CWeakHandle<NewPerksCategoriesGameController> GameController
		{
			get => GetPropertyValue<CWeakHandle<NewPerksCategoriesGameController>>();
			set => SetPropertyValue<CWeakHandle<NewPerksCategoriesGameController>>(value);
		}

		[Ordinal(48)] 
		[RED("sellFailToken")] 
		public CHandle<inkGameNotificationToken> SellFailToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(49)] 
		[RED("perkToSnapCursor")] 
		public CEnum<gamedataNewPerkType> PerkToSnapCursor
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkType>>(value);
		}

		[Ordinal(50)] 
		[RED("unlockState")] 
		public CInt32 UnlockState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public NewPerksScreenLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
