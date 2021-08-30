using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entRenderHighlightOpacityEvent : redEvent
	{
		private CFloat _opacity;

		[Ordinal(0)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get => GetProperty(ref _opacity);
			set => SetProperty(ref _opacity, value);
		}

		public entRenderHighlightOpacityEvent()
		{
			_opacity = 1.000000F;
		}
	}
}
