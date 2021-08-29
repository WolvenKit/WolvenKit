using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitIsTheSameTargetPrereqState : GenericHitPrereqState
	{
		private CWeakHandle<gameObject> _previousTarget;
		private CWeakHandle<gameObject> _previousSource;
		private CWeakHandle<gameweaponObject> _previousWeapon;

		[Ordinal(2)] 
		[RED("previousTarget")] 
		public CWeakHandle<gameObject> PreviousTarget
		{
			get => GetProperty(ref _previousTarget);
			set => SetProperty(ref _previousTarget, value);
		}

		[Ordinal(3)] 
		[RED("previousSource")] 
		public CWeakHandle<gameObject> PreviousSource
		{
			get => GetProperty(ref _previousSource);
			set => SetProperty(ref _previousSource, value);
		}

		[Ordinal(4)] 
		[RED("previousWeapon")] 
		public CWeakHandle<gameweaponObject> PreviousWeapon
		{
			get => GetProperty(ref _previousWeapon);
			set => SetProperty(ref _previousWeapon, value);
		}
	}
}
