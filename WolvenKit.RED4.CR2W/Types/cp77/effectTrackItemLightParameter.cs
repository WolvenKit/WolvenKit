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
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(4)] 
		[RED("intensityMultiplier")] 
		public effectEffectParameterEvaluatorFloat IntensityMultiplier
		{
			get => GetProperty(ref _intensityMultiplier);
			set => SetProperty(ref _intensityMultiplier, value);
		}

		[Ordinal(5)] 
		[RED("intensity")] 
		public effectEffectParameterEvaluatorFloat Intensity
		{
			get => GetProperty(ref _intensity);
			set => SetProperty(ref _intensity, value);
		}

		[Ordinal(6)] 
		[RED("radius")] 
		public effectEffectParameterEvaluatorFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		public effectTrackItemLightParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
