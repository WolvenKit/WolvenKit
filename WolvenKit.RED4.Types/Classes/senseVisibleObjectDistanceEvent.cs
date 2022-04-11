using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseVisibleObjectDistanceEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public senseVisibleObjectDistanceEvent()
		{
			Distance = 340282346638528859811704183484516925440.000000F;
		}
	}
}
