using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinfluenceHeatAgent : gameinfluenceIAgent
	{
		[Ordinal(0)] 
		[RED("timeToNextUpdate")] 
		public CFloat TimeToNextUpdate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("heatRadius")] 
		public CFloat HeatRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("heatValue")] 
		public CFloat HeatValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameinfluenceHeatAgent()
		{
			HeatRadius = 1.500000F;
			HeatValue = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
