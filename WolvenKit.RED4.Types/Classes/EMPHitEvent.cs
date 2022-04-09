using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EMPHitEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("lifetime")] 
		public CFloat Lifetime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public EMPHitEvent()
		{
			Lifetime = 15.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
