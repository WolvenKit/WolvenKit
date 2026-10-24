using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldWorldEnvironmentParameters : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("globalLightingTrajectory")] 
		public GlobalLightingTrajectory GlobalLightingTrajectory
		{
			get => GetPropertyValue<GlobalLightingTrajectory>();
			set => SetPropertyValue<GlobalLightingTrajectory>(value);
		}

		public worldWorldEnvironmentParameters()
		{
			GlobalLightingTrajectory = new GlobalLightingTrajectory();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
