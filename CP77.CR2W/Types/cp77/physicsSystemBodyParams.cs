using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsSystemBodyParams : CVariable
	{
		[Ordinal(0)]  [RED("angularDamping")] public CFloat AngularDamping { get; set; }
		[Ordinal(1)]  [RED("comOffset")] public Transform ComOffset { get; set; }
		[Ordinal(2)]  [RED("inertia")] public Vector3 Inertia { get; set; }
		[Ordinal(3)]  [RED("linearDamping")] public CFloat LinearDamping { get; set; }
		[Ordinal(4)]  [RED("mass")] public CFloat Mass { get; set; }
		[Ordinal(5)]  [RED("maxAngularVelocity")] public CFloat MaxAngularVelocity { get; set; }
		[Ordinal(6)]  [RED("maxContactImpulse")] public CFloat MaxContactImpulse { get; set; }
		[Ordinal(7)]  [RED("maxDepenetrationVelocity")] public CFloat MaxDepenetrationVelocity { get; set; }
		[Ordinal(8)]  [RED("simulationType")] public CEnum<physicsSimulationType> SimulationType { get; set; }
		[Ordinal(9)]  [RED("solverIterationsCountPosition")] public CUInt32 SolverIterationsCountPosition { get; set; }
		[Ordinal(10)]  [RED("solverIterationsCountVelocity")] public CUInt32 SolverIterationsCountVelocity { get; set; }

		public physicsSystemBodyParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
