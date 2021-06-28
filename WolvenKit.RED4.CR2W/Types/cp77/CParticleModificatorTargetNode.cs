using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorTargetNode : IParticleModificator
	{
		private CHandle<IEvaluatorFloat> _forceScale;
		private CHandle<IEvaluatorFloat> _killRadius;
		private CFloat _maxForce;

		[Ordinal(4)] 
		[RED("forceScale")] 
		public CHandle<IEvaluatorFloat> ForceScale
		{
			get => GetProperty(ref _forceScale);
			set => SetProperty(ref _forceScale, value);
		}

		[Ordinal(5)] 
		[RED("killRadius")] 
		public CHandle<IEvaluatorFloat> KillRadius
		{
			get => GetProperty(ref _killRadius);
			set => SetProperty(ref _killRadius, value);
		}

		[Ordinal(6)] 
		[RED("maxForce")] 
		public CFloat MaxForce
		{
			get => GetProperty(ref _maxForce);
			set => SetProperty(ref _maxForce, value);
		}

		public CParticleModificatorTargetNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
