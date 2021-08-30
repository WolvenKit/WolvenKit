using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiAdvertGlitchEvent : redEvent
	{
		private CFloat _glitchValue;

		[Ordinal(0)] 
		[RED("glitchValue")] 
		public CFloat GlitchValue
		{
			get => GetProperty(ref _glitchValue);
			set => SetProperty(ref _glitchValue, value);
		}

		public gameuiAdvertGlitchEvent()
		{
			_glitchValue = 1.000000F;
		}
	}
}
