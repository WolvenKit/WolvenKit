using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiInGameMenuGameController : gameuiBaseMenuGameController
	{
		private CArray<gameuiInGameMenuGameControllerItemSceneInfo> _itemSceneInfos;
		private CArray<gameuiInGameMenuGameControllerGarmentSwitchEffectController> _garmentSwitchEffectControllers;
		private CBool _quickSaveInProgress;
		private CHandle<redCallbackObject> _showDeathScreenBBID;
		private CHandle<redCallbackObject> _breachingNetworkBBID;
		private CHandle<redCallbackObject> _triggerMenuEventBBID;
		private CHandle<redCallbackObject> _openStorageBBID;
		private CHandle<redCallbackObject> _bbOnEquipmentChangedID;
		private CHandle<gameAttachmentSlotsScriptListener> _inventoryListener;

		[Ordinal(3)] 
		[RED("itemSceneInfos")] 
		public CArray<gameuiInGameMenuGameControllerItemSceneInfo> ItemSceneInfos
		{
			get => GetProperty(ref _itemSceneInfos);
			set => SetProperty(ref _itemSceneInfos, value);
		}

		[Ordinal(4)] 
		[RED("garmentSwitchEffectControllers")] 
		public CArray<gameuiInGameMenuGameControllerGarmentSwitchEffectController> GarmentSwitchEffectControllers
		{
			get => GetProperty(ref _garmentSwitchEffectControllers);
			set => SetProperty(ref _garmentSwitchEffectControllers, value);
		}

		[Ordinal(5)] 
		[RED("quickSaveInProgress")] 
		public CBool QuickSaveInProgress
		{
			get => GetProperty(ref _quickSaveInProgress);
			set => SetProperty(ref _quickSaveInProgress, value);
		}

		[Ordinal(6)] 
		[RED("showDeathScreenBBID")] 
		public CHandle<redCallbackObject> ShowDeathScreenBBID
		{
			get => GetProperty(ref _showDeathScreenBBID);
			set => SetProperty(ref _showDeathScreenBBID, value);
		}

		[Ordinal(7)] 
		[RED("breachingNetworkBBID")] 
		public CHandle<redCallbackObject> BreachingNetworkBBID
		{
			get => GetProperty(ref _breachingNetworkBBID);
			set => SetProperty(ref _breachingNetworkBBID, value);
		}

		[Ordinal(8)] 
		[RED("triggerMenuEventBBID")] 
		public CHandle<redCallbackObject> TriggerMenuEventBBID
		{
			get => GetProperty(ref _triggerMenuEventBBID);
			set => SetProperty(ref _triggerMenuEventBBID, value);
		}

		[Ordinal(9)] 
		[RED("openStorageBBID")] 
		public CHandle<redCallbackObject> OpenStorageBBID
		{
			get => GetProperty(ref _openStorageBBID);
			set => SetProperty(ref _openStorageBBID, value);
		}

		[Ordinal(10)] 
		[RED("bbOnEquipmentChangedID")] 
		public CHandle<redCallbackObject> BbOnEquipmentChangedID
		{
			get => GetProperty(ref _bbOnEquipmentChangedID);
			set => SetProperty(ref _bbOnEquipmentChangedID, value);
		}

		[Ordinal(11)] 
		[RED("inventoryListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> InventoryListener
		{
			get => GetProperty(ref _inventoryListener);
			set => SetProperty(ref _inventoryListener, value);
		}
	}
}
