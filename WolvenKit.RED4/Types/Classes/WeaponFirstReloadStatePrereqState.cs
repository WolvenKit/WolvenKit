using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponFirstReloadStatePrereqState : gamePrereqState
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
		[RED("weaponObj")] 
		public CWeakHandle<gameweaponObject> WeaponObj
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(4)] 
		[RED("reloaded")] 
		public CBool Reloaded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public WeaponFirstReloadStatePrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
