using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileSetUpAndLaunchEvent : gameprojectileLaunchEvent
	{
		private CHandle<gameprojectileTrajectoryParams> _trajectoryParams;
		private CFloat _lerpMultiplier;

		[Ordinal(4)] 
		[RED("trajectoryParams")] 
		public CHandle<gameprojectileTrajectoryParams> TrajectoryParams
		{
			get => GetProperty(ref _trajectoryParams);
			set => SetProperty(ref _trajectoryParams, value);
		}

		[Ordinal(5)] 
		[RED("lerpMultiplier")] 
		public CFloat LerpMultiplier
		{
			get => GetProperty(ref _lerpMultiplier);
			set => SetProperty(ref _lerpMultiplier, value);
		}

		public gameprojectileSetUpAndLaunchEvent()
		{
			_lerpMultiplier = 5.000000F;
		}
	}
}
