using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseVisibleObjectetSecondaryDistanceEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public senseVisibleObjectetSecondaryDistanceEvent()
		{
			Distance = 340282346638528859811704183484516925440.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
