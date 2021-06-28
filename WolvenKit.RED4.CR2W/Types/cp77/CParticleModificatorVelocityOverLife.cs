using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorVelocityOverLife : IParticleModificator
	{
		private CHandle<IEvaluatorVector> _velocity;
		private CFloat _scale;
		private CBool _modulate;
		private CBool _absolute;

		[Ordinal(4)] 
		[RED("velocity")] 
		public CHandle<IEvaluatorVector> Velocity
		{
			get => GetProperty(ref _velocity);
			set => SetProperty(ref _velocity, value);
		}

		[Ordinal(5)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(6)] 
		[RED("modulate")] 
		public CBool Modulate
		{
			get => GetProperty(ref _modulate);
			set => SetProperty(ref _modulate, value);
		}

		[Ordinal(7)] 
		[RED("absolute")] 
		public CBool Absolute
		{
			get => GetProperty(ref _absolute);
			set => SetProperty(ref _absolute, value);
		}

		public CParticleModificatorVelocityOverLife(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
