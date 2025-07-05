using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetGlitchOnUIEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SetGlitchOnUIEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
