using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrossingLight : TrafficLight
	{
		[Ordinal(87)] 
		[RED("audioLightIsGreen")] 
		public CBool AudioLightIsGreen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CrossingLight()
		{
			ControllerTypeName = "CrossingLightController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
