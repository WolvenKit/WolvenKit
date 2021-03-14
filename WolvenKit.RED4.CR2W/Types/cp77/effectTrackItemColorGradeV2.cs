using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemColorGradeV2 : effectTrackItem
	{
		private effectEffectParameterEvaluatorFloat _contrast;
		private effectEffectParameterEvaluatorFloat _contrastPivot;
		private effectEffectParameterEvaluatorFloat _saturation;
		private effectEffectParameterEvaluatorFloat _hue;
		private effectEffectParameterEvaluatorFloat _brightness;
		private effectEffectParameterEvaluatorFloat _lowRange;
		private effectEffectParameterEvaluatorFloat _highRange;
		private effectEffectParameterEvaluatorVector _lift;
		private effectEffectParameterEvaluatorVector _gamma;
		private effectEffectParameterEvaluatorVector _gain;
		private effectEffectParameterEvaluatorVector _offset;
		private effectEffectParameterEvaluatorVector _shadow;
		private effectEffectParameterEvaluatorVector _midtone;
		private effectEffectParameterEvaluatorVector _highlight;

		[Ordinal(3)] 
		[RED("contrast")] 
		public effectEffectParameterEvaluatorFloat Contrast
		{
			get
			{
				if (_contrast == null)
				{
					_contrast = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "contrast", cr2w, this);
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

		[Ordinal(4)] 
		[RED("contrastPivot")] 
		public effectEffectParameterEvaluatorFloat ContrastPivot
		{
			get
			{
				if (_contrastPivot == null)
				{
					_contrastPivot = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "contrastPivot", cr2w, this);
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

		[Ordinal(5)] 
		[RED("saturation")] 
		public effectEffectParameterEvaluatorFloat Saturation
		{
			get
			{
				if (_saturation == null)
				{
					_saturation = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "saturation", cr2w, this);
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

		[Ordinal(6)] 
		[RED("hue")] 
		public effectEffectParameterEvaluatorFloat Hue
		{
			get
			{
				if (_hue == null)
				{
					_hue = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "hue", cr2w, this);
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

		[Ordinal(7)] 
		[RED("brightness")] 
		public effectEffectParameterEvaluatorFloat Brightness
		{
			get
			{
				if (_brightness == null)
				{
					_brightness = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "brightness", cr2w, this);
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

		[Ordinal(8)] 
		[RED("lowRange")] 
		public effectEffectParameterEvaluatorFloat LowRange
		{
			get
			{
				if (_lowRange == null)
				{
					_lowRange = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "lowRange", cr2w, this);
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

		[Ordinal(9)] 
		[RED("highRange")] 
		public effectEffectParameterEvaluatorFloat HighRange
		{
			get
			{
				if (_highRange == null)
				{
					_highRange = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "highRange", cr2w, this);
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

		[Ordinal(10)] 
		[RED("lift")] 
		public effectEffectParameterEvaluatorVector Lift
		{
			get
			{
				if (_lift == null)
				{
					_lift = (effectEffectParameterEvaluatorVector) CR2WTypeManager.Create("effectEffectParameterEvaluatorVector", "lift", cr2w, this);
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

		[Ordinal(11)] 
		[RED("gamma")] 
		public effectEffectParameterEvaluatorVector Gamma
		{
			get
			{
				if (_gamma == null)
				{
					_gamma = (effectEffectParameterEvaluatorVector) CR2WTypeManager.Create("effectEffectParameterEvaluatorVector", "gamma", cr2w, this);
				}
				return _gamma;
			}
			set
			{
				if (_gamma == value)
				{
					return;
				}
				_gamma = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("gain")] 
		public effectEffectParameterEvaluatorVector Gain
		{
			get
			{
				if (_gain == null)
				{
					_gain = (effectEffectParameterEvaluatorVector) CR2WTypeManager.Create("effectEffectParameterEvaluatorVector", "gain", cr2w, this);
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

		[Ordinal(13)] 
		[RED("offset")] 
		public effectEffectParameterEvaluatorVector Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (effectEffectParameterEvaluatorVector) CR2WTypeManager.Create("effectEffectParameterEvaluatorVector", "offset", cr2w, this);
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

		[Ordinal(14)] 
		[RED("shadow")] 
		public effectEffectParameterEvaluatorVector Shadow
		{
			get
			{
				if (_shadow == null)
				{
					_shadow = (effectEffectParameterEvaluatorVector) CR2WTypeManager.Create("effectEffectParameterEvaluatorVector", "shadow", cr2w, this);
				}
				return _shadow;
			}
			set
			{
				if (_shadow == value)
				{
					return;
				}
				_shadow = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("midtone")] 
		public effectEffectParameterEvaluatorVector Midtone
		{
			get
			{
				if (_midtone == null)
				{
					_midtone = (effectEffectParameterEvaluatorVector) CR2WTypeManager.Create("effectEffectParameterEvaluatorVector", "midtone", cr2w, this);
				}
				return _midtone;
			}
			set
			{
				if (_midtone == value)
				{
					return;
				}
				_midtone = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("highlight")] 
		public effectEffectParameterEvaluatorVector Highlight
		{
			get
			{
				if (_highlight == null)
				{
					_highlight = (effectEffectParameterEvaluatorVector) CR2WTypeManager.Create("effectEffectParameterEvaluatorVector", "highlight", cr2w, this);
				}
				return _highlight;
			}
			set
			{
				if (_highlight == value)
				{
					return;
				}
				_highlight = value;
				PropertySet(this);
			}
		}

		public effectTrackItemColorGradeV2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
