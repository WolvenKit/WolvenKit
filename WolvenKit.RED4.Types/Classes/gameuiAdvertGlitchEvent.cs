using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiAdvertGlitchEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("glitchValue")] 
		public CFloat GlitchValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiAdvertGlitchEvent()
		{
			GlitchValue = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
