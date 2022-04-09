using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entRenderHighlightOpacityEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entRenderHighlightOpacityEvent()
		{
			Opacity = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
