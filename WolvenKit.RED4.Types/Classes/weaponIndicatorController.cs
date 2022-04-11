using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class weaponIndicatorController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("triggerModeControllers")] 
		public CArray<CName> TriggerModeControllers
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(10)] 
		[RED("ammoLogicControllers")] 
		public CArray<CName> AmmoLogicControllers
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(11)] 
		[RED("chargeLogicControllers")] 
		public CArray<CName> ChargeLogicControllers
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(12)] 
		[RED("triggerModeInstances")] 
		public CArray<CWeakHandle<TriggerModeLogicController>> TriggerModeInstances
		{
			get => GetPropertyValue<CArray<CWeakHandle<TriggerModeLogicController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<TriggerModeLogicController>>>(value);
		}

		[Ordinal(13)] 
		[RED("ammoLogicInstances")] 
		public CArray<CWeakHandle<AmmoLogicController>> AmmoLogicInstances
		{
			get => GetPropertyValue<CArray<CWeakHandle<AmmoLogicController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<AmmoLogicController>>>(value);
		}

		[Ordinal(14)] 
		[RED("chargeLogicInstances")] 
		public CArray<CWeakHandle<ChargeLogicController>> ChargeLogicInstances
		{
			get => GetPropertyValue<CArray<CWeakHandle<ChargeLogicController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<ChargeLogicController>>>(value);
		}

		[Ordinal(15)] 
		[RED("bb")] 
		public CWeakHandle<gameIBlackboard> Bb
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(16)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(17)] 
		[RED("onCharge")] 
		public CHandle<redCallbackObject> OnCharge
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(18)] 
		[RED("onTriggerMode")] 
		public CHandle<redCallbackObject> OnTriggerMode
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(19)] 
		[RED("onMagazineAmmoCount")] 
		public CHandle<redCallbackObject> OnMagazineAmmoCount
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(20)] 
		[RED("onMagazineAmmoCapacity")] 
		public CHandle<redCallbackObject> OnMagazineAmmoCapacity
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(21)] 
		[RED("BufferedRosterData")] 
		public CHandle<gameSlotDataHolder> BufferedRosterData
		{
			get => GetPropertyValue<CHandle<gameSlotDataHolder>>();
			set => SetPropertyValue<CHandle<gameSlotDataHolder>>(value);
		}

		[Ordinal(22)] 
		[RED("ActiveWeapon")] 
		public gameSlotWeaponData ActiveWeapon
		{
			get => GetPropertyValue<gameSlotWeaponData>();
			set => SetPropertyValue<gameSlotWeaponData>(value);
		}

		[Ordinal(23)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		public weaponIndicatorController()
		{
			TriggerModeControllers = new();
			AmmoLogicControllers = new();
			ChargeLogicControllers = new();
			TriggerModeInstances = new();
			AmmoLogicInstances = new();
			ChargeLogicInstances = new();
			ActiveWeapon = new() { WeaponID = new(), AmmoCurrent = -1, MagazineCap = -1, AmmoId = new(), TriggerModeCurrent = Enums.gamedataTriggerMode.Invalid, TriggerModeList = new(), Evolution = Enums.gamedataWeaponEvolution.Invalid, IsFirstEquip = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
