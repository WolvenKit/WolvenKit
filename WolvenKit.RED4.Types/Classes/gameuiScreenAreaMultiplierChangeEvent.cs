using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiScreenAreaMultiplierChangeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("screenAreaMultiplier")] 
		public CFloat ScreenAreaMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiScreenAreaMultiplierChangeEvent()
		{
			ScreenAreaMultiplier = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
