using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponChargeStatListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		public WeaponChargeStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
