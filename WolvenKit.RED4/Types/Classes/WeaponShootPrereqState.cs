using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponShootPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("listenerRightWeaponInt")] 
		public CHandle<redCallbackObject> ListenerRightWeaponInt
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(1)] 
		[RED("listenerActiveRightWeaponVariant")] 
		public CHandle<redCallbackObject> ListenerActiveRightWeaponVariant
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(2)] 
		[RED("rightWeaponObj")] 
		public CWeakHandle<gameweaponObject> RightWeaponObj
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(3)] 
		[RED("listenerLeftWeaponInt")] 
		public CHandle<redCallbackObject> ListenerLeftWeaponInt
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(4)] 
		[RED("listenerActiveLeftWeaponVariant")] 
		public CHandle<redCallbackObject> ListenerActiveLeftWeaponVariant
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(5)] 
		[RED("leftWeaponObj")] 
		public CWeakHandle<gameweaponObject> LeftWeaponObj
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(6)] 
		[RED("listenerOnShootVariant")] 
		public CHandle<redCallbackObject> ListenerOnShootVariant
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(7)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(8)] 
		[RED("howManyAttacks")] 
		public CInt32 HowManyAttacks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
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
