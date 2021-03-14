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
			get
			{
				if (_contrast == null)
				{
					_contrast = (CFloat) CR2WTypeManager.Create("Float", "contrast", cr2w, this);
				}
				return _contrast;
			}
			set
			{
				if (_contrast == value)
				{
					return;
				}
				_contrast = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("contrastPivot")] 
		public CFloat ContrastPivot
		{
			get
			{
				if (_contrastPivot == null)
				{
					_contrastPivot = (CFloat) CR2WTypeManager.Create("Float", "contrastPivot", cr2w, this);
				}
				return _contrastPivot;
			}
			set
			{
				if (_contrastPivot == value)
				{
					return;
				}
				_contrastPivot = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("saturation")] 
		public CFloat Saturation
		{
			get
			{
				if (_saturation == null)
				{
					_saturation = (CFloat) CR2WTypeManager.Create("Float", "saturation", cr2w, this);
				}
				return _saturation;
			}
			set
			{
				if (_saturation == value)
				{
					return;
				}
				_saturation = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hue")] 
		public CFloat Hue
		{
			get
			{
				if (_hue == null)
				{
					_hue = (CFloat) CR2WTypeManager.Create("Float", "hue", cr2w, this);
				}
				return _hue;
			}
			set
			{
				if (_hue == value)
				{
					return;
				}
				_hue = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("brightness")] 
		public CFloat Brightness
		{
			get
			{
				if (_brightness == null)
				{
					_brightness = (CFloat) CR2WTypeManager.Create("Float", "brightness", cr2w, this);
				}
				return _brightness;
			}
			set
			{
				if (_brightness == value)
				{
					return;
				}
				_brightness = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("lift")] 
		public ColorBalance Lift
		{
			get
			{
				if (_lift == null)
				{
					_lift = (ColorBalance) CR2WTypeManager.Create("ColorBalance", "lift", cr2w, this);
				}
				return _lift;
			}
			set
			{
				if (_lift == value)
				{
					return;
				}
				_lift = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("gammaValue")] 
		public ColorBalance GammaValue
		{
			get
			{
				if (_gammaValue == null)
				{
					_gammaValue = (ColorBalance) CR2WTypeManager.Create("ColorBalance", "gammaValue", cr2w, this);
				}
				return _gammaValue;
			}
			set
			{
				if (_gammaValue == value)
				{
					return;
				}
				_gammaValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("gain")] 
		public ColorBalance Gain
		{
			get
			{
				if (_gain == null)
				{
					_gain = (ColorBalance) CR2WTypeManager.Create("ColorBalance", "gain", cr2w, this);
				}
				return _gain;
			}
			set
			{
				if (_gain == value)
				{
					return;
				}
				_gain = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("offset")] 
		public ColorBalance Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (ColorBalance) CR2WTypeManager.Create("ColorBalance", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("lowRange")] 
		public CFloat LowRange
		{
			get
			{
				if (_lowRange == null)
				{
					_lowRange = (CFloat) CR2WTypeManager.Create("Float", "lowRange", cr2w, this);
				}
				return _lowRange;
			}
			set
			{
				if (_lowRange == value)
				{
					return;
				}
				_lowRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("shadowOffset")] 
		public ColorBalance ShadowOffset
		{
			get
			{
				if (_shadowOffset == null)
				{
					_shadowOffset = (ColorBalance) CR2WTypeManager.Create("ColorBalance", "shadowOffset", cr2w, this);
				}
				return _shadowOffset;
			}
			set
			{
				if (_shadowOffset == value)
				{
					return;
				}
				_shadowOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("midtoneOffset")] 
		public ColorBalance MidtoneOffset
		{
			get
			{
				if (_midtoneOffset == null)
				{
					_midtoneOffset = (ColorBalance) CR2WTypeManager.Create("ColorBalance", "midtoneOffset", cr2w, this);
				}
				return _midtoneOffset;
			}
			set
			{
				if (_midtoneOffset == value)
				{
					return;
				}
				_midtoneOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("highRange")] 
		public CFloat HighRange
		{
			get
			{
				if (_highRange == null)
				{
					_highRange = (CFloat) CR2WTypeManager.Create("Float", "highRange", cr2w, this);
				}
				return _highRange;
			}
			set
			{
				if (_highRange == value)
				{
					return;
				}
				_highRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("highlightOffset")] 
		public ColorBalance HighlightOffset
		{
			get
			{
				if (_highlightOffset == null)
				{
					_highlightOffset = (ColorBalance) CR2WTypeManager.Create("ColorBalance", "highlightOffset", cr2w, this);
				}
				return _highlightOffset;
			}
			set
			{
				if (_highlightOffset == value)
				{
					return;
				}
				_highlightOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("ldrLut")] 
		public ColorGradingLutParams LdrLut
		{
			get
			{
				if (_ldrLut == null)
				{
					_ldrLut = (ColorGradingLutParams) CR2WTypeManager.Create("ColorGradingLutParams", "ldrLut", cr2w, this);
				}
				return _ldrLut;
			}
			set
			{
				if (_ldrLut == value)
				{
					return;
				}
				_ldrLut = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("hdrLut")] 
		public ColorGradingLutParams HdrLut
		{
			get
			{
				if (_hdrLut == null)
				{
					_hdrLut = (ColorGradingLutParams) CR2WTypeManager.Create("ColorGradingLutParams", "hdrLut", cr2w, this);
				}
				return _hdrLut;
			}
			set
			{
				if (_hdrLut == value)
				{
					return;
				}
				_hdrLut = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("forceHdrLut")] 
		public CBool ForceHdrLut
		{
			get
			{
				if (_forceHdrLut == null)
				{
					_forceHdrLut = (CBool) CR2WTypeManager.Create("Bool", "forceHdrLut", cr2w, this);
				}
				return _forceHdrLut;
			}
			set
			{
				if (_forceHdrLut == value)
				{
					return;
				}
				_forceHdrLut = value;
				PropertySet(this);
			}
		}

		public ColorGradingAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
