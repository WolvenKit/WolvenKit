using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DriverCombatMountedWeaponsEvents : DriverCombatEvents
	{
		[Ordinal(20)] 
		[RED("activeWeapons")] 
		public CArray<CWeakHandle<gameweaponObject>> ActiveWeapons
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameweaponObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameweaponObject>>>(value);
		}

		public DriverCombatMountedWeaponsEvents()
		{
			ActiveWeapons = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
