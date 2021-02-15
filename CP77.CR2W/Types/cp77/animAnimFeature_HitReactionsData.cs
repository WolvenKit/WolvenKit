using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_HitReactionsData : animAnimFeature
	{
		[Ordinal(0)] [RED("hitIntensity")] public CInt32 HitIntensity { get; set; }
		[Ordinal(1)] [RED("hitSource")] public CInt32 HitSource { get; set; }
		[Ordinal(2)] [RED("hitType")] public CInt32 HitType { get; set; }
		[Ordinal(3)] [RED("hitBodyPart")] public CInt32 HitBodyPart { get; set; }
		[Ordinal(4)] [RED("npcMovementSpeed")] public CInt32 NpcMovementSpeed { get; set; }
		[Ordinal(5)] [RED("hitDirection")] public CInt32 HitDirection { get; set; }
		[Ordinal(6)] [RED("npcMovementDirection")] public CInt32 NpcMovementDirection { get; set; }
		[Ordinal(7)] [RED("stance")] public CInt32 Stance { get; set; }
		[Ordinal(8)] [RED("animVariation")] public CInt32 AnimVariation { get; set; }
		[Ordinal(9)] [RED("useInitialRotation")] public CBool UseInitialRotation { get; set; }
		[Ordinal(10)] [RED("hitDirectionWs")] public Vector4 HitDirectionWs { get; set; }
		[Ordinal(11)] [RED("angleToAttack")] public CFloat AngleToAttack { get; set; }
		[Ordinal(12)] [RED("initialRotationDuration")] public CFloat InitialRotationDuration { get; set; }

		public animAnimFeature_HitReactionsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
