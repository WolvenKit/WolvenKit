using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsclothRuntimeInfo : CVariable
	{
		[Ordinal(0)] [RED("translation")] public Vector3 Translation { get; set; }
		[Ordinal(1)] [RED("rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(2)] [RED("gravity")] public Vector3 Gravity { get; set; }
		[Ordinal(3)] [RED("damping")] public CFloat Damping { get; set; }
		[Ordinal(4)] [RED("drag")] public CFloat Drag { get; set; }
		[Ordinal(5)] [RED("inertia")] public CFloat Inertia { get; set; }
		[Ordinal(6)] [RED("numSolverIterations")] public CUInt32 NumSolverIterations { get; set; }
		[Ordinal(7)] [RED("stiffnessFrequency")] public CFloat StiffnessFrequency { get; set; }
		[Ordinal(8)] [RED("friction")] public CFloat Friction { get; set; }
		[Ordinal(9)] [RED("tetherStiffness")] public CFloat TetherStiffness { get; set; }
		[Ordinal(10)] [RED("tetherScale")] public CFloat TetherScale { get; set; }
		[Ordinal(11)] [RED("selfCollisionDistance")] public CFloat SelfCollisionDistance { get; set; }
		[Ordinal(12)] [RED("selfCollisionStiffness")] public CFloat SelfCollisionStiffness { get; set; }
		[Ordinal(13)] [RED("liftCoefficient")] public CFloat LiftCoefficient { get; set; }
		[Ordinal(14)] [RED("dragCoefficient")] public CFloat DragCoefficient { get; set; }
		[Ordinal(15)] [RED("gravityScale")] public CFloat GravityScale { get; set; }
		[Ordinal(16)] [RED("motionConstraintStiffness")] public CFloat MotionConstraintStiffness { get; set; }
		[Ordinal(17)] [RED("enableSelfCollision")] public CBool EnableSelfCollision { get; set; }

		public physicsclothRuntimeInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
