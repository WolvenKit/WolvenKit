using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileSetUpEvent : redEvent
	{
		private CWeakHandle<gameObject> _owner;
		private CWeakHandle<gameObject> _weapon;
		private CHandle<gameprojectileTrajectoryParams> _trajectoryParams;
		private CFloat _lerpMultiplier;

		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("weapon")] 
		public CWeakHandle<gameObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(2)] 
		[RED("trajectoryParams")] 
		public CHandle<gameprojectileTrajectoryParams> TrajectoryParams
		{
			get => GetProperty(ref _trajectoryParams);
			set => SetProperty(ref _trajectoryParams, value);
		}

		[Ordinal(3)] 
		[RED("lerpMultiplier")] 
		public CFloat LerpMultiplier
		{
			get => GetProperty(ref _lerpMultiplier);
			set => SetProperty(ref _lerpMultiplier, value);
		}
	}
}
