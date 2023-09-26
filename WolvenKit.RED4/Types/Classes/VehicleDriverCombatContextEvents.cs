using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleDriverCombatContextEvents : InputContextTransitionEvents
	{
		[Ordinal(8)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		public VehicleDriverCombatContextEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
