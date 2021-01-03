using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_SimulationDyng : animDangleConstraint_Simulation
	{
		[Ordinal(0)]  [RED("HACK_checkDangleTeleport")] public CBool HACK_checkDangleTeleport { get; set; }
		[Ordinal(1)]  [RED("dyngConstraint")] public CHandle<animIDyngConstraint> DyngConstraint { get; set; }
		[Ordinal(2)]  [RED("particlesContainer")] public animDyngParticlesContainer ParticlesContainer { get; set; }
		[Ordinal(3)]  [RED("solverIterations")] public CUInt32 SolverIterations { get; set; }
		[Ordinal(4)]  [RED("substepTime")] public CFloat SubstepTime { get; set; }

		public animDangleConstraint_SimulationDyng(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
