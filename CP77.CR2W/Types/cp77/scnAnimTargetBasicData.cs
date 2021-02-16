using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnAnimTargetBasicData : CVariable
	{
		[Ordinal(0)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(1)] [RED("isStart")] public CBool IsStart { get; set; }
		[Ordinal(2)] [RED("targetPerformerId")] public scnPerformerId TargetPerformerId { get; set; }
		[Ordinal(3)] [RED("targetSlot")] public CName TargetSlot { get; set; }
		[Ordinal(4)] [RED("targetOffsetEntitySpace")] public Vector4 TargetOffsetEntitySpace { get; set; }
		[Ordinal(5)] [RED("staticTarget")] public Vector4 StaticTarget { get; set; }
		[Ordinal(6)] [RED("targetActorId")] public scnActorId TargetActorId { get; set; }
		[Ordinal(7)] [RED("targetPropId")] public scnPropId TargetPropId { get; set; }
		[Ordinal(8)] [RED("targetType")] public CEnum<scnLookAtTargetType> TargetType { get; set; }

		public scnAnimTargetBasicData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
