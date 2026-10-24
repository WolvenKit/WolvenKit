using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animDangleConstraint_SimulationDyng : animDangleConstraint_Simulation
	{
		[Ordinal(8)] 
		[RED("HACK_checkDangleTeleport")] 
		public CBool HACK_checkDangleTeleport
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("substepTime")] 
		public CFloat SubstepTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("solverIterations")] 
		public CUInt32 SolverIterations
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(11)] 
		[RED("particlesContainer")] 
		public animDyngParticlesContainer ParticlesContainer
		{
			get => GetPropertyValue<animDyngParticlesContainer>();
			set => SetPropertyValue<animDyngParticlesContainer>(value);
		}

		[Ordinal(12)] 
		[RED("dyngConstraint")] 
		public CHandle<animIDyngConstraint> DyngConstraint
		{
			get => GetPropertyValue<CHandle<animIDyngConstraint>>();
			set => SetPropertyValue<CHandle<animIDyngConstraint>>(value);
		}

		public animDangleConstraint_SimulationDyng()
		{
			CollisionRoundedShapes = new();
			JsonCollisionShapesLoadedSuccessfully = true;
			Alpha = 1.000000F;
			RotateParentToLookAtDangle = true;
			SubstepTime = 0.010000F;
			SolverIterations = 1;
			ParticlesContainer = new animDyngParticlesContainer();
			DyngConstraint = new animDyngConstraintMulti();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
