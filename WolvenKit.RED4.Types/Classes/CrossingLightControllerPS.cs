using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrossingLightControllerPS : TrafficLightControllerPS
	{
		[Ordinal(104)] 
		[RED("crossingLightSFXSetup")] 
		public CrossingLightSetup CrossingLightSFXSetup
		{
			get => GetPropertyValue<CrossingLightSetup>();
			set => SetPropertyValue<CrossingLightSetup>(value);
		}

		public CrossingLightControllerPS()
		{
			DeviceName = "LocKey#125";
			TweakDBRecord = new() { Value = 92771606930 };
			TweakDBDescriptionRecord = new() { Value = 144804359263 };
			CrossingLightSFXSetup = new();
		}
	}
}
