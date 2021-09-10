using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrossingLight : TrafficLight
	{
		[Ordinal(90)] 
		[RED("audioLightIsGreen")] 
		public CBool AudioLightIsGreen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CrossingLight()
		{
			ControllerTypeName = "CrossingLightController";
		}
	}
}
