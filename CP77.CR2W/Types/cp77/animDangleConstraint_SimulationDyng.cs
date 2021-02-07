using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_SimulationDyng : animDangleConstraint_Simulation
	{
		[Ordinal(0)]  [RED("HACK_checkDangleTeleport")] public CBool HACK_checkDangleTeleport { get; set; }
		[Ordinal(1)]  [RED("substepTime")] public CFloat SubstepTime { get; set; }
		[Ordinal(2)]  [RED("solverIterations")] public CUInt32 SolverIterations { get; set; }
		[Ordinal(3)]  [RED("particlesContainer")] public animDyngParticlesContainer ParticlesContainer { get; set; }
		[Ordinal(4)]  [RED("dyngConstraint")] public CHandle<animIDyngConstraint> DyngConstraint { get; set; }

        [Ordinal(994)] [RED("drawDebugCollisionCapsule")] public CBool drawDebugCollisionCapsule { get; set; }
        [Ordinal(995)] [RED("drawDebugCollisionShapes")] public CBool drawDebugCollisionShapes { get; set; }
        [Ordinal(996)] [RED("drawDebugConstraint")] public CBool drawDebugConstraint { get; set; }
        [Ordinal(997)] [RED("drawDebugAxis")] public CBool drawDebugAxis { get; set; }
        [Ordinal(998)] [RED("drawDebugText")] public CBool drawDebugText { get; set; }

		public animDangleConstraint_SimulationDyng(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
