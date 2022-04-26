using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficLightStage : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("color")] 
		public CEnum<worldTrafficLightColor> Color
		{
			get => GetPropertyValue<CEnum<worldTrafficLightColor>>();
			set => SetPropertyValue<CEnum<worldTrafficLightColor>>(value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldTrafficLightStage()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
