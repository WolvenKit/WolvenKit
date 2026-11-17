using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AutoDriveSystem : gameNativeAutodriveSystem
	{
		[Ordinal(0)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("playerVehicleStateCallbackHandle")] 
		public CHandle<redCallbackObject> PlayerVehicleStateCallbackHandle
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(2)] 
		[RED("playerCombatStateCallbackHandle")] 
		public CHandle<redCallbackObject> PlayerCombatStateCallbackHandle
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(3)] 
		[RED("playerRightWeaponStateCallbackHandle")] 
		public CHandle<redCallbackObject> PlayerRightWeaponStateCallbackHandle
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(4)] 
		[RED("playerLeftWeaponStateCallbackHandle")] 
		public CHandle<redCallbackObject> PlayerLeftWeaponStateCallbackHandle
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(5)] 
		[RED("playerMeleeWeaponStateCallbackHandle")] 
		public CHandle<redCallbackObject> PlayerMeleeWeaponStateCallbackHandle
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(6)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(7)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(8)] 
		[RED("vehicleHealthListener")] 
		public CHandle<AutodriveHealthChangeListener> VehicleHealthListener
		{
			get => GetPropertyValue<CHandle<AutodriveHealthChangeListener>>();
			set => SetPropertyValue<CHandle<AutodriveHealthChangeListener>>(value);
		}

		[Ordinal(9)] 
		[RED("autodriveQuestContentLockListener")] 
		public CHandle<AutodriveQuestContentLockListener> AutodriveQuestContentLockListener
		{
			get => GetPropertyValue<CHandle<AutodriveQuestContentLockListener>>();
			set => SetPropertyValue<CHandle<AutodriveQuestContentLockListener>>(value);
		}

		public AutoDriveSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
