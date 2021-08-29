using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BeingTargetByLaserSightUpdateEvent : redEvent
	{
		private CWeakHandle<gameweaponObject> _weapon;
		private CEnum<LaserTargettingState> _state;

		[Ordinal(0)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<LaserTargettingState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
