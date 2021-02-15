using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetCustomShootPosition : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("offset")] public Vector3 Offset { get; set; }
		[Ordinal(1)] [RED("fxOffset")] public Vector3 FxOffset { get; set; }
		[Ordinal(2)] [RED("lockTimer")] public CFloat LockTimer { get; set; }
		[Ordinal(3)] [RED("landIndicatorFX")] public gameFxResource LandIndicatorFX { get; set; }
		[Ordinal(4)] [RED("keepsAcquiring")] public CBool KeepsAcquiring { get; set; }
		[Ordinal(5)] [RED("shootToTheGround")] public CBool ShootToTheGround { get; set; }
		[Ordinal(6)] [RED("predictionTime")] public CFloat PredictionTime { get; set; }
		[Ordinal(7)] [RED("refOwner")] public wCHandle<gamedataAIActionTarget_Record> RefOwner { get; set; }
		[Ordinal(8)] [RED("refAIActionTarget")] public wCHandle<gamedataAIActionTarget_Record> RefAIActionTarget { get; set; }
		[Ordinal(9)] [RED("refCustomWorldPositionTarget")] public wCHandle<gamedataAIActionTarget_Record> RefCustomWorldPositionTarget { get; set; }
		[Ordinal(10)] [RED("ownerPosition")] public Vector4 OwnerPosition { get; set; }
		[Ordinal(11)] [RED("targetPosition")] public Vector4 TargetPosition { get; set; }
		[Ordinal(12)] [RED("fxPosition")] public Vector4 FxPosition { get; set; }
		[Ordinal(13)] [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(14)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(15)] [RED("fxInstance")] public CHandle<gameFxInstance> FxInstance { get; set; }
		[Ordinal(16)] [RED("targetAcquired")] public CBool TargetAcquired { get; set; }
		[Ordinal(17)] [RED("startTime")] public CFloat StartTime { get; set; }

		public SetCustomShootPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
