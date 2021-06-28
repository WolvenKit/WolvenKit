using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInGameMenuGameController : gameuiBaseMenuGameController
	{
		private CArray<gameuiInGameMenuGameControllerItemSceneInfo> _itemSceneInfos;
		private CArray<gameuiInGameMenuGameControllerGarmentSwitchEffectController> _garmentSwitchEffectControllers;
		private CBool _quickSaveInProgress;
		private CUInt32 _showDeathScreenBBID;
		private CUInt32 _breachingNetworkBBID;
		private CUInt32 _triggerMenuEventBBID;
		private CUInt32 _openStorageBBID;
		private CUInt32 _bbOnEquipmentChangedID;
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
		public CUInt32 ShowDeathScreenBBID
		{
			get => GetProperty(ref _showDeathScreenBBID);
			set => SetProperty(ref _showDeathScreenBBID, value);
		}

		[Ordinal(7)] 
		[RED("breachingNetworkBBID")] 
		public CUInt32 BreachingNetworkBBID
		{
			get => GetProperty(ref _breachingNetworkBBID);
			set => SetProperty(ref _breachingNetworkBBID, value);
		}

		[Ordinal(8)] 
		[RED("triggerMenuEventBBID")] 
		public CUInt32 TriggerMenuEventBBID
		{
			get => GetProperty(ref _triggerMenuEventBBID);
			set => SetProperty(ref _triggerMenuEventBBID, value);
		}

		[Ordinal(9)] 
		[RED("openStorageBBID")] 
		public CUInt32 OpenStorageBBID
		{
			get => GetProperty(ref _openStorageBBID);
			set => SetProperty(ref _openStorageBBID, value);
		}

		[Ordinal(10)] 
		[RED("bbOnEquipmentChangedID")] 
		public CUInt32 BbOnEquipmentChangedID
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

		public gameuiInGameMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
