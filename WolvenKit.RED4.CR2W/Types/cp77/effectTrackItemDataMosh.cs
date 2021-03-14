using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemDataMosh : effectTrackItem
	{
		private CBool _override;
		private effectEffectParameterEvaluatorFloat _intensity;
		private CBool _useGlitch;
		private effectEffectParameterEvaluatorVector _glitchColor;

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
		[RED("intensity")] 
		public effectEffectParameterEvaluatorFloat Intensity
		{
			get
			{
				if (_intensity == null)
				{
					_intensity = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "intensity", cr2w, this);
				}
				return _intensity;
			}
			set
			{
				if (_intensity == value)
				{
					return;
				}
				_intensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("useGlitch")] 
		public CBool UseGlitch
		{
			get
			{
				if (_useGlitch == null)
				{
					_useGlitch = (CBool) CR2WTypeManager.Create("Bool", "useGlitch", cr2w, this);
				}
				return _useGlitch;
			}
			set
			{
				if (_useGlitch == value)
				{
					return;
				}
				_useGlitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("glitchColor")] 
		public effectEffectParameterEvaluatorVector GlitchColor
		{
			get
			{
				if (_glitchColor == null)
				{
					_glitchColor = (effectEffectParameterEvaluatorVector) CR2WTypeManager.Create("effectEffectParameterEvaluatorVector", "glitchColor", cr2w, this);
				}
				return _glitchColor;
			}
			set
			{
				if (_glitchColor == value)
				{
					return;
				}
				_glitchColor = value;
				PropertySet(this);
			}
		}

		public effectTrackItemDataMosh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
