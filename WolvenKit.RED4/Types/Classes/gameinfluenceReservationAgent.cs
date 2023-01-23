using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinfluenceReservationAgent : gameinfluenceIAgent
	{
		[Ordinal(0)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameinfluenceReservationAgent()
		{
			Radius = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
