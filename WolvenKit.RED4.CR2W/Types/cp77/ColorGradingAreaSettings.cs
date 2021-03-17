using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ColorGradingAreaSettings : IAreaSettings
	{
		private CFloat _contrast;
		private CFloat _contrastPivot;
		private CFloat _saturation;
		private CFloat _hue;
		private CFloat _brightness;
		private ColorBalance _lift;
		private ColorBalance _gammaValue;
		private ColorBalance _gain;
		private ColorBalance _offset;
		private CFloat _lowRange;
		private ColorBalance _shadowOffset;
		private ColorBalance _midtoneOffset;
		private CFloat _highRange;
		private ColorBalance _highlightOffset;
		private ColorGradingLutParams _ldrLut;
		private ColorGradingLutParams _hdrLut;
		private CBool _forceHdrLut;

		[Ordinal(2)] 
		[RED("contrast")] 
		public CFloat Contrast
		{
			get => GetProperty(ref _contrast);
			set => SetProperty(ref _contrast, value);
		}

		[Ordinal(3)] 
		[RED("contrastPivot")] 
		public CFloat ContrastPivot
		{
			get => GetProperty(ref _contrastPivot);
			set => SetProperty(ref _contrastPivot, value);
		}

		[Ordinal(4)] 
		[RED("saturation")] 
		public CFloat Saturation
		{
			get => GetProperty(ref _saturation);
			set => SetProperty(ref _saturation, value);
		}

		[Ordinal(5)] 
		[RED("hue")] 
		public CFloat Hue
		{
			get => GetProperty(ref _hue);
			set => SetProperty(ref _hue, value);
		}

		[Ordinal(6)] 
		[RED("brightness")] 
		public CFloat Brightness
		{
			get => GetProperty(ref _brightness);
			set => SetProperty(ref _brightness, value);
		}

		[Ordinal(7)] 
		[RED("lift")] 
		public ColorBalance Lift
		{
			get => GetProperty(ref _lift);
			set => SetProperty(ref _lift, value);
		}

		[Ordinal(8)] 
		[RED("gammaValue")] 
		public ColorBalance GammaValue
		{
			get => GetProperty(ref _gammaValue);
			set => SetProperty(ref _gammaValue, value);
		}

		[Ordinal(9)] 
		[RED("gain")] 
		public ColorBalance Gain
		{
			get => GetProperty(ref _gain);
			set => SetProperty(ref _gain, value);
		}

		[Ordinal(10)] 
		[RED("offset")] 
		public ColorBalance Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(11)] 
		[RED("lowRange")] 
		public CFloat LowRange
		{
			get => GetProperty(ref _lowRange);
			set => SetProperty(ref _lowRange, value);
		}

		[Ordinal(12)] 
		[RED("shadowOffset")] 
		public ColorBalance ShadowOffset
		{
			get => GetProperty(ref _shadowOffset);
			set => SetProperty(ref _shadowOffset, value);
		}

		[Ordinal(13)] 
		[RED("midtoneOffset")] 
		public ColorBalance MidtoneOffset
		{
			get => GetProperty(ref _midtoneOffset);
			set => SetProperty(ref _midtoneOffset, value);
		}

		[Ordinal(14)] 
		[RED("highRange")] 
		public CFloat HighRange
		{
			get => GetProperty(ref _highRange);
			set => SetProperty(ref _highRange, value);
		}

		[Ordinal(15)] 
		[RED("highlightOffset")] 
		public ColorBalance HighlightOffset
		{
			get => GetProperty(ref _highlightOffset);
			set => SetProperty(ref _highlightOffset, value);
		}

		[Ordinal(16)] 
		[RED("ldrLut")] 
		public ColorGradingLutParams LdrLut
		{
			get => GetProperty(ref _ldrLut);
			set => SetProperty(ref _ldrLut, value);
		}

		[Ordinal(17)] 
		[RED("hdrLut")] 
		public ColorGradingLutParams HdrLut
		{
			get => GetProperty(ref _hdrLut);
			set => SetProperty(ref _hdrLut, value);
		}

		[Ordinal(18)] 
		[RED("forceHdrLut")] 
		public CBool ForceHdrLut
		{
			get => GetProperty(ref _forceHdrLut);
			set => SetProperty(ref _forceHdrLut, value);
		}

		public ColorGradingAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
