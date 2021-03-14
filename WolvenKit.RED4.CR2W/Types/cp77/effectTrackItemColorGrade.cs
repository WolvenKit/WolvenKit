using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemColorGrade : effectTrackItem
	{
		private effectEffectParameterEvaluatorFloat _contrast;
		private effectEffectParameterEvaluatorFloat _saturate;
		private effectEffectParameterEvaluatorFloat _brightness;
		private effectEffectParameterEvaluatorFloat _lutWeight;
		private ColorGradingLutParams _lutParams;
		private ColorGradingLutParams _lutParamsHdr;

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
		[RED("saturate")] 
		public effectEffectParameterEvaluatorFloat Saturate
		{
			get
			{
				if (_saturate == null)
				{
					_saturate = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "saturate", cr2w, this);
				}
				return _saturate;
			}
			set
			{
				if (_saturate == value)
				{
					return;
				}
				_saturate = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("lutWeight")] 
		public effectEffectParameterEvaluatorFloat LutWeight
		{
			get
			{
				if (_lutWeight == null)
				{
					_lutWeight = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "lutWeight", cr2w, this);
				}
				return _lutWeight;
			}
			set
			{
				if (_lutWeight == value)
				{
					return;
				}
				_lutWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("lutParams")] 
		public ColorGradingLutParams LutParams
		{
			get
			{
				if (_lutParams == null)
				{
					_lutParams = (ColorGradingLutParams) CR2WTypeManager.Create("ColorGradingLutParams", "lutParams", cr2w, this);
				}
				return _lutParams;
			}
			set
			{
				if (_lutParams == value)
				{
					return;
				}
				_lutParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("lutParamsHdr")] 
		public ColorGradingLutParams LutParamsHdr
		{
			get
			{
				if (_lutParamsHdr == null)
				{
					_lutParamsHdr = (ColorGradingLutParams) CR2WTypeManager.Create("ColorGradingLutParams", "lutParamsHdr", cr2w, this);
				}
				return _lutParamsHdr;
			}
			set
			{
				if (_lutParamsHdr == value)
				{
					return;
				}
				_lutParamsHdr = value;
				PropertySet(this);
			}
		}

		public effectTrackItemColorGrade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
