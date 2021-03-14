using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class weaponIndicatorController : gameuiHUDGameController
	{
		private CArray<CName> _triggerModeControllers;
		private CArray<CName> _ammoLogicControllers;
		private CArray<CName> _chargeLogicControllers;
		private CArray<wCHandle<TriggerModeLogicController>> _triggerModeInstances;
		private CArray<wCHandle<AmmoLogicController>> _ammoLogicInstances;
		private CArray<wCHandle<ChargeLogicController>> _chargeLogicInstances;
		private wCHandle<gameIBlackboard> _bb;
		private wCHandle<gameIBlackboard> _blackboard;
		private CUInt32 _onCharge;
		private CUInt32 _onTriggerMode;
		private CUInt32 _onMagazineAmmoCount;
		private CUInt32 _onMagazineAmmoCapacity;
		private CHandle<gameSlotDataHolder> _bufferedRosterData;
		private gameSlotWeaponData _activeWeapon;
		private CHandle<InventoryDataManagerV2> _inventoryManager;

		[Ordinal(9)] 
		[RED("triggerModeControllers")] 
		public CArray<CName> TriggerModeControllers
		{
			get
			{
				if (_triggerModeControllers == null)
				{
					_triggerModeControllers = (CArray<CName>) CR2WTypeManager.Create("array:CName", "triggerModeControllers", cr2w, this);
				}
				return _triggerModeControllers;
			}
			set
			{
				if (_triggerModeControllers == value)
				{
					return;
				}
				_triggerModeControllers = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("ammoLogicControllers")] 
		public CArray<CName> AmmoLogicControllers
		{
			get
			{
				if (_ammoLogicControllers == null)
				{
					_ammoLogicControllers = (CArray<CName>) CR2WTypeManager.Create("array:CName", "ammoLogicControllers", cr2w, this);
				}
				return _ammoLogicControllers;
			}
			set
			{
				if (_ammoLogicControllers == value)
				{
					return;
				}
				_ammoLogicControllers = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("chargeLogicControllers")] 
		public CArray<CName> ChargeLogicControllers
		{
			get
			{
				if (_chargeLogicControllers == null)
				{
					_chargeLogicControllers = (CArray<CName>) CR2WTypeManager.Create("array:CName", "chargeLogicControllers", cr2w, this);
				}
				return _chargeLogicControllers;
			}
			set
			{
				if (_chargeLogicControllers == value)
				{
					return;
				}
				_chargeLogicControllers = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("triggerModeInstances")] 
		public CArray<wCHandle<TriggerModeLogicController>> TriggerModeInstances
		{
			get
			{
				if (_triggerModeInstances == null)
				{
					_triggerModeInstances = (CArray<wCHandle<TriggerModeLogicController>>) CR2WTypeManager.Create("array:whandle:TriggerModeLogicController", "triggerModeInstances", cr2w, this);
				}
				return _triggerModeInstances;
			}
			set
			{
				if (_triggerModeInstances == value)
				{
					return;
				}
				_triggerModeInstances = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("ammoLogicInstances")] 
		public CArray<wCHandle<AmmoLogicController>> AmmoLogicInstances
		{
			get
			{
				if (_ammoLogicInstances == null)
				{
					_ammoLogicInstances = (CArray<wCHandle<AmmoLogicController>>) CR2WTypeManager.Create("array:whandle:AmmoLogicController", "ammoLogicInstances", cr2w, this);
				}
				return _ammoLogicInstances;
			}
			set
			{
				if (_ammoLogicInstances == value)
				{
					return;
				}
				_ammoLogicInstances = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("chargeLogicInstances")] 
		public CArray<wCHandle<ChargeLogicController>> ChargeLogicInstances
		{
			get
			{
				if (_chargeLogicInstances == null)
				{
					_chargeLogicInstances = (CArray<wCHandle<ChargeLogicController>>) CR2WTypeManager.Create("array:whandle:ChargeLogicController", "chargeLogicInstances", cr2w, this);
				}
				return _chargeLogicInstances;
			}
			set
			{
				if (_chargeLogicInstances == value)
				{
					return;
				}
				_chargeLogicInstances = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("bb")] 
		public wCHandle<gameIBlackboard> Bb
		{
			get
			{
				if (_bb == null)
				{
					_bb = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "bb", cr2w, this);
				}
				return _bb;
			}
			set
			{
				if (_bb == value)
				{
					return;
				}
				_bb = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("onCharge")] 
		public CUInt32 OnCharge
		{
			get
			{
				if (_onCharge == null)
				{
					_onCharge = (CUInt32) CR2WTypeManager.Create("Uint32", "onCharge", cr2w, this);
				}
				return _onCharge;
			}
			set
			{
				if (_onCharge == value)
				{
					return;
				}
				_onCharge = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("onTriggerMode")] 
		public CUInt32 OnTriggerMode
		{
			get
			{
				if (_onTriggerMode == null)
				{
					_onTriggerMode = (CUInt32) CR2WTypeManager.Create("Uint32", "onTriggerMode", cr2w, this);
				}
				return _onTriggerMode;
			}
			set
			{
				if (_onTriggerMode == value)
				{
					return;
				}
				_onTriggerMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("onMagazineAmmoCount")] 
		public CUInt32 OnMagazineAmmoCount
		{
			get
			{
				if (_onMagazineAmmoCount == null)
				{
					_onMagazineAmmoCount = (CUInt32) CR2WTypeManager.Create("Uint32", "onMagazineAmmoCount", cr2w, this);
				}
				return _onMagazineAmmoCount;
			}
			set
			{
				if (_onMagazineAmmoCount == value)
				{
					return;
				}
				_onMagazineAmmoCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("onMagazineAmmoCapacity")] 
		public CUInt32 OnMagazineAmmoCapacity
		{
			get
			{
				if (_onMagazineAmmoCapacity == null)
				{
					_onMagazineAmmoCapacity = (CUInt32) CR2WTypeManager.Create("Uint32", "onMagazineAmmoCapacity", cr2w, this);
				}
				return _onMagazineAmmoCapacity;
			}
			set
			{
				if (_onMagazineAmmoCapacity == value)
				{
					return;
				}
				_onMagazineAmmoCapacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("BufferedRosterData")] 
		public CHandle<gameSlotDataHolder> BufferedRosterData
		{
			get
			{
				if (_bufferedRosterData == null)
				{
					_bufferedRosterData = (CHandle<gameSlotDataHolder>) CR2WTypeManager.Create("handle:gameSlotDataHolder", "BufferedRosterData", cr2w, this);
				}
				return _bufferedRosterData;
			}
			set
			{
				if (_bufferedRosterData == value)
				{
					return;
				}
				_bufferedRosterData = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("ActiveWeapon")] 
		public gameSlotWeaponData ActiveWeapon
		{
			get
			{
				if (_activeWeapon == null)
				{
					_activeWeapon = (gameSlotWeaponData) CR2WTypeManager.Create("gameSlotWeaponData", "ActiveWeapon", cr2w, this);
				}
				return _activeWeapon;
			}
			set
			{
				if (_activeWeapon == value)
				{
					return;
				}
				_activeWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get
			{
				if (_inventoryManager == null)
				{
					_inventoryManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "InventoryManager", cr2w, this);
				}
				return _inventoryManager;
			}
			set
			{
				if (_inventoryManager == value)
				{
					return;
				}
				_inventoryManager = value;
				PropertySet(this);
			}
		}

		public weaponIndicatorController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
