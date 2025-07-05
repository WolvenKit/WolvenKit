using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponShootPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("listenerWeaponInt")] 
		public CHandle<redCallbackObject> ListenerWeaponInt
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(1)] 
		[RED("listenerActiveWeaponVariant")] 
		public CHandle<redCallbackObject> ListenerActiveWeaponVariant
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(2)] 
		[RED("listenerOnShootVariant")] 
		public CHandle<redCallbackObject> ListenerOnShootVariant
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(3)] 
		[RED("weaponObj")] 
		public CWeakHandle<gameweaponObject> WeaponObj
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(4)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(5)] 
		[RED("howManyAttacks")] 
		public CInt32 HowManyAttacks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("remainingAttacks")] 
		public CInt32 RemainingAttacks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public WeaponShootPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
