using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorRotationRate3DOverLife : IParticleModificator
	{
		private CHandle<IEvaluatorVector> _rotationRate;

		[Ordinal(4)] 
		[RED("rotationRate")] 
		public CHandle<IEvaluatorVector> RotationRate
		{
			get => GetProperty(ref _rotationRate);
			set => SetProperty(ref _rotationRate, value);
		}

		public CParticleModificatorRotationRate3DOverLife(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
