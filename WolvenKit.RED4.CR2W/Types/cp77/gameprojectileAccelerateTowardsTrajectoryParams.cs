using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileAccelerateTowardsTrajectoryParams : gameprojectileTrajectoryParams
	{
		[Ordinal(0)] [RED("accelerationSpeed")] public CFloat AccelerationSpeed { get; set; }
		[Ordinal(1)] [RED("maxSpeed")] public CFloat MaxSpeed { get; set; }
		[Ordinal(2)] [RED("decelerateTowardsTargetPositionDistance")] public CFloat DecelerateTowardsTargetPositionDistance { get; set; }
		[Ordinal(3)] [RED("maxRotationSpeed")] public CFloat MaxRotationSpeed { get; set; }
		[Ordinal(4)] [RED("minRotationSpeed")] public CFloat MinRotationSpeed { get; set; }
		[Ordinal(5)] [RED("diffForMaxRotation")] public CFloat DiffForMaxRotation { get; set; }
		[Ordinal(6)] [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(7)] [RED("targetComponent")] public wCHandle<entIPlacedComponent> TargetComponent { get; set; }
		[Ordinal(8)] [RED("targetPosition")] public Vector4 TargetPosition { get; set; }
		[Ordinal(9)] [RED("targetOffset")] public Vector4 TargetOffset { get; set; }
		[Ordinal(10)] [RED("accuracy")] public CFloat Accuracy { get; set; }

		public gameprojectileAccelerateTowardsTrajectoryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
