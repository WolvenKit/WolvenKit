using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemLightParameter : effectTrackItem
	{
		private CFloat _scale;
		private effectEffectParameterEvaluatorFloat _intensityMultiplier;
		private effectEffectParameterEvaluatorFloat _intensity;
		private effectEffectParameterEvaluatorFloat _radius;

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
		[RED("intensityMultiplier")] 
		public effectEffectParameterEvaluatorFloat IntensityMultiplier
		{
			get
			{
				if (_intensityMultiplier == null)
				{
					_intensityMultiplier = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "intensityMultiplier", cr2w, this);
				}
				return _intensityMultiplier;
			}
			set
			{
				if (_intensityMultiplier == value)
				{
					return;
				}
				_intensityMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("radius")] 
		public effectEffectParameterEvaluatorFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		public effectTrackItemLightParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
