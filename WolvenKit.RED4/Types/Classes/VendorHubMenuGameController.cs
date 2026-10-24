using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendorHubMenuGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("notificationRoot")] 
		public inkWidgetReference NotificationRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("centerContainer")] 
		public inkWidgetReference CenterContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("tabRootContainer")] 
		public inkWidgetReference TabRootContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("tabRootRef")] 
		public inkWidgetReference TabRootRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("playerCredits")] 
		public inkWidgetReference PlayerCredits
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("playerCreditsValue")] 
		public inkTextWidgetReference PlayerCreditsValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("playerWeight")] 
		public inkWidgetReference PlayerWeight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("playerWeightValue")] 
		public inkTextWidgetReference PlayerWeightValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("vendorShopLabel")] 
		public inkTextWidgetReference VendorShopLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("leftContainer")] 
		public inkWidgetReference LeftContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("levelValue")] 
		public inkTextWidgetReference LevelValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("streetCredLabel")] 
		public inkTextWidgetReference StreetCredLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("levelBarProgress")] 
		public inkWidgetReference LevelBarProgress
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("levelBarSpacer")] 
		public inkWidgetReference LevelBarSpacer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("streetCredBarProgress")] 
		public inkWidgetReference StreetCredBarProgress
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("streetCredBarSpacer")] 
		public inkWidgetReference StreetCredBarSpacer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get => GetPropertyValue<CHandle<VendorDataManager>>();
			set => SetPropertyValue<CHandle<VendorDataManager>>(value);
		}

		[Ordinal(20)] 
		[RED("vendorUserData")] 
		public CHandle<VendorUserData> VendorUserData
		{
			get => GetPropertyValue<CHandle<VendorUserData>>();
			set => SetPropertyValue<CHandle<VendorUserData>>(value);
		}

		[Ordinal(21)] 
		[RED("vendorPanelData")] 
		public CHandle<questVendorPanelData> VendorPanelData
		{
			get => GetPropertyValue<CHandle<questVendorPanelData>>();
			set => SetPropertyValue<CHandle<questVendorPanelData>>(value);
		}

		[Ordinal(22)] 
		[RED("storageUserData")] 
		public CHandle<StorageUserData> StorageUserData
		{
			get => GetPropertyValue<CHandle<StorageUserData>>();
			set => SetPropertyValue<CHandle<StorageUserData>>(value);
		}

		[Ordinal(23)] 
		[RED("PDS")] 
		public CHandle<PlayerDevelopmentSystem> PDS
		{
			get => GetPropertyValue<CHandle<PlayerDevelopmentSystem>>();
			set => SetPropertyValue<CHandle<PlayerDevelopmentSystem>>(value);
		}

		[Ordinal(24)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(25)] 
		[RED("tabRoot")] 
		public CWeakHandle<TabRadioGroup> TabRoot
		{
			get => GetPropertyValue<CWeakHandle<TabRadioGroup>>();
			set => SetPropertyValue<CWeakHandle<TabRadioGroup>>(value);
		}

		[Ordinal(26)] 
		[RED("playerMoneyAnimator")] 
		public CWeakHandle<MoneyLabelController> PlayerMoneyAnimator
		{
			get => GetPropertyValue<CWeakHandle<MoneyLabelController>>();
			set => SetPropertyValue<CWeakHandle<MoneyLabelController>>(value);
		}

		[Ordinal(27)] 
		[RED("isRipperdoc")] 
		public CBool IsRipperdoc
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("isRipperdocViktorTutorial")] 
		public CBool IsRipperdocViktorTutorial
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("statusEffectSystem")] 
		public CWeakHandle<gameStatusEffectSystem> StatusEffectSystem
		{
			get => GetPropertyValue<CWeakHandle<gameStatusEffectSystem>>();
			set => SetPropertyValue<CWeakHandle<gameStatusEffectSystem>>(value);
		}

		[Ordinal(30)] 
		[RED("questSystem")] 
		public CWeakHandle<questQuestsSystem> QuestSystem
		{
			get => GetPropertyValue<CWeakHandle<questQuestsSystem>>();
			set => SetPropertyValue<CWeakHandle<questQuestsSystem>>(value);
		}

		[Ordinal(31)] 
		[RED("equipAnimationCategories")] 
		public CArray<CHandle<RipperdocCyberwareEquipAnimationCategory>> EquipAnimationCategories
		{
			get => GetPropertyValue<CArray<CHandle<RipperdocCyberwareEquipAnimationCategory>>>();
			set => SetPropertyValue<CArray<CHandle<RipperdocCyberwareEquipAnimationCategory>>>(value);
		}

		[Ordinal(32)] 
		[RED("docTimeDilationCallback")] 
		public CHandle<RipperdocTimeDilationCallback> DocTimeDilationCallback
		{
			get => GetPropertyValue<CHandle<RipperdocTimeDilationCallback>>();
			set => SetPropertyValue<CHandle<RipperdocTimeDilationCallback>>(value);
		}

		[Ordinal(33)] 
		[RED("timeDilationEnabling")] 
		public CBool TimeDilationEnabling
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("isGlamdoc")] 
		public CBool IsGlamdoc
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("glamdocCustomizationFact")] 
		public CName GlamdocCustomizationFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(36)] 
		[RED("VendorBlackboard")] 
		public CWeakHandle<gameIBlackboard> VendorBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(37)] 
		[RED("playerStatsBlackboard")] 
		public CWeakHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(38)] 
		[RED("VendorBlackboardDef")] 
		public CHandle<UI_VendorDef> VendorBlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_VendorDef>>();
			set => SetPropertyValue<CHandle<UI_VendorDef>>(value);
		}

		[Ordinal(39)] 
		[RED("VendorUpdatedCallbackID")] 
		public CHandle<redCallbackObject> VendorUpdatedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(40)] 
		[RED("weightListener")] 
		public CHandle<redCallbackObject> WeightListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(41)] 
		[RED("characterLevelListener")] 
		public CHandle<redCallbackObject> CharacterLevelListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(42)] 
		[RED("characterCurrentXPListener")] 
		public CHandle<redCallbackObject> CharacterCurrentXPListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(43)] 
		[RED("characterCredListener")] 
		public CHandle<redCallbackObject> CharacterCredListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(44)] 
		[RED("characterCredPointsListener")] 
		public CHandle<redCallbackObject> CharacterCredPointsListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(45)] 
		[RED("characterCurrentHealthListener")] 
		public CHandle<redCallbackObject> CharacterCurrentHealthListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(46)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(47)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(48)] 
		[RED("menuData")] 
		public CArray<MenuData> MenuData
		{
			get => GetPropertyValue<CArray<MenuData>>();
			set => SetPropertyValue<CArray<MenuData>>(value);
		}

		[Ordinal(49)] 
		[RED("activeMenu")] 
		public CInt32 ActiveMenu
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(50)] 
		[RED("isChangedManually")] 
		public CBool IsChangedManually
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(51)] 
		[RED("cameFromRipperdoc")] 
		public CBool CameFromRipperdoc
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(52)] 
		[RED("storageDef")] 
		public CHandle<StorageBlackboardDef> StorageDef
		{
			get => GetPropertyValue<CHandle<StorageBlackboardDef>>();
			set => SetPropertyValue<CHandle<StorageBlackboardDef>>(value);
		}

		[Ordinal(53)] 
		[RED("storageBlackboard")] 
		public CWeakHandle<gameIBlackboard> StorageBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		public VendorHubMenuGameController()
		{
			NotificationRoot = new inkWidgetReference();
			CenterContainer = new inkWidgetReference();
			TabRootContainer = new inkWidgetReference();
			TabRootRef = new inkWidgetReference();
			PlayerCredits = new inkWidgetReference();
			PlayerCreditsValue = new inkTextWidgetReference();
			PlayerWeight = new inkWidgetReference();
			PlayerWeightValue = new inkTextWidgetReference();
			VendorShopLabel = new inkTextWidgetReference();
			LeftContainer = new inkWidgetReference();
			LevelValue = new inkTextWidgetReference();
			StreetCredLabel = new inkTextWidgetReference();
			LevelBarProgress = new inkWidgetReference();
			LevelBarSpacer = new inkWidgetReference();
			StreetCredBarProgress = new inkWidgetReference();
			StreetCredBarSpacer = new inkWidgetReference();
			EquipAnimationCategories = new();
			GlamdocCustomizationFact = "glamdoc_customized";
			MenuData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
