using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorVelocityTurbulize : IParticleModificator
	{
		private CHandle<IEvaluatorVector> _scale;
		private CHandle<IEvaluatorFloat> _timelifeLimit;
		private CFloat _noiseInterval;
		private CFloat _duration;
		private CBool _worldSpace;

		[Ordinal(4)] 
		[RED("scale")] 
		public CHandle<IEvaluatorVector> Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(5)] 
		[RED("timelifeLimit")] 
		public CHandle<IEvaluatorFloat> TimelifeLimit
		{
			get => GetProperty(ref _timelifeLimit);
			set => SetProperty(ref _timelifeLimit, value);
		}

		[Ordinal(6)] 
		[RED("noiseInterval")] 
		public CFloat NoiseInterval
		{
			get => GetProperty(ref _noiseInterval);
			set => SetProperty(ref _noiseInterval, value);
		}

		[Ordinal(7)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(8)] 
		[RED("worldSpace")] 
		public CBool WorldSpace
		{
			get => GetProperty(ref _worldSpace);
			set => SetProperty(ref _worldSpace, value);
		}

		public CParticleModificatorVelocityTurbulize(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
