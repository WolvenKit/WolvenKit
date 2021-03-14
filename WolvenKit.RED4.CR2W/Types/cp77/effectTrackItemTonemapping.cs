using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemTonemapping : effectTrackItem
	{
		private CBool _override;
		private effectEffectParameterEvaluatorFloat _maxStopsSDR;
		private effectEffectParameterEvaluatorFloat _midGrayScaleSDR;
		private effectEffectParameterEvaluatorFloat _maxStopsHDR;
		private effectEffectParameterEvaluatorFloat _midGrayScaleHDR;

		[Ordinal(3)] 
		[RED("override")] 
		public CBool Override
		{
			get
			{
				if (_override == null)
				{
					_override = (CBool) CR2WTypeManager.Create("Bool", "override", cr2w, this);
				}
				return _override;
			}
			set
			{
				if (_override == value)
				{
					return;
				}
				_override = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maxStopsSDR")] 
		public effectEffectParameterEvaluatorFloat MaxStopsSDR
		{
			get
			{
				if (_maxStopsSDR == null)
				{
					_maxStopsSDR = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "maxStopsSDR", cr2w, this);
				}
				return _maxStopsSDR;
			}
			set
			{
				if (_maxStopsSDR == value)
				{
					return;
				}
				_maxStopsSDR = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("midGrayScaleSDR")] 
		public effectEffectParameterEvaluatorFloat MidGrayScaleSDR
		{
			get
			{
				if (_midGrayScaleSDR == null)
				{
					_midGrayScaleSDR = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "midGrayScaleSDR", cr2w, this);
				}
				return _midGrayScaleSDR;
			}
			set
			{
				if (_midGrayScaleSDR == value)
				{
					return;
				}
				_midGrayScaleSDR = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("maxStopsHDR")] 
		public effectEffectParameterEvaluatorFloat MaxStopsHDR
		{
			get
			{
				if (_maxStopsHDR == null)
				{
					_maxStopsHDR = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "maxStopsHDR", cr2w, this);
				}
				return _maxStopsHDR;
			}
			set
			{
				if (_maxStopsHDR == value)
				{
					return;
				}
				_maxStopsHDR = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("midGrayScaleHDR")] 
		public effectEffectParameterEvaluatorFloat MidGrayScaleHDR
		{
			get
			{
				if (_midGrayScaleHDR == null)
				{
					_midGrayScaleHDR = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "midGrayScaleHDR", cr2w, this);
				}
				return _midGrayScaleHDR;
			}
			set
			{
				if (_midGrayScaleHDR == value)
				{
					return;
				}
				_midGrayScaleHDR = value;
				PropertySet(this);
			}
		}

		public effectTrackItemTonemapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
