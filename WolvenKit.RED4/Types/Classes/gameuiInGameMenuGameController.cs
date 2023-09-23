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
		[RED("showDeathScreenBBID")] 
		public CHandle<redCallbackObject> ShowDeathScreenBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(9)] 
		[RED("breachingNetworkBBID")] 
		public CHandle<redCallbackObject> BreachingNetworkBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(10)] 
		[RED("triggerMenuEventBBID")] 
		public CHandle<redCallbackObject> TriggerMenuEventBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("openStorageBBID")] 
		public CHandle<redCallbackObject> OpenStorageBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("controllerDisconnectedBBID")] 
		public CHandle<redCallbackObject> ControllerDisconnectedBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("bbOnEquipmentChangedID")] 
		public CHandle<redCallbackObject> BbOnEquipmentChangedID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("inputSchemesBBID")] 
		public CHandle<redCallbackObject> InputSchemesBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(15)] 
		[RED("inventoryListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> InventoryListener
		{
			get => GetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>();
			set => SetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>(value);
		}

		[Ordinal(16)] 
		[RED("animContainer")] 
		public CHandle<inGameMenuAnimContainer> AnimContainer
		{
			get => GetPropertyValue<CHandle<inGameMenuAnimContainer>>();
			set => SetPropertyValue<CHandle<inGameMenuAnimContainer>>(value);
		}

		[Ordinal(17)] 
		[RED("lastInGameNotificationType")] 
		public CEnum<UIInGameNotificationType> LastInGameNotificationType
		{
			get => GetPropertyValue<CEnum<UIInGameNotificationType>>();
			set => SetPropertyValue<CEnum<UIInGameNotificationType>>(value);
		}

		[Ordinal(18)] 
		[RED("loadSaveDelayID")] 
		public gameDelayID LoadSaveDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(19)] 
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

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
