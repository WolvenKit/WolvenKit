using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetFadeInOut_NodeType : questIRenderFxManagerNodeType
	{
		private CColor _fadeColor;
		private CBool _fadeIn;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("fadeColor")] 
		public CColor FadeColor
		{
			get => GetProperty(ref _fadeColor);
			set => SetProperty(ref _fadeColor, value);
		}

		[Ordinal(1)] 
		[RED("fadeIn")] 
		public CBool FadeIn
		{
			get => GetProperty(ref _fadeIn);
			set => SetProperty(ref _fadeIn, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		public questSetFadeInOut_NodeType()
		{
			_fadeIn = true;
			_duration = 2.000000F;
		}
	}
}
