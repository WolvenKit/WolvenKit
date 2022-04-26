using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BeingTargetByLaserSightUpdateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<LaserTargettingState> State
		{
			get => GetPropertyValue<CEnum<LaserTargettingState>>();
			set => SetPropertyValue<CEnum<LaserTargettingState>>(value);
		}

		public BeingTargetByLaserSightUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
