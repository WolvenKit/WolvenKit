using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class weaponIndicatorController : gameuiHUDGameController
	{
		private CArray<CName> _triggerModeControllers;
		private CArray<CName> _ammoLogicControllers;
		private CArray<CName> _chargeLogicControllers;
		private CArray<CWeakHandle<TriggerModeLogicController>> _triggerModeInstances;
		private CArray<CWeakHandle<AmmoLogicController>> _ammoLogicInstances;
		private CArray<CWeakHandle<ChargeLogicController>> _chargeLogicInstances;
		private CWeakHandle<gameIBlackboard> _bb;
		private CWeakHandle<gameIBlackboard> _blackboard;
		private CHandle<redCallbackObject> _onCharge;
		private CHandle<redCallbackObject> _onTriggerMode;
		private CHandle<redCallbackObject> _onMagazineAmmoCount;
		private CHandle<redCallbackObject> _onMagazineAmmoCapacity;
		private CHandle<gameSlotDataHolder> _bufferedRosterData;
		private gameSlotWeaponData _activeWeapon;
		private CHandle<InventoryDataManagerV2> _inventoryManager;

		[Ordinal(9)] 
		[RED("triggerModeControllers")] 
		public CArray<CName> TriggerModeControllers
		{
			get => GetProperty(ref _triggerModeControllers);
			set => SetProperty(ref _triggerModeControllers, value);
		}

		[Ordinal(10)] 
		[RED("ammoLogicControllers")] 
		public CArray<CName> AmmoLogicControllers
		{
			get => GetProperty(ref _ammoLogicControllers);
			set => SetProperty(ref _ammoLogicControllers, value);
		}

		[Ordinal(11)] 
		[RED("chargeLogicControllers")] 
		public CArray<CName> ChargeLogicControllers
		{
			get => GetProperty(ref _chargeLogicControllers);
			set => SetProperty(ref _chargeLogicControllers, value);
		}

		[Ordinal(12)] 
		[RED("triggerModeInstances")] 
		public CArray<CWeakHandle<TriggerModeLogicController>> TriggerModeInstances
		{
			get => GetProperty(ref _triggerModeInstances);
			set => SetProperty(ref _triggerModeInstances, value);
		}

		[Ordinal(13)] 
		[RED("ammoLogicInstances")] 
		public CArray<CWeakHandle<AmmoLogicController>> AmmoLogicInstances
		{
			get => GetProperty(ref _ammoLogicInstances);
			set => SetProperty(ref _ammoLogicInstances, value);
		}

		[Ordinal(14)] 
		[RED("chargeLogicInstances")] 
		public CArray<CWeakHandle<ChargeLogicController>> ChargeLogicInstances
		{
			get => GetProperty(ref _chargeLogicInstances);
			set => SetProperty(ref _chargeLogicInstances, value);
		}

		[Ordinal(15)] 
		[RED("bb")] 
		public CWeakHandle<gameIBlackboard> Bb
		{
			get => GetProperty(ref _bb);
			set => SetProperty(ref _bb, value);
		}

		[Ordinal(16)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(17)] 
		[RED("onCharge")] 
		public CHandle<redCallbackObject> OnCharge
		{
			get => GetProperty(ref _onCharge);
			set => SetProperty(ref _onCharge, value);
		}

		[Ordinal(18)] 
		[RED("onTriggerMode")] 
		public CHandle<redCallbackObject> OnTriggerMode
		{
			get => GetProperty(ref _onTriggerMode);
			set => SetProperty(ref _onTriggerMode, value);
		}

		[Ordinal(19)] 
		[RED("onMagazineAmmoCount")] 
		public CHandle<redCallbackObject> OnMagazineAmmoCount
		{
			get => GetProperty(ref _onMagazineAmmoCount);
			set => SetProperty(ref _onMagazineAmmoCount, value);
		}

		[Ordinal(20)] 
		[RED("onMagazineAmmoCapacity")] 
		public CHandle<redCallbackObject> OnMagazineAmmoCapacity
		{
			get => GetProperty(ref _onMagazineAmmoCapacity);
			set => SetProperty(ref _onMagazineAmmoCapacity, value);
		}

		[Ordinal(21)] 
		[RED("BufferedRosterData")] 
		public CHandle<gameSlotDataHolder> BufferedRosterData
		{
			get => GetProperty(ref _bufferedRosterData);
			set => SetProperty(ref _bufferedRosterData, value);
		}

		[Ordinal(22)] 
		[RED("ActiveWeapon")] 
		public gameSlotWeaponData ActiveWeapon
		{
			get => GetProperty(ref _activeWeapon);
			set => SetProperty(ref _activeWeapon, value);
		}

		[Ordinal(23)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}
	}
}
