using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_SimulationDyng_ : animDangleConstraint_Simulation
	{
		[Ordinal(8)] [RED("HACK_checkDangleTeleport")] public CBool HACK_checkDangleTeleport { get; set; }
		[Ordinal(9)] [RED("substepTime")] public CFloat SubstepTime { get; set; }
		[Ordinal(10)] [RED("solverIterations")] public CUInt32 SolverIterations { get; set; }
		[Ordinal(11)] [RED("particlesContainer")] public animDyngParticlesContainer ParticlesContainer { get; set; }
		[Ordinal(12)] [RED("dyngConstraint")] public CHandle<animIDyngConstraint> DyngConstraint { get; set; }

		public animDangleConstraint_SimulationDyng_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
