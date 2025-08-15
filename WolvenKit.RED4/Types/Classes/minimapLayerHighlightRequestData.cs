using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class minimapLayerHighlightRequestData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("highlightColor")] 
		public HDRColor HighlightColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(1)] 
		[RED("highlightDuration")] 
		public CFloat HighlightDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("blinkCount")] 
		public CFloat BlinkCount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public minimapLayerHighlightRequestData()
		{
			HighlightColor = new HDRColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
