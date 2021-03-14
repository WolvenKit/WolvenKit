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
			get
			{
				if (_itemSceneInfos == null)
				{
					_itemSceneInfos = (CArray<gameuiInGameMenuGameControllerItemSceneInfo>) CR2WTypeManager.Create("array:gameuiInGameMenuGameControllerItemSceneInfo", "itemSceneInfos", cr2w, this);
				}
				return _itemSceneInfos;
			}
			set
			{
				if (_itemSceneInfos == value)
				{
					return;
				}
				_itemSceneInfos = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("garmentSwitchEffectControllers")] 
		public CArray<gameuiInGameMenuGameControllerGarmentSwitchEffectController> GarmentSwitchEffectControllers
		{
			get
			{
				if (_garmentSwitchEffectControllers == null)
				{
					_garmentSwitchEffectControllers = (CArray<gameuiInGameMenuGameControllerGarmentSwitchEffectController>) CR2WTypeManager.Create("array:gameuiInGameMenuGameControllerGarmentSwitchEffectController", "garmentSwitchEffectControllers", cr2w, this);
				}
				return _garmentSwitchEffectControllers;
			}
			set
			{
				if (_garmentSwitchEffectControllers == value)
				{
					return;
				}
				_garmentSwitchEffectControllers = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("quickSaveInProgress")] 
		public CBool QuickSaveInProgress
		{
			get
			{
				if (_quickSaveInProgress == null)
				{
					_quickSaveInProgress = (CBool) CR2WTypeManager.Create("Bool", "quickSaveInProgress", cr2w, this);
				}
				return _quickSaveInProgress;
			}
			set
			{
				if (_quickSaveInProgress == value)
				{
					return;
				}
				_quickSaveInProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("showDeathScreenBBID")] 
		public CUInt32 ShowDeathScreenBBID
		{
			get
			{
				if (_showDeathScreenBBID == null)
				{
					_showDeathScreenBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "showDeathScreenBBID", cr2w, this);
				}
				return _showDeathScreenBBID;
			}
			set
			{
				if (_showDeathScreenBBID == value)
				{
					return;
				}
				_showDeathScreenBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("breachingNetworkBBID")] 
		public CUInt32 BreachingNetworkBBID
		{
			get
			{
				if (_breachingNetworkBBID == null)
				{
					_breachingNetworkBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "breachingNetworkBBID", cr2w, this);
				}
				return _breachingNetworkBBID;
			}
			set
			{
				if (_breachingNetworkBBID == value)
				{
					return;
				}
				_breachingNetworkBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("triggerMenuEventBBID")] 
		public CUInt32 TriggerMenuEventBBID
		{
			get
			{
				if (_triggerMenuEventBBID == null)
				{
					_triggerMenuEventBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "triggerMenuEventBBID", cr2w, this);
				}
				return _triggerMenuEventBBID;
			}
			set
			{
				if (_triggerMenuEventBBID == value)
				{
					return;
				}
				_triggerMenuEventBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("openStorageBBID")] 
		public CUInt32 OpenStorageBBID
		{
			get
			{
				if (_openStorageBBID == null)
				{
					_openStorageBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "openStorageBBID", cr2w, this);
				}
				return _openStorageBBID;
			}
			set
			{
				if (_openStorageBBID == value)
				{
					return;
				}
				_openStorageBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("bbOnEquipmentChangedID")] 
		public CUInt32 BbOnEquipmentChangedID
		{
			get
			{
				if (_bbOnEquipmentChangedID == null)
				{
					_bbOnEquipmentChangedID = (CUInt32) CR2WTypeManager.Create("Uint32", "bbOnEquipmentChangedID", cr2w, this);
				}
				return _bbOnEquipmentChangedID;
			}
			set
			{
				if (_bbOnEquipmentChangedID == value)
				{
					return;
				}
				_bbOnEquipmentChangedID = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("inventoryListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> InventoryListener
		{
			get
			{
				if (_inventoryListener == null)
				{
					_inventoryListener = (CHandle<gameAttachmentSlotsScriptListener>) CR2WTypeManager.Create("handle:gameAttachmentSlotsScriptListener", "inventoryListener", cr2w, this);
				}
				return _inventoryListener;
			}
			set
			{
				if (_inventoryListener == value)
				{
					return;
				}
				_inventoryListener = value;
				PropertySet(this);
			}
		}

		public gameuiInGameMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
