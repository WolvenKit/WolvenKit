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
		[RED("tabRootContainer")] 
		public inkWidgetReference TabRootContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("tabRootRef")] 
		public inkWidgetReference TabRootRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("playerCredits")] 
		public inkWidgetReference PlayerCredits
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("playerCreditsValue")] 
		public inkTextWidgetReference PlayerCreditsValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("playerWeight")] 
		public inkWidgetReference PlayerWeight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("playerWeightValue")] 
		public inkTextWidgetReference PlayerWeightValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("vendorShopLabel")] 
		public inkTextWidgetReference VendorShopLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("levelValue")] 
		public inkTextWidgetReference LevelValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("streetCredLabel")] 
		public inkTextWidgetReference StreetCredLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("levelBarProgress")] 
		public inkWidgetReference LevelBarProgress
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("levelBarSpacer")] 
		public inkWidgetReference LevelBarSpacer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("streetCredBarProgress")] 
		public inkWidgetReference StreetCredBarProgress
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("streetCredBarSpacer")] 
		public inkWidgetReference StreetCredBarSpacer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get => GetPropertyValue<CHandle<VendorDataManager>>();
			set => SetPropertyValue<CHandle<VendorDataManager>>(value);
		}

		[Ordinal(18)] 
		[RED("vendorUserData")] 
		public CHandle<VendorUserData> VendorUserData
		{
			get => GetPropertyValue<CHandle<VendorUserData>>();
			set => SetPropertyValue<CHandle<VendorUserData>>(value);
		}

		[Ordinal(19)] 
		[RED("vendorPanelData")] 
		public CHandle<questVendorPanelData> VendorPanelData
		{
			get => GetPropertyValue<CHandle<questVendorPanelData>>();
			set => SetPropertyValue<CHandle<questVendorPanelData>>(value);
		}

		[Ordinal(20)] 
		[RED("storageUserData")] 
		public CHandle<StorageUserData> StorageUserData
		{
			get => GetPropertyValue<CHandle<StorageUserData>>();
			set => SetPropertyValue<CHandle<StorageUserData>>(value);
		}

		[Ordinal(21)] 
		[RED("PDS")] 
		public CHandle<PlayerDevelopmentSystem> PDS
		{
			get => GetPropertyValue<CHandle<PlayerDevelopmentSystem>>();
			set => SetPropertyValue<CHandle<PlayerDevelopmentSystem>>(value);
		}

		[Ordinal(22)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(23)] 
		[RED("tabRoot")] 
		public CWeakHandle<TabRadioGroup> TabRoot
		{
			get => GetPropertyValue<CWeakHandle<TabRadioGroup>>();
			set => SetPropertyValue<CWeakHandle<TabRadioGroup>>(value);
		}

		[Ordinal(24)] 
		[RED("playerMoneyAnimator")] 
		public CWeakHandle<MoneyLabelController> PlayerMoneyAnimator
		{
			get => GetPropertyValue<CWeakHandle<MoneyLabelController>>();
			set => SetPropertyValue<CWeakHandle<MoneyLabelController>>(value);
		}

		[Ordinal(25)] 
		[RED("isRipperdoc")] 
		public CBool IsRipperdoc
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("isRipperdocViktorTutorial")] 
		public CBool IsRipperdocViktorTutorial
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("statusEffectSystem")] 
		public CWeakHandle<gameStatusEffectSystem> StatusEffectSystem
		{
			get => GetPropertyValue<CWeakHandle<gameStatusEffectSystem>>();
			set => SetPropertyValue<CWeakHandle<gameStatusEffectSystem>>(value);
		}

		[Ordinal(28)] 
		[RED("questSystem")] 
		public CWeakHandle<questQuestsSystem> QuestSystem
		{
			get => GetPropertyValue<CWeakHandle<questQuestsSystem>>();
			set => SetPropertyValue<CWeakHandle<questQuestsSystem>>(value);
		}

		[Ordinal(29)] 
		[RED("ripperdocTimeDilationCallback")] 
		public CHandle<RipperdocTimeDilationCallback> RipperdocTimeDilationCallback
		{
			get => GetPropertyValue<CHandle<RipperdocTimeDilationCallback>>();
			set => SetPropertyValue<CHandle<RipperdocTimeDilationCallback>>(value);
		}

		[Ordinal(30)] 
		[RED("timeDilationEnabling")] 
		public CBool TimeDilationEnabling
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("equipAnimationCategories")] 
		public CArray<CHandle<RipperdocCyberwareEquipAnimationCategory>> EquipAnimationCategories
		{
			get => GetPropertyValue<CArray<CHandle<RipperdocCyberwareEquipAnimationCategory>>>();
			set => SetPropertyValue<CArray<CHandle<RipperdocCyberwareEquipAnimationCategory>>>(value);
		}

		[Ordinal(32)] 
		[RED("VendorBlackboard")] 
		public CWeakHandle<gameIBlackboard> VendorBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(33)] 
		[RED("playerStatsBlackboard")] 
		public CWeakHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(34)] 
		[RED("VendorBlackboardDef")] 
		public CHandle<UI_VendorDef> VendorBlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_VendorDef>>();
			set => SetPropertyValue<CHandle<UI_VendorDef>>(value);
		}

		[Ordinal(35)] 
		[RED("VendorUpdatedCallbackID")] 
		public CHandle<redCallbackObject> VendorUpdatedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(36)] 
		[RED("weightListener")] 
		public CHandle<redCallbackObject> WeightListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(37)] 
		[RED("characterLevelListener")] 
		public CHandle<redCallbackObject> CharacterLevelListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(38)] 
		[RED("characterCurrentXPListener")] 
		public CHandle<redCallbackObject> CharacterCurrentXPListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(39)] 
		[RED("characterCredListener")] 
		public CHandle<redCallbackObject> CharacterCredListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(40)] 
		[RED("characterCredPointsListener")] 
		public CHandle<redCallbackObject> CharacterCredPointsListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(41)] 
		[RED("characterCurrentHealthListener")] 
		public CHandle<redCallbackObject> CharacterCurrentHealthListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(42)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(43)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(44)] 
		[RED("menuData")] 
		public CArray<MenuData> MenuData
		{
			get => GetPropertyValue<CArray<MenuData>>();
			set => SetPropertyValue<CArray<MenuData>>(value);
		}

		[Ordinal(45)] 
		[RED("activeMenu")] 
		public CInt32 ActiveMenu
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(46)] 
		[RED("isChangedManually")] 
		public CBool IsChangedManually
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("cameFromRipperdoc")] 
		public CBool CameFromRipperdoc
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(48)] 
		[RED("storageDef")] 
		public CHandle<StorageBlackboardDef> StorageDef
		{
			get => GetPropertyValue<CHandle<StorageBlackboardDef>>();
			set => SetPropertyValue<CHandle<StorageBlackboardDef>>(value);
		}

		[Ordinal(49)] 
		[RED("storageBlackboard")] 
		public CWeakHandle<gameIBlackboard> StorageBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		public VendorHubMenuGameController()
		{
			NotificationRoot = new inkWidgetReference();
			TabRootContainer = new inkWidgetReference();
			TabRootRef = new inkWidgetReference();
			PlayerCredits = new inkWidgetReference();
			PlayerCreditsValue = new inkTextWidgetReference();
			PlayerWeight = new inkWidgetReference();
			PlayerWeightValue = new inkTextWidgetReference();
			VendorShopLabel = new inkTextWidgetReference();
			LevelValue = new inkTextWidgetReference();
			StreetCredLabel = new inkTextWidgetReference();
			LevelBarProgress = new inkWidgetReference();
			LevelBarSpacer = new inkWidgetReference();
			StreetCredBarProgress = new inkWidgetReference();
			StreetCredBarSpacer = new inkWidgetReference();
			EquipAnimationCategories = new();
			MenuData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
