using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AlarmLight : BasicDistractionDevice
	{
		[Ordinal(106)] 
		[RED("isGlitching")] 
		public CBool IsGlitching
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AlarmLight()
		{
			ControllerTypeName = "AlarmLightController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
