using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameweaponeventsSetMaxChargeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("maxCharge")] 
		public CFloat MaxCharge
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameweaponeventsSetMaxChargeEvent()
		{
			MaxCharge = 100.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
