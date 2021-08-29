using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SameTargetHitPrereqCondition : BaseHitPrereqCondition
	{
		private CWeakHandle<gameObject> _previousTarget;
		private CWeakHandle<gameObject> _previousSource;
		private CWeakHandle<gameweaponObject> _previousWeapon;

		[Ordinal(1)] 
		[RED("previousTarget")] 
		public CWeakHandle<gameObject> PreviousTarget
		{
			get => GetProperty(ref _previousTarget);
			set => SetProperty(ref _previousTarget, value);
		}

		[Ordinal(2)] 
		[RED("previousSource")] 
		public CWeakHandle<gameObject> PreviousSource
		{
			get => GetProperty(ref _previousSource);
			set => SetProperty(ref _previousSource, value);
		}

		[Ordinal(3)] 
		[RED("previousWeapon")] 
		public CWeakHandle<gameweaponObject> PreviousWeapon
		{
			get => GetProperty(ref _previousWeapon);
			set => SetProperty(ref _previousWeapon, value);
		}
	}
}
