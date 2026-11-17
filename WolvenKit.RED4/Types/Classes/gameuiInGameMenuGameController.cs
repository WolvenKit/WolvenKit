using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiInGameMenuGameController : gameuiBaseMenuGameController
	{
		[Ordinal(3)] 
		[RED("itemSceneInfos")] 
		public CArray<gameuiInGameMenuGameControllerItemSceneInfo> ItemSceneInfos
		{
			get => GetPropertyValue<CArray<gameuiInGameMenuGameControllerItemSceneInfo>>();
			set => SetPropertyValue<CArray<gameuiInGameMenuGameControllerItemSceneInfo>>(value);
		}

		[Ordinal(4)] 
		[RED("garmentSwitchEffectControllers")] 
		public CArray<gameuiGarmentSwitchEffectController> GarmentSwitchEffectControllers
		{
			get => GetPropertyValue<CArray<gameuiGarmentSwitchEffectController>>();
			set => SetPropertyValue<CArray<gameuiGarmentSwitchEffectController>>(value);
		}

		[Ordinal(5)] 
		[RED("quickSaveInProgress")] 
		public CBool QuickSaveInProgress
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("wasHoldingMapHotKey")] 
		public CBool WasHoldingMapHotKey
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("controllerDisconnected")] 
		public CBool ControllerDisconnected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("inputSettingsListener")] 
		public CHandle<InputSettingsVarListener> InputSettingsListener
		{
			get => GetPropertyValue<CHandle<InputSettingsVarListener>>();
			set => SetPropertyValue<CHandle<InputSettingsVarListener>>(value);
		}

		[Ordinal(9)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetPropertyValue<CHandle<userSettingsUserSettings>>();
			set => SetPropertyValue<CHandle<userSettingsUserSettings>>(value);
		}

		[Ordinal(10)] 
		[RED("inputSettingGroupName")] 
		public CName InputSettingGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("inputSettingGroup")] 
		public CHandle<userSettingsGroup> InputSettingGroup
		{
			get => GetPropertyValue<CHandle<userSettingsGroup>>();
			set => SetPropertyValue<CHandle<userSettingsGroup>>(value);
		}

		[Ordinal(12)] 
		[RED("inputSettingVarName")] 
		public CName InputSettingVarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("inputSettingVar")] 
		public CHandle<userSettingsVarListString> InputSettingVar
		{
			get => GetPropertyValue<CHandle<userSettingsVarListString>>();
			set => SetPropertyValue<CHandle<userSettingsVarListString>>(value);
		}

		[Ordinal(14)] 
		[RED("displayInputSettingVarName")] 
		public CName DisplayInputSettingVarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("displayInputSettingVar")] 
		public CHandle<userSettingsVarListString> DisplayInputSettingVar
		{
			get => GetPropertyValue<CHandle<userSettingsVarListString>>();
			set => SetPropertyValue<CHandle<userSettingsVarListString>>(value);
		}

		[Ordinal(16)] 
		[RED("initScheme")] 
		public CInt32 InitScheme
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(17)] 
		[RED("saveMessageToken")] 
		public CHandle<inkGameNotificationToken> SaveMessageToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(18)] 
		[RED("showDeathScreenBBID")] 
		public CHandle<redCallbackObject> ShowDeathScreenBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(19)] 
		[RED("breachingNetworkBBID")] 
		public CHandle<redCallbackObject> BreachingNetworkBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(20)] 
		[RED("triggerMenuEventBBID")] 
		public CHandle<redCallbackObject> TriggerMenuEventBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(21)] 
		[RED("openStorageBBID")] 
		public CHandle<redCallbackObject> OpenStorageBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(22)] 
		[RED("controllerDisconnectedBBID")] 
		public CHandle<redCallbackObject> ControllerDisconnectedBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(23)] 
		[RED("bbOnEquipmentChangedID")] 
		public CHandle<redCallbackObject> BbOnEquipmentChangedID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(24)] 
		[RED("inputSchemesBBID")] 
		public CHandle<redCallbackObject> InputSchemesBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(25)] 
		[RED("inputMouserLayoutBBID")] 
		public CHandle<redCallbackObject> InputMouserLayoutBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(26)] 
		[RED("inventoryListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> InventoryListener
		{
			get => GetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>();
			set => SetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>(value);
		}

		[Ordinal(27)] 
		[RED("animContainer")] 
		public CHandle<inGameMenuAnimContainer> AnimContainer
		{
			get => GetPropertyValue<CHandle<inGameMenuAnimContainer>>();
			set => SetPropertyValue<CHandle<inGameMenuAnimContainer>>(value);
		}

		[Ordinal(28)] 
		[RED("lastInGameNotificationType")] 
		public CEnum<UIInGameNotificationType> LastInGameNotificationType
		{
			get => GetPropertyValue<CEnum<UIInGameNotificationType>>();
			set => SetPropertyValue<CEnum<UIInGameNotificationType>>(value);
		}

		[Ordinal(29)] 
		[RED("loadSaveDelayID")] 
		public gameDelayID LoadSaveDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(30)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public gameuiInGameMenuGameController()
		{
			ItemSceneInfos = new();
			GarmentSwitchEffectControllers = new();
			LoadSaveDelayID = new gameDelayID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
