using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReloadFromEmptyPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("minAmountOfAmmoReloaded")] 
		public CInt32 MinAmountOfAmmoReloaded
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("listenerRightWeaponInt")] 
		public CHandle<redCallbackObject> ListenerRightWeaponInt
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(3)] 
		[RED("listenerEquipmentRight")] 
		public CHandle<redCallbackObject> ListenerEquipmentRight
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(4)] 
		[RED("listenerLeftWeaponInt")] 
		public CHandle<redCallbackObject> ListenerLeftWeaponInt
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(5)] 
		[RED("listenerEquipmentLeft")] 
		public CHandle<redCallbackObject> ListenerEquipmentLeft
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(6)] 
		[RED("reloadingInProgressRight")] 
		public CBool ReloadingInProgressRight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("reloadingInProgressLeft")] 
		public CBool ReloadingInProgressLeft
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ReloadFromEmptyPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
