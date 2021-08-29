using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrossingLightControllerPS : TrafficLightControllerPS
	{
		private CrossingLightSetup _crossingLightSFXSetup;

		[Ordinal(104)] 
		[RED("crossingLightSFXSetup")] 
		public CrossingLightSetup CrossingLightSFXSetup
		{
			get => GetProperty(ref _crossingLightSFXSetup);
			set => SetProperty(ref _crossingLightSFXSetup, value);
		}
	}
}
