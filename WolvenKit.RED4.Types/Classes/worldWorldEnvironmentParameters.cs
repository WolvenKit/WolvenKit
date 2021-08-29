using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldWorldEnvironmentParameters : RedBaseClass
	{
		private GlobalLightingTrajectory _globalLightingTrajectory;

		[Ordinal(0)] 
		[RED("globalLightingTrajectory")] 
		public GlobalLightingTrajectory GlobalLightingTrajectory
		{
			get => GetProperty(ref _globalLightingTrajectory);
			set => SetProperty(ref _globalLightingTrajectory, value);
		}
	}
}
