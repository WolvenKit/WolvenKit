using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerRotationRate : IParticleInitializer
	{
		private CHandle<IEvaluatorFloat> _rotationRate;

		[Ordinal(4)] 
		[RED("rotationRate")] 
		public CHandle<IEvaluatorFloat> RotationRate
		{
			get => GetProperty(ref _rotationRate);
			set => SetProperty(ref _rotationRate, value);
		}

		public CParticleInitializerRotationRate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
