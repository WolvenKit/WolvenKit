using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinfluenceSeparationAgent : gameinfluenceIAgent
	{
		[Ordinal(0)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameinfluenceSeparationAgent()
		{
			Radius = 0.250000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
