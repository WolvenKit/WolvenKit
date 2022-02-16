using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		[RED("showDeathScreenBBID")] 
		public CHandle<redCallbackObject> ShowDeathScreenBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(8)] 
		[RED("breachingNetworkBBID")] 
		public CHandle<redCallbackObject> BreachingNetworkBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(9)] 
		[RED("triggerMenuEventBBID")] 
		public CHandle<redCallbackObject> TriggerMenuEventBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(10)] 
		[RED("openStorageBBID")] 
		public CHandle<redCallbackObject> OpenStorageBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("bbOnEquipmentChangedID")] 
		public CHandle<redCallbackObject> BbOnEquipmentChangedID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("inventoryListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> InventoryListener
		{
			get => GetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>();
			set => SetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>(value);
		}

		public gameuiInGameMenuGameController()
		{
			ItemSceneInfos = new();
			GarmentSwitchEffectControllers = new();
		}
	}
}
