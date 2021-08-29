using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiNarrationEvent : RedBaseClass
	{
		private CString _text;
		private CFloat _durationSec;
		private CColor _color;

		[Ordinal(0)] 
		[RED("text")] 
		public CString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(1)] 
		[RED("durationSec")] 
		public CFloat DurationSec
		{
			get => GetProperty(ref _durationSec);
			set => SetProperty(ref _durationSec, value);
		}

		[Ordinal(2)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}
	}
}
