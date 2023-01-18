using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseVisibleObjectDetectionMultEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public senseVisibleObjectDetectionMultEvent()
		{
			Multiplier = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
