using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileSetUpAndLaunchEvent : gameprojectileLaunchEvent
	{
		[Ordinal(4)] 
		[RED("trajectoryParams")] 
		public CHandle<gameprojectileTrajectoryParams> TrajectoryParams
		{
			get => GetPropertyValue<CHandle<gameprojectileTrajectoryParams>>();
			set => SetPropertyValue<CHandle<gameprojectileTrajectoryParams>>(value);
		}

		[Ordinal(5)] 
		[RED("lerpMultiplier")] 
		public CFloat LerpMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameprojectileSetUpAndLaunchEvent()
		{
			LerpMultiplier = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
