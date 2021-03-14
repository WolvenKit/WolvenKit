using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemHudParameter : effectTrackItem
	{
		private CFloat _scale;
		private effectEffectParameterEvaluator _glitchParameter;
		private CFloat _scale1;
		private effectEffectParameterEvaluator _glitchParameter1;

		[Ordinal(3)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (CFloat) CR2WTypeManager.Create("Float", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("glitchParameter")] 
		public effectEffectParameterEvaluator GlitchParameter
		{
			get
			{
				if (_glitchParameter == null)
				{
					_glitchParameter = (effectEffectParameterEvaluator) CR2WTypeManager.Create("effectEffectParameterEvaluator", "glitchParameter", cr2w, this);
				}
				return _glitchParameter;
			}
			set
			{
				if (_glitchParameter == value)
				{
					return;
				}
				_glitchParameter = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("scale1")] 
		public CFloat Scale1
		{
			get
			{
				if (_scale1 == null)
				{
					_scale1 = (CFloat) CR2WTypeManager.Create("Float", "scale1", cr2w, this);
				}
				return _scale1;
			}
			set
			{
				if (_scale1 == value)
				{
					return;
				}
				_scale1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("glitchParameter1")] 
		public effectEffectParameterEvaluator GlitchParameter1
		{
			get
			{
				if (_glitchParameter1 == null)
				{
					_glitchParameter1 = (effectEffectParameterEvaluator) CR2WTypeManager.Create("effectEffectParameterEvaluator", "glitchParameter1", cr2w, this);
				}
				return _glitchParameter1;
			}
			set
			{
				if (_glitchParameter1 == value)
				{
					return;
				}
				_glitchParameter1 = value;
				PropertySet(this);
			}
		}

		public effectTrackItemHudParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
