using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_SimulationDyng_ : animDangleConstraint_Simulation
	{
		private CBool _hACK_checkDangleTeleport;
		private CFloat _substepTime;
		private CUInt32 _solverIterations;
		private animDyngParticlesContainer _particlesContainer;
		private CHandle<animIDyngConstraint> _dyngConstraint;

		[Ordinal(13)] 
		[RED("HACK_checkDangleTeleport")] 
		public CBool HACK_checkDangleTeleport
		{
			get => GetProperty(ref _hACK_checkDangleTeleport);
			set => SetProperty(ref _hACK_checkDangleTeleport, value);
		}

		[Ordinal(14)] 
		[RED("substepTime")] 
		public CFloat SubstepTime
		{
			get => GetProperty(ref _substepTime);
			set => SetProperty(ref _substepTime, value);
		}

		[Ordinal(15)] 
		[RED("solverIterations")] 
		public CUInt32 SolverIterations
		{
			get => GetProperty(ref _solverIterations);
			set => SetProperty(ref _solverIterations, value);
		}

		[Ordinal(16)] 
		[RED("particlesContainer")] 
		public animDyngParticlesContainer ParticlesContainer
		{
			get => GetProperty(ref _particlesContainer);
			set => SetProperty(ref _particlesContainer, value);
		}

		[Ordinal(17)] 
		[RED("dyngConstraint")] 
		public CHandle<animIDyngConstraint> DyngConstraint
		{
			get => GetProperty(ref _dyngConstraint);
			set => SetProperty(ref _dyngConstraint, value);
		}

		public animDangleConstraint_SimulationDyng_(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
