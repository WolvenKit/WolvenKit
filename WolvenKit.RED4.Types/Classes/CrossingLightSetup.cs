using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrossingLightSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("greenLightSFX")] 
		public CName GreenLightSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("redLightSFX")] 
		public CName RedLightSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public CrossingLightSetup()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
